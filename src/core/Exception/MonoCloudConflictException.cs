namespace MonoCloud.Management.Core.Exception;

/// <summary>
/// The MonoCloud Conflict Exception
/// </summary>
public class MonoCloudConflictException : MonoCloudCodedException
{
  /// <summary>
  /// Initializes the MonoCloudConflictException Class
  /// </summary>
  /// <param name="response">The problem details returned from the server.</param>
  public MonoCloudConflictException(ProblemDetails response) : base(response)
  {
  }

  /// <summary>
  /// Initializes the MonoCloudConflictException Class
  /// </summary>
  /// <param name="message">The error message returned from the server.</param>
  public MonoCloudConflictException(string message) : base(message)
  {
  }
}
