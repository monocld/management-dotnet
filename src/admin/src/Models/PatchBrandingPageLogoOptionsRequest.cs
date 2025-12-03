namespace MonoCloud.Management.Admin.Models;

/// <summary>
/// The Patch Branding Page Logo Options Request class
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchBrandingPageLogoOptionsRequest>))]
public class PatchBrandingPageLogoOptionsRequest
{
  /// <summary>
  /// Specifies the height (in Pixels) of the client / project logo
  /// </summary>
  public Optional<int> Height { get; set; }

  /// <summary>
  /// Specifies the horizontal position of the logo
  /// </summary>
  public Optional<string> Position { get; set; }
}


