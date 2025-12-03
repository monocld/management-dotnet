namespace MonoCloud.Management.Admin.Models;

/// <summary>
/// The Patch Username Identifier Options Request class
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchIdentifiersUsernameOptionsRequest>))]
public class PatchIdentifiersUsernameOptionsRequest
{
  /// <summary>
  /// Specifies if the users are allowed to sign-in using a username
  /// </summary>
  public Optional<bool> EnableSignIn { get; set; }

  /// <summary>
  /// Specifies if the users are allowed to enter a username at the time of registration.
  /// </summary>
  public Optional<bool> ShowAtSignUp { get; set; }

  /// <summary>
  /// Specifies if the username is required at the time of registration.
  /// </summary>
  public Optional<bool> RequiredAtSignUp { get; set; }

  /// <summary>
  /// Specifies the minimum length required for the username.
  /// </summary>
  public Optional<int> MinimumLength { get; set; }
}


