using System;

namespace OOP;

public class Order
{
  // Backing fields
  private string _item;
  private DateTime _date;

  // Properties
  public string Item { get; }
  public DateTime Date
  {
    get
    {
      return _date;
    }
    set
    {
      if (value.Year == DateTime.Now.Year)
      {
        this._date = value;
      }
    }
  }

}
