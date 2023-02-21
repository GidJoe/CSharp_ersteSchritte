String Name, Haustier;
int alter;

Console.WriteLine("Hello World, dies ist mein erste C# Programm");
Console.WriteLine("Sag mir dein Alter");
alter = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Sag mir deinen Namen");
Name = Console.ReadLine();

Console.WriteLine("Sag mir den Namen deines Haustier");
Haustier = Console.ReadLine();


Console.WriteLine("Dein Name lautet " + Name + ". Dein Haustier heißt " + Haustier + " und du bist " + alter);




