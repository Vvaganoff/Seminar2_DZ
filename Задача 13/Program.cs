Console.Write( "Введите число: ");
int number = Convert.ToInt32( Console.ReadLine());
string strNumber = Convert.ToString( number );

if (number > 99) 
{
    Console.WriteLine( $"Третья цифра:  {strNumber[2]}" );
}
else
{
    Console.WriteLine( "В этом числе нет третьей цифры!" );
}
