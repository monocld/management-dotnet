namespace MonoCloud.Management.Models;

/// <summary>
/// The supported methods of sending a bearer access token to a protected resource (RFC 6750 / RFC 9728 &#x60;bearer_methods_supported&#x60;).
/// </summary>
public enum BearerMethods
{
  /// <summary>
  /// The access token is sent in the `Authorization` request header field.
  /// </summary>
  Header,

  /// <summary>
  /// The access token is sent in the HTML form-encoded request body.
  /// </summary>
  Body,

  /// <summary>
  /// The access token is sent as a URI query parameter.
  /// </summary>
  Query
}


