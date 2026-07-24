namespace MonoCloud.Management.Models;

/// <summary>
/// Determines whether an email received from an external identity provider is treated as verified.
/// </summary>
public enum TrustIdentifierModes
{
  /// <summary>
  /// The email is treated as verified based on the email_verified claim received from the external provider.
  /// </summary>
  AsProvided,

  /// <summary>
  /// The email is never treated as verified.
  /// </summary>
  Never,

  /// <summary>
  /// The email is always treated as verified.
  /// </summary>
  Always
}


