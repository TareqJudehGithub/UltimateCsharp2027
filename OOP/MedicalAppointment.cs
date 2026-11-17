using System;

namespace OOP;

public class MedicalAppointment
{
  private string _patientName;
  private DateTime _date;

  // Constructors
  public MedicalAppointment(
    string patientName, DateTime date)
  {
    _patientName = patientName;
    _date = date;
  }


  // Methods
  public void ShowAppointmentDate()
  {
    System.Console.WriteLine($"Patient: {_patientName}\nAppointment: {Convert.ToString(_date.ToShortDateString())}");
  }
  public void Reschedule(DateTime date)
  {
    // Set a new date for the appointment
    _date = date;
    System.Console.WriteLine(_date.ToShortDateString());
  }
  public void OverwriteMonthAndDay(int month, int day)
  {
    // set a new date for the appointment but showing only month and day
    _date = new DateTime(year: _date.Year, month: month, day: day);
    System.Console.WriteLine(_date.ToShortDateString());
  }

  public void MoveByMonthsAndDays(int monthsToAdd, int daysToAdd)
  {
    // Move appointment by 1 month
    _date = new DateTime(
      year: _date.Year,
      month: _date.Month + monthsToAdd,
      day: _date.Day + daysToAdd
      );
    System.Console.WriteLine(_date.ToShortDateString());
  }
}
