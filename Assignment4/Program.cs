using System.Globalization;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

string[] array = {"breakfast","brunch","lunch","snack","dinner" };

var result = string.Join("-", array);
var result2 = string.Join("-", array,2,3);
Console.WriteLine(result);
Console.WriteLine(result2);

string mystring = "Good morning!This is a test program";
string[] x = mystring.Split("!");

    foreach (var word in x)
        {
           Console.WriteLine(word);
   
        }

    if(mystring.Contains("morning"))
        {
           Console.WriteLine(mystring.ToUpper());
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

Console.WriteLine("The waiting time was with {0} minutes more than the normal waiting time",duration);

DateTimeOffset dateuser1 = DateTimeOffset.Now;
DateTimeOffset dateuser2 = DateTimeOffset.UtcNow;
TimeSpan difference = dateuser1 - dateuser2;
Console.WriteLine("Difference: {0} - {1} = {2}", dateuser1,dateuser2,difference);


var localTimeZone = TimeZoneInfo.Local;
Console.WriteLine("Time zone display name:{0}", localTimeZone.DisplayName); //same as .ToString()

CultureInfo enUs = new CultureInfo("en-US");
CultureInfo roRO = new CultureInfo("ro-RO");
Console.WriteLine("First day of the week in US is {0} and in Romania is {1} ",enUs.DateTimeFormat.FirstDayOfWeek.ToString(), roRO.DateTimeFormat.FirstDayOfWeek.ToString());

