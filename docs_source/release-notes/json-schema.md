# [1.3.0](https://github.com/gregsdennis/json-everything/pull/25)

[#15](https://github.com/gregsdennis/json-everything/issues/15) Easier navigation of the schema and its subschemas. Added `ISchemaContainer`, `ISchemaCollector`, and `IKeyedSchemaCollector` for the varying sets of subschemas that keywords can have.  Added `SchemaKeywordExtensions.GetSubschemas()` extension method.

[#19](https://github.com/gregsdennis/json-everything/issues/19) Keyword filtering doesn't consider declared draft or `ValidationOptions.ValidateAs`.

# [1.2.0](https://github.com/gregsdennis/json-everything/pull/17)

([json-schema<nsp>.org #358](https://github.com/json-schema-org/json-schema-org.github.io/pull/358)) Published draft 06 meta-schema doesn't match the copy in the spec repo.

[#16](https://github.com/gregsdennis/json-everything/issues/16) `JsonSchema` equality checking.  Along with this, added `IEquatable<T>` to `SchemaKeywordRegistry.Register<T>()`.

[#18](https://github.com/gregsdennis/json-everything/issues/18) `properties` keyword is processed with same priority as `additionalProperties` making keyword order important, but it shouldn't be.

Added `EnumerableExtensions.ContentsEqual()`.

# [1.1.0](https://github.com/gregsdennis/json-everything/pull/11)

Added `SchemaRegistry.Fetch` property to enable automatic downloading of referenced schemas.

# [1.0.3](https://github.com/gregsdennis/json-everything/pull/11)

[#9](https://github.com/gregsdennis/json-everything/pull/11) `if`/`then`/`else` are processed in serialized order instead of processing `if` first.

[#10](https://github.com/gregsdennis/json-everything/pull/10) Bug fix around deserialization of `readonly` keyword.

# [1.0.2](https://github.com/gregsdennis/json-everything/pull/7)

Updated format `json-pointer` to require plain pointers.  URI-encoded pointers are invalid.

# [1.0.1](https://github.com/gregsdennis/json-everything/pull/6)

Updated validation of formats `hostname`, `iri`, `uri`, `regex`, and `time`.

Fixed issue resolving references (`$ref` & `$recursiveRef`) to miscellaneous (non-keyword) schema data.

# 1.0.0

Initial release.