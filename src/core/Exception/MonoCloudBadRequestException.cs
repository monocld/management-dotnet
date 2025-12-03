namespace MonoCloud.Management.Core.Exception;

/// <summary>
/// The MonoCloud Bad Request Exception
/// </summary>
public class MonoCloudBadRequestException : MonoCloudRequestException
{
  /// <summary>
  /// Initializes the MonoCloudBadRequestException Class
  /// </summary>
  /// <param name="response">The problem details returned from the server.</param>
  public MonoCloudBadRequestException(ProblemDetails response) : base(response)
  {
  }

  /// <summary>
  /// Initializes the MonoCloudBadRequestException Class
  /// </summary>
  /// <param name="message">The error message returned from the server.</param>
  public MonoCloudBadRequestException(string message) : base(message)
  {
  }
}
