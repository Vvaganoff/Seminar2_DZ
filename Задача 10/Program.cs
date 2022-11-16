Console.Write( "Введите трёхзначное число: ");
int number = Convert.ToInt32( Console.ReadLine());
if (number > 99 &&  number < 1000) 
{
    Console.WriteLine( $"Вторая цифра:  {number % 100 / 10}" );
}
else
{
    Console.WriteLine( "Это число не трёхзначное!" );
}