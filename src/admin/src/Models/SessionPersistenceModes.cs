namespace MonoCloud.Management.Admin.Models;

public enum SessionPersistenceModes
{
  /// <summary>
  /// The session will be persisted in accordance with the Expiration Type.
  /// </summary>
  Persistent,

  /// <summary>
  /// The session will expire when the browser is closed.
  /// </summary>
  NonPersistent,

  /// <summary>
  /// if the user chooses to remember the session will be persisted in accordance with the Expiration Type.
  /// </summary>
  UserSelected
}


