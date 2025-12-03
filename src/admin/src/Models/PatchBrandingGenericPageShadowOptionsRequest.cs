namespace MonoCloud.Management.Admin.Models;

/// <summary>
/// The Patch Branding Generic Page Shadow Options Request class
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchBrandingGenericPageShadowOptionsRequest>))]
public class PatchBrandingGenericPageShadowOptionsRequest
{
  /// <summary>
  /// Specifies the horizontal offset of the shadow (in Pixels)
  /// </summary>
  public Optional<float> HOffset { get; set; }

  /// <summary>
  /// Specifies the vertical offset of the shadow (in Pixels)
  /// </summary>
  public Optional<float> VOffset { get; set; }

  /// <summary>
  /// Specifies the blur radius (in Pixels)
  /// </summary>
  public Optional<float> Blur { get; set; }

  /// <summary>
  /// Specifies the spread radius (in Pixels)
  /// </summary>
  public Optional<float> Spread { get; set; }

  /// <summary>
  /// Specifies the color of the shadow (in Hex)
  /// </summary>
  public Optional<string> Color { get; set; }

  /// <summary>
  /// Specifies if the shadow is an inner shadow
  /// </summary>
  public Optional<bool> Inset { get; set; }
}


