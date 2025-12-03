namespace MonoCloud.Management.Admin.Models;

public enum RevocationCheckDepth
{
  /// <summary>
  /// Only the end certificate is checked for revocation
  /// </summary>
  EndCertificateOnly,

  /// <summary>
  /// The entire chain of certificates, except the root certificate is checked for revocation
  /// </summary>
  ExcludeRoot,

  /// <summary>
  /// The entire chain of certificates is checked for revocation
  /// </summary>
  EntireChain
}


