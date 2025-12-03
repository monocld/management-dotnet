namespace MonoCloud.Management.Admin.Models;

/// <summary>
/// The Create Scope Claim Request class
/// </summary>
public class CreateScopeClaimRequest
{
  /// <summary>
  /// Specifies the name of the claim.
  /// </summary>
  public string Claim { get; set; }

  /// <summary>
  /// Specifies whether the claim will be included in the Identity Token.
  /// </summary>
  public bool? IncludeInIdentityToken { get; set; }

  /// <summary>
  /// Specifies whether the claim will be returned from the user info endpoint.
  /// </summary>
  public bool? IncludeInUserInfo { get; set; }
}


