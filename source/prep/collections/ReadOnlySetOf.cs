using System.Collections;
using System.Collections.Generic;

namespace prep.collections
{
  public class ReadOnlySetOf<Item> : IEnumerable<Item>
  {
    IList<Item> items;

    public ReadOnlySetOf(IList<Item> items)
    {
      this.items = items;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
      return GetEnumerator();
    }

    public IEnumerator<Item> GetEnumerator()
    {
      return items.GetEnumerator();
    }
  }
}