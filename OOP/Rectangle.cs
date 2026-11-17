using System;

namespace OOP;

class Rectangle
{
  // fields
  private int _width;
  private int _height;

  // Properties
  // Old school C# way
  public int Width
  {
    // accessors (getters and setters)
    get
    {
      return _width;
    }
    set
    {
      if (value > 0)
      {
        _width = value;
      }
    }
  }

  public int Height
  {
    // getter
    get
    {
      return _height;
    }

    // setter
    set
    {
      if (value > 0)
      {
        _height = value;
      }
    }
  }

  // Constructor
  public Rectangle(int width, int height)
  {
    _width = width;
    _height = height;
  }
  // Methods
  public string AsString()
  {
    return $"Width = {_width} - Height = {_height}";
  }
}

public class HotelBooking
{
  // Public fields
  public string GustName;
  public DateTime StartDate;
  public DateTime EndDate;

  // Constructor
  public HotelBooking(string guestName, DateTime startDate, int lengthOfStayInDays)
  {
    GustName = guestName;
    StartDate = startDate;
    EndDate = startDate.AddDays(lengthOfStayInDays);
  }
}


class ShapeMeasurmentsCalculator
{
  public int CalculateRectangleCircumference(Rectangle rectangle)
  {
    return (rectangle.Width + rectangle.Height) * 2;
  }

  // public int CalculateRectangleArea(Rectangle rectangle)
  // {
  //   return rectangle._width * rectangle._height;
  // }


  // Expression bodied methods
  public int CalculateRectangleArea(Rectangle rectangle) => rectangle.Width * rectangle.Height;
}



