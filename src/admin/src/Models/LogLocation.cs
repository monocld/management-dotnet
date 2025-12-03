namespace MonoCloud.Management.Admin.Models;

/// <summary>
/// The Log Location response
/// </summary>
public class LogLocation
{
  /// <summary>
  /// The region of the request.
  /// </summary>
  public string? Region { get; set; }

  /// <summary>
  /// The region code of the request.
  /// </summary>
  public string? RegionCode { get; set; }

  /// <summary>
  /// The city of the request.
  /// </summary>
  public string? City { get; set; }

  /// <summary>
  /// The country of the request.
  /// </summary>
  public string? Country { get; set; }

  /// <summary>
  /// The continent of the request.
  /// </summary>
  public string? Continent { get; set; }

  /// <summary>
  /// The latitude of the request.
  /// </summary>
  public string? Latitude { get; set; }

  /// <summary>
  /// The longitude of the request.
  /// </summary>
  public string? Longitude { get; set; }

  /// <summary>
  /// The time zone of the request.
  /// </summary>
  public string? TimeZone { get; set; }

  /// <summary>
  /// The zip code of the request.
  /// </summary>
  public string? ZipCode { get; set; }
}


