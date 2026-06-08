namespace MonoCloud.Management.Models;

/// <summary>
/// Patch Basic API Access Policy Request: Used to partially update a basic API access policy.
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchApiAccessBasicPolicyRequest>))]
public class PatchApiAccessBasicPolicyRequest
{
  /// <summary>
  /// Indicates whether the policy is enabled.
  /// </summary>
  public Optional<bool> Enabled { get; set; }

  /// <summary>
  /// Human-readable name for the policy.
  /// </summary>
  public Optional<string> Name { get; set; }

  /// <summary>
  /// Description that explains the purpose of the policy.
  /// </summary>
  public Optional<string?> Description { get; set; }

  /// <summary>
  /// Action settings applied when the policy fires.
  /// </summary>
  public Optional<PatchApiAccessPolicyActionsRequest> Actions { get; set; }

  /// <summary>
  /// The API scopes that may be requested by the client. If empty, all scopes may be requested.
  /// </summary>
  public Optional<List<string>> Scopes { get; set; }
}


