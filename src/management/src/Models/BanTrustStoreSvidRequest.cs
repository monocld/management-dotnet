namespace MonoCloud.Management.Models;

/// <summary>
/// Ban Trust Store SVID Request: Defines a SPIFFE SVID that is blocked from authentication within a trust store.
/// </summary>
public class BanTrustStoreSvidRequest
{
  /// <summary>
  /// The identifier value used for banning.
  /// </summary>
  public string Value { get; set; }

  /// <summary>
  /// The reason explaining why the SVID was banned.
  /// </summary>
  public string? Reason { get; set; }
}


