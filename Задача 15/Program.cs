Console.Write("Введите номер дня недели: ");
int dayNum = Convert.ToInt32(Console.ReadLine());
if (dayNum > 0 && dayNum < 8)
{
    if (dayNum > 5) 
    {
        Console.WriteLine("Да!");
    }
    else
    {
        Console.WriteLine("Нет!");
    }
}
else
{
    Console.WriteLine("Нет такого дня недели.");
}