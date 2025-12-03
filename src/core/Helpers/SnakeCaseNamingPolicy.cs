namespace MonoCloud.Management.Core.Helpers;

/// <summary>
///
/// </summary>
public class SnakeCaseNamingPolicy : JsonNamingPolicy
{
  /// <summary>
  ///
  /// </summary>
  /// <param name="name"></param>
  /// <returns></returns>
  public override string ConvertName(string name) => name.ToSnakeCase();
}
