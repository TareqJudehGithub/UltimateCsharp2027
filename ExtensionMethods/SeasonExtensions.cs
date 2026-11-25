namespace ExtensionMethods;

public static class SeasonExtensions
{
  public static Season Next(this Season season)
  {
    int currentSeasonAsInt = (int)season;
    int nextSeason = (currentSeasonAsInt + 1) % 4;
    return (Season)nextSeason;
  }
  public static Season Previous(this Season season)
  {
    int currentSeasonAsInt = (int)season;
    int prevSeason = (currentSeasonAsInt + 3) % 4;
    return (Season)prevSeason;
  }
}
