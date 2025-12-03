namespace MonoCloud.Management.Core.Exception;

/// <summary>
/// The MonoCloud Resource Exhausted Exception
/// </summary>
public class MonoCloudResourceExhaustedException : MonoCloudRequestException
{
  /// <summary>
  /// Initializes the MonoCloudResourceExhaustedException Class
  /// </summary>
  /// <param name="response">The problem details returned from the server.</param>
  public MonoCloudResourceExhaustedException(ProblemDetails response) : base(response)
  {
  }

  /// <summary>
  /// Initializes the MonoCloudResourceExhaustedException Class
  /// </summary>
  /// <param name="message">The error message returned from the server.</param>
  public MonoCloudResourceExhaustedException(string message) : base(message)
  {
  }
}
