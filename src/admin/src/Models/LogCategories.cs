namespace MonoCloud.Management.Admin.Models;

/// <summary>
/// Categories for events
/// </summary>
public enum LogCategories
{
  /// <summary>
  /// Authentication related events
  /// </summary>
  Authentication,

  /// <summary>
  /// Token related events
  /// </summary>
  Tokens,

  /// <summary>
  /// Consent related events
  /// </summary>
  Consent,

  /// <summary>
  /// Blocks related events
  /// </summary>
  Blocks,

  /// <summary>
  /// User related events
  /// </summary>
  Users,

  /// <summary>
  /// User Sessions related events
  /// </summary>
  UserSessions,

  /// <summary>
  /// Notifications related events
  /// </summary>
  Notifications,

  /// <summary>
  /// Resources related events
  /// </summary>
  Resources,

  /// <summary>
  /// Trust Store related events
  /// </summary>
  TrustStore,

  /// <summary>
  /// Clients related events
  /// </summary>
  Clients,

  /// <summary>
  /// Groups related events
  /// </summary>
  Groups
}


