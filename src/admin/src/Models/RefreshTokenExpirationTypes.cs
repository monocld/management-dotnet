namespace MonoCloud.Management.Admin.Models;

public enum RefreshTokenExpirationTypes
{
  /// <summary>
  /// When refreshing the token, the lifetime of the refresh token will be renewed (by the amount specified in &quot;Sliding Refresh Token Lifetime&quot; parameter). The lifetime will not exceed the time specified in the &quot;Absolute Refresh Token Lifetime&quot; parameter
  /// </summary>
  Sliding,

  /// <summary>
  /// The refresh token will expire on a fixed point in time (specified by the &quot;Absolute Refresh Token Lifetime&quot; parameter)
  /// </summary>
  Absolute
}


