﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using System.Text.Json.Nodes;

namespace Json.Path;

internal class WildcardSelector : ISelector, IHaveShorthand
{
	public string ToShorthandString()
	{
		return ".*";
	}

	public void AppendShorthandString(StringBuilder builder)
	{
		builder.Append(".*");
	}

	public override string ToString()
	{
		return "*";
	}

	public IEnumerable<PathMatch> Evaluate(PathMatch match)
	{
		var node = match.Value;
		if (node is JsonObject obj)
		{
			foreach (var member in obj)
			{
				yield return new PathMatch(member.Value, match.Location.Append(member.Key));
			}
		}
		else if (node is JsonArray arr)
		{
			for (var i = 0; i < arr.Count; i++)
			{
				var member = arr[(Index)i];
				yield return new PathMatch(member, match.Location.Append(i));
			}
		}
	}

	public void BuildString(StringBuilder builder)
	{
		builder.Append('*');
	}
}

internal class WildcardSelectorParser : ISelectorParser
{
	public bool TryParse(ReadOnlySpan<char> source, ref int index, [NotNullWhen(true)] out ISelector? selector)
	{
		if (source[index] != '*')
		{
			selector = null;
			return false;
		}

		selector = new WildcardSelector();
		index++;
		return true;
	}
}