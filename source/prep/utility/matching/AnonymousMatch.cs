namespace prep.utility.matching
{
  public class AnonymousMatch<Item> : IMatchAn<Item>
  {
    Condition<Item> condition;

    public AnonymousMatch(Condition<Item> condition)
    {
      this.condition = condition;
    }

    public bool matches(Item item)
    {
      return condition(item);
    }
  }
}