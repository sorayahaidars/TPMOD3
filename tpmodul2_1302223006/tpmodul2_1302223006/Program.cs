// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;

Console.WriteLine("Masukkan satu huruf: ");
string huruf = Console.ReadLine();

if (huruf == "A" || huruf == "I" || huruf == "U" || huruf == "E" || huruf == "O") 
{
    Console.WriteLine("Huruf " + huruf + " merupakan huruf vokal");
}
else
{
    Console.WriteLine("Huruf " + huruf + " merupakan huruf konsonan");
}

int[] angka = { 2, 4, 6, 8, 10 };

for (int i = 0; i < angka.Length; i++)
{
    Console.WriteLine("Angka genap " + (i + 1) + " :" + angka[i]);
}