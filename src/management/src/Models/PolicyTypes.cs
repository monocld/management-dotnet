namespace MonoCloud.Management.Models;

/// <summary>
/// The policy rule authoring type.
/// </summary>
public enum PolicyTypes
{
  /// <summary>
  /// A rule authored from the structured condition primitives.
  /// </summary>
  Basic,

  /// <summary>
  /// A rule authored as a raw Cedar expression.
  /// </summary>
  Advanced
}


