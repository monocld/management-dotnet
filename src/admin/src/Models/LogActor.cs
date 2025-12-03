namespace MonoCloud.Management.Admin.Models;

/// <summary>
/// The Log Actor response
/// </summary>
public class LogActor
{
  /// <summary>
  /// Indicates the type of actor who performed an action.
  /// </summary>
  public ActorTypes Type { get; set; }


  public string? Id { get; set; }
}


