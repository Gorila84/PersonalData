string name;
string surname;
string phoneNumber;
string email;
double weight;
int height;
string street;
int homeNumber;
string city;
string postalCode;

Console.WriteLine("Enter your name:");
name = Console.ReadLine();

Console.WriteLine("Enter your surname:");
surname = Console.ReadLine();

Console.WriteLine("Enter your phone number:");
phoneNumber = Console.ReadLine();

Console.WriteLine("Enter your email:");
email = Console.ReadLine();

Console.WriteLine("Enter your weight:");
var enteredWeight = Console.ReadLine();
double.TryParse(enteredWeight, out weight);

Console.WriteLine("Enter your height:");
var enteredHeight = Console.ReadLine();
Int32.TryParse(enteredHeight, out height);

Console.WriteLine("Enter the name of the street you live on:");
street = Console.ReadLine();

Console.WriteLine("Enter the home number:");
var enteredHomeNumber = Console.ReadLine();
Int32.TryParse(enteredHomeNumber, out homeNumber);

Console.WriteLine("Enter the the city:");
city = Console.ReadLine();

Console.WriteLine("Enter the postal code (00-000):");
postalCode = Console.ReadLine();

Console.WriteLine($"Your name is: {name}");
Console.WriteLine($"Your surname is: {surname}");
Console.WriteLine($"Your phone number is: {phoneNumber}");
Console.WriteLine($"Your email is: {email}");
Console.WriteLine($"Your weight is: {weight}");
Console.WriteLine($"Your height is: {height}");
Console.WriteLine($"Your street is: {street}");
Console.WriteLine($"Your homenumber is: {homeNumber}");
Console.WriteLine($"Your city is: {city}");
Console.WriteLine($"Your postal code is: {postalCode}");

