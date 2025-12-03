namespace MonoCloud.Management.Admin.Models;

/// <summary>
/// Indicates the type of target on which an action was performed.
/// </summary>
public enum TargetTypes
{
  /// <summary>
  /// A user
  /// </summary>
  User,

  /// <summary>
  /// A tenant
  /// </summary>
  Tenant,

  /// <summary>
  /// A tenant key
  /// </summary>
  TenantKey,

  /// <summary>
  /// Subscription
  /// </summary>
  Subscription,

  /// <summary>
  /// A client
  /// </summary>
  Client,

  /// <summary>
  /// A client secret
  /// </summary>
  ClientSecret,

  /// <summary>
  /// A group
  /// </summary>
  Group,

  /// <summary>
  /// The user consent
  /// </summary>
  UserConsent,

  /// <summary>
  /// The user identifier
  /// </summary>
  UserIdentifier,

  /// <summary>
  /// The authenticator
  /// </summary>
  Authenticator,

  /// <summary>
  /// The ip address
  /// </summary>
  IpAddress,

  /// <summary>
  /// An user session
  /// </summary>
  UserSession,

  /// <summary>
  /// An user grant
  /// </summary>
  UserGrants,

  /// <summary>
  /// The Trust Store
  /// </summary>
  TrustStore,

  /// <summary>
  /// An Api Resource
  /// </summary>
  ApiResource,

  /// <summary>
  /// An Api Resource secret
  /// </summary>
  ApiResourceSecret,

  /// <summary>
  /// A Claim Resource
  /// </summary>
  ClaimResource,

  /// <summary>
  /// A Scope
  /// </summary>
  Scope,

  /// <summary>
  /// An Api Scope
  /// </summary>
  ApiScope,

  /// <summary>
  /// A Key Material
  /// </summary>
  KeyMaterial,

  /// <summary>
  /// The System
  /// </summary>
  System
}


