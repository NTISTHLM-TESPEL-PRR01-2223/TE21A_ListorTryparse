
List<string> teachers = new();

teachers.Add("Micke");
teachers.Add("Martin");
teachers.Add("Karim");

Random generator = new();
int i = generator.Next(teachers.Count);

Console.WriteLine(teachers[i]);


Console.ReadLine();


// int money = 0;
// bool success = false;

// while (success == false)
// {
//   Console.WriteLine("Hur mycket pengar vill du satsa? Skriv en siffra.");
//   string moneyText = Console.ReadLine();
//   success = int.TryParse(moneyText, out money);

//   if (success == false)
//   {
//     Console.WriteLine("En siffra sa jag, sopa!");
//   }
// }

// Console.WriteLine("yay");


