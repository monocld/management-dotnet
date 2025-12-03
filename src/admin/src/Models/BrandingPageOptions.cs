namespace MonoCloud.Management.Admin.Models;

/// <summary>
/// The Branding Page Options response class
/// </summary>
public class BrandingPageOptions
{
  /// <summary>
  /// Specifies whether or not the MonoCloud watermark will be shown on the login pages
  /// </summary>
  public bool ShowWatermark { get; set; }

  /// <summary>
  /// Page Branding Logo Options
  /// </summary>
  public BrandingPageLogoOptions Logo { get; set; }

  /// <summary>
  /// Page Branding Layout Options
  /// </summary>
  public BrandingPageLayoutOptions Layout { get; set; }

  /// <summary>
  /// Page Branding Link Options
  /// </summary>
  public BrandingPageLinkOptions Link { get; set; }

  /// <summary>
  /// Page Branding Link Options
  /// </summary>
  public BrandingPageInputOptions Input { get; set; }

  /// <summary>
  /// Page Branding Checkbox Options
  /// </summary>
  public BrandingPageCheckboxOptions Checkbox { get; set; }

  /// <summary>
  /// Page Branding Button Options
  /// </summary>
  public BrandingPageButtonOptions Button { get; set; }

  /// <summary>
  /// Page Branding Provider Button Options
  /// </summary>
  public BrandingPageProviderButtonOptions ProviderButton { get; set; }

  /// <summary>
  /// Page Branding Code Options
  /// </summary>
  public BrandingPageCodeOptions Code { get; set; }

  /// <summary>
  /// Page Branding Text Options
  /// </summary>
  public BrandingPageTextOptions Text { get; set; }
}


