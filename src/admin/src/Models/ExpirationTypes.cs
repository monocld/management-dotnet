namespace MonoCloud.Management.Admin.Models;

public enum ExpirationTypes
{
  /// <summary>
  /// On each interaction of the user with the authorization server, the lifetime of the session will be renewed (by the amount specified in &quot;Remember Me Duration&quot; parameter). The lifetime will not exceed the time specified in the &quot;Logout After&quot; parameter
  /// </summary>
  Sliding,

  /// <summary>
  /// The session will expire on a fixed point in time (specified by the &quot;Remember Me Duration&quot; parameter)
  /// </summary>
  Absolute
}


