namespace MonoCloud.Management.Admin.Models;

public enum EventCodes
{
  AuthorizationFailure,

  AuthorizationSuccess,

  ParFailure,

  ParSuccess,

  ClientAuthenticationFailure,

  ClientAuthenticationSuccess,

  ApiAuthenticationFailure,

  ApiAuthenticationSuccess,

  ResourceOwnerAuthenticationFailure,

  ResourceOwnerAuthenticationSuccess,

  DeviceAuthorizationFailure,

  DeviceAuthorizationSuccess,

  CertificateAuthenticationFailure,

  CertificateAuthenticationSuccess,

  IdentifierSignInFailure,

  ExternalSignInFailure,

  UserSignInFailure,

  UserSignIn,

  UserSignUp,

  UserLogout,

  TokenIssuedFailure,

  TokenIssuedSuccess,

  TokenIntrospectionFailure,

  TokenIntrospectionSuccess,

  TokenRevocationSuccess,

  TokenRevocationFailure,

  ConsentGranted,

  ConsentDenied,

  IdentifierIpBlocked,

  UserAccountIpBlocked,

  UserAccountBlocked,

  UserAccountUnblocked,

  UserAccountIpUnblocked,

  UserAccountAllUnblocked,

  UserAccountAllIpsUnblocked,

  UserCreated,

  UserDeleted,

  UserAddedToGroup,

  UserRemovedFromGroup,

  UserPasswordResetSuccess,

  UserSessionRevoked,

  UserSessionsRevokedAll,

  UserSessionsDeletedAll,

  SignInEmailSentEvent,

  VerificationEmailSentEvent,

  WelcomeEmailSent,

  PasswordUpdatedEmailSent,

  PasswordResetEmailSent,

  UserBlockedEmailSent,

  SignInSmsSentEvent,

  VerificationSmsSentEvent,

  PasswordResetSmsSent,

  EmailSendFailure,

  SmsSendFailure,

  ApiResourceCreated,

  ApiResourceUpdated,

  ApiResourceDeleted,

  ApiResourceSecretCreated,

  ApiResourceSecretDeleted,

  ApiResourceClientCreated,

  ApiResourceClientRemoved,

  ApiResourceClientUpdated,

  TrustStoreCreated,

  TrustStoreUpdated,

  TrustStoreDeleted,

  TrustStoreCertificateBanned,

  TrustStoreCertificateUnbanned,

  TrustStoreRevocationAdded,

  TrustStoreRevocationRemoved,

  ClientCreated,

  ClientUpdated,

  ClientDeleted,

  ClientAddedToGroup,

  ClientRemovedFromGroup,

  ClientSecretCreated,

  ClientSecretDeleted,

  GroupCreated,

  GroupUpdated,

  GroupDeleted,

  UserGrantsUserDeletedAll,

  AuthorizationCodeGrantDeleted,

  UserConsentGrantDeleted,

  ReferenceTokenGrantDeleted,

  RefreshTokenGrantDeleted
}


