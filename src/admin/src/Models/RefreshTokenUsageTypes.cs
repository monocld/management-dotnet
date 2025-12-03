namespace MonoCloud.Management.Admin.Models;

public enum RefreshTokenUsageTypes
{
  /// <summary>
  /// The refresh token handle will stay the same when refreshing tokens
  /// </summary>
  Reuse,

  /// <summary>
  /// The refresh token handle will be updated when refreshing tokens
  /// </summary>
  OneTimeOnly
}


