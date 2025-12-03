namespace MonoCloud.Management.Admin.Models;

public enum X509RevocationMode
{
  /// <summary>
  /// Will not check for revocation.
  /// </summary>
  NoCheck,

  /// <summary>
  /// Will check for revocation with root CA and intermediary CAs
  /// </summary>
  Online,

  /// <summary>
  /// Will check for revocation against the customer generated revocation list
  /// </summary>
  Offline
}


