namespace MonoCloud.Management.Core.Exception;

/// <summary>
/// The base of the exceptions the api reports a machine-readable error code with. The statuses that carry one are
/// 400, 402, 403, 404 and 409 — the others (401, 422, 429, 500) report what went wrong without a code, so they
/// derive from <see cref="MonoCloudRequestException"/> directly and have no <c>ErrorCode</c> to read.
/// </summary>
public abstract class MonoCloudCodedException : MonoCloudRequestException
{
  /// <summary>
  /// Initializes the MonoCloudCodedException Class
  /// </summary>
  /// <param name="response">The problem details returned from the server.</param>
  protected MonoCloudCodedException(ProblemDetails response) : base(response)
  {
  }

  /// <summary>
  /// Initializes the MonoCloudCodedException Class
  /// </summary>
  /// <param name="message">The error message returned from the server.</param>
  protected MonoCloudCodedException(string message) : base(message)
  {
  }

  /// <summary>
  /// The machine-readable code identifying the error. Null when the operation reported this status without one,
  /// so a code being absent is not on its own a sign that anything is wrong.
  /// </summary>
  public string? ErrorCode => Response?.ErrorCode;
}
