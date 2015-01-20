namespace prep.utility.matching
{
  public class OrMatch<Item> : IMatchAn<Item>
  {
    IMatchAn<Item> left;
    IMatchAn<Item> right;

    public OrMatch(IMatchAn<Item> left, IMatchAn<Item> right)
    {
      this.left = left;
      this.right = right;
    }

    public bool matches(Item item)
    {
      return left.matches(item) || right.matches(item);
    }
  }
}