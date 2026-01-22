int number = 19;

if (number == 0)
{
    Console.WriteLine($"Your number is zero.");
}

else if (number >= 10 || number <= -10)
{
    Console.WriteLine($"Your number, {(number)} is multi-digit.");

}

else
{
    Console.WriteLine($"Your number, {(number)} is single-digit.");
}