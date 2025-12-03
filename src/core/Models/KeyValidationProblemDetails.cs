namespace MonoCloud.Management.Core.Models;

public class KeyValidationProblemDetails : ProblemDetails
{
  /// <summary>
  /// A collection of errors
  /// </summary>
  public IDictionary<string, string[]> Errors { get; set; } = new Dictionary<string, string[]>();
}
