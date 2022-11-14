using System.Globalization;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

string[] array = { "breakfast", "brunch", "lunch", "snack", "dinner" };

var myResult = string.Join("-", array);
var myResult2 = string.Join("-", array, 2, 3);
Console.WriteLine(myResult);
Console.WriteLine(myResult2);

string myString = "Good morning!This is a test program";
string[] x = myString.Split("!");

foreach (var word in x)
{
    Console.WriteLine(word);

}

if (myString.Contains("morning"))
{
    Console.WriteLine(myString.ToUpper());
    Console.WriteLine("It is morning");
}


TimeSpan six = new TimeSpan(6, 0, 0); //6 o'clock am
TimeSpan noon = new TimeSpan(12, 0, 0); //12 o'clock
TimeSpan SIX = new TimeSpan(18, 0, 0); //6 o'clock pm
TimeSpan MIDNIGHT = new TimeSpan(24, 0, 0); //midnight
TimeSpan now = DateTime.Now.TimeOfDay;

if ((now >= six) && (now < noon))
{
    Console.WriteLine("Good morning!");
}
else if ((now >= noon) && (now < SIX))
{
    Console.WriteLine("Good afternoon!");
}
else if ((now >= SIX) && (now < MIDNIGHT))
{
    Console.WriteLine("good evening");
}
else Console.WriteLine("Good night");


var start = DateTime.Now;
var end = DateTime.Now.AddMinutes(3);
var duration = end - start;

Console.WriteLine("The waiting time was with {0} minutes more than the normal waiting time", duration);

DateTimeOffset dateUser1 = DateTimeOffset.Now;
DateTimeOffset dateUser2 = DateTimeOffset.UtcNow;
TimeSpan difference = dateUser1 - dateUser2;
Console.WriteLine("Difference: {0} - {1} = {2}", dateUser1, dateUser2, difference);


var localTimeZone = TimeZoneInfo.Local;
Console.WriteLine("Time zone display name:{0}", localTimeZone.DisplayName); //same as .ToString()

CultureInfo enUs = new CultureInfo("en-US");
CultureInfo roRO = new CultureInfo("ro-RO");
Console.WriteLine("First day of the week in US is {0} and in Romania is {1} ", enUs.DateTimeFormat.FirstDayOfWeek.ToString(), roRO.DateTimeFormat.FirstDayOfWeek.ToString());

