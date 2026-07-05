namespace MonoCloud.Management.Models;


public class HttpFeatureFlagResponse
{
  /// <summary>
  /// The flag&#39;s unique name.
  /// </summary>
  public string Name { get; set; }

  /// <summary>
  /// Human-readable description of what the flag controls.
  /// </summary>
  public string Description { get; set; }

  /// <summary>
  /// The code default applied when no override is set at any scope.
  /// </summary>
  public bool DefaultEnabled { get; set; }

  /// <summary>
  /// The override stored for this scope, or null when the flag inherits from a broader scope.
  /// </summary>
  public bool? Override { get; set; }
}


