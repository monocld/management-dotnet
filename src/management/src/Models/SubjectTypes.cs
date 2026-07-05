namespace MonoCloud.Management.Models;

/// <summary>
/// The OIDC subject identifier type used when issuing the &#x60;sub&#x60; claim to a client.
/// </summary>
public enum SubjectTypes
{
  /// <summary>
  /// The same sub value is returned to every client (the user's real subject id).
  /// </summary>
  Public,

  /// <summary>
  /// A pseudonymous, per-sector sub value is returned so the same user is seen as a different subject across sectors.
  /// </summary>
  Pairwise
}


