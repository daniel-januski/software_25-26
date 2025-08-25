// See https://aka.ms/new-console-template for more information


string name;
string name1;
string sub;
string revelence;
string date;

Console.WriteLine("first and last name-resepent");
name = Console.ReadLine();
Console.WriteLine("first and last name-sender");
name1 = Console.ReadLine();
Console.WriteLine("subget of form");
sub = Console.ReadLine();
Console.WriteLine("topic of revelence");
revelence = Console.ReadLine(); 
Console.WriteLine("follow up date");
date = Console.ReadLine();
DateTime.Now.ToShortDateString();

Console.WriteLine("from" + name1);
Console.WriteLine("to" + name);
Console.WriteLine("subget" + sub);
Console.WriteLine("this email is informing on proget" + revelence);
Console.WriteLine("with the progress on the progect");
Console.WriteLine("we estmate it beibg conpleted in" + date);
Console.WriteLine("sincerly " + name1);
