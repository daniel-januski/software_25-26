// See https://aka.ms/new-console-template for more information
using static System.Console;
int langth = 0;
WriteLine("eneter charcter langth and width" + short.MaxValue);
langth = short.Parse(Console.ReadLine());
for (int i = 0; i < langth; i++)
{

    for (int j = 0; j < 10; j++) 
      Write(j);
    Console.WriteLine(i);
}
