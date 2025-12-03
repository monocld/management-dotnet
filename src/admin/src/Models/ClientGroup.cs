namespace MonoCloud.Management.Admin.Models;

/// <summary>
/// The Client Group response class
/// </summary>
public class ClientGroup
{
  /// <summary>
  /// Unique ID of the group
  /// </summary>
  public Guid GroupId { get; set; }

  /// <summary>
  /// The client ID
  /// </summary>
  public string ClientId { get; set; }

  /// <summary>
  /// The group name
  /// </summary>
  public string GroupName { get; set; }

  /// <summary>
  /// Specifies the creation time of the client group (in Epoch).
  /// </summary>
  public DateTime CreationTime { get; set; }
}


