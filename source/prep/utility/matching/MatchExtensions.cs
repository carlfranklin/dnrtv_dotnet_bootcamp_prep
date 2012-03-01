namespace prep.utility.matching
{
  public static class MatchExtensions
  {
    public static IMatchAn<Item> or<Item>(this IMatchAn<Item> left, IMatchAn<Item> right)
    {
      return new OrMatch<Item>(left, right);
    }
  }
}