using OOP;
Console.WriteLine("OOP!");

var Booking1 = new HotelBooking(
  guestName: "John Smith", startDate: new DateTime(2026, 11, 15), lengthOfStayInDays: 5);
System.Console.WriteLine(Booking1.GustName);

var rectangle = new Rectangle(width: 5, height: 3);
rectangle.Width = 5;
rectangle.Height = 8;
var calculator = new ShapeMeasurmentsCalculator();
System.Console.WriteLine(
  calculator.CalculateRectangleCircumference(rectangle: rectangle));
System.Console.WriteLine(calculator.CalculateRectangleArea(rectangle: rectangle));
Console.WriteLine();

// MedicalAppointment
var johnSmith = new MedicalAppointment(
  patientName: "John Smith", date: new DateTime(2026, 11, 18));

johnSmith.ShowAppointmentDate();
johnSmith.Reschedule(date: new DateTime(year: 2026, month: 11, day: 25));
johnSmith.OverwriteMonthAndDay(10, 14);
johnSmith.MoveByMonthsAndDays(2, 1);


int age = 51;
System.Console.WriteLine(nameof(age));