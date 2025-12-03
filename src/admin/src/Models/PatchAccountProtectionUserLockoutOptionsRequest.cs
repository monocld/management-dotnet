namespace MonoCloud.Management.Admin.Models;

/// <summary>
/// The Patch Account Protection User Lockout Options Request class
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchAccountProtectionUserLockoutOptionsRequest>))]
public class PatchAccountProtectionUserLockoutOptionsRequest
{
  /// <summary>
  /// Enable User Lockout
  /// </summary>
  public Optional<bool> Enabled { get; set; }

  /// <summary>
  /// Maximum Number of failed attempts a user account can have before the user is locked out. The specified value is inclusive of the count.
  /// </summary>
  public Optional<int> MaxFailedAccessAttempts { get; set; }

  /// <summary>
  /// Lockout duration in minutes once a user account has been locked out.
  /// </summary>
  public Optional<int> UserLockoutTimeSpan { get; set; }

  /// <summary>
  /// Lockout duration in minutes once an Ip address has been locked out.
  /// </summary>
  public Optional<int> IpLockoutTimeSpan { get; set; }

  /// <summary>
  /// Whitelisted IP Addresses where the Account Protection does not trigger.
  /// </summary>
  public Optional<List<string>> AllowedIps { get; set; }

  /// <summary>
  /// Types of Lockouts to enable per User Account
  /// </summary>
  public Optional<UserLockoutTypes> LockoutType { get; set; }

  /// <summary>
  /// Account Protection User Unblock Options
  /// </summary>
  public Optional<PatchAccountProtectionUserUnblockOptionsRequest> UserUnblock { get; set; }
}


