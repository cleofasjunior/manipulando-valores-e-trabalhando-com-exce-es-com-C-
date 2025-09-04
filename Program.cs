using System;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string[] parts = input.Split(',');

        string guestName = parts[0].Trim();
        int roomNumber = int.Parse(parts[1].Trim());
        int days = int.Parse(parts[2].Trim());

        int totalValue = days * 150;

        Console.WriteLine($"{guestName} vai se hospedar no quarto {roomNumber} por R${totalValue}");
    }
}
