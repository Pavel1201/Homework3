Console.WriteLine("Введите пятизначное число: ");
string number = Console.ReadLine();
bool check = int.TryParse(number,out var number1);
if(check == false)
{
    while(check == false)
   {
     Console.WriteLine("Вы ввели не число, введите, пятизначное число: ");
     number = Console.ReadLine();
     check = int.TryParse(number,out number1);
   }

}

int count = 0;

for (int i = 0; i < number.Length / 2; i++)
{
    if(number[i] == number[number.Length - i - 1])
    {
       count++;
    }


}
if (count == number.Length/2)
{
    Console.WriteLine($"Число {number} является палиндромом");
}
else
{
    Console.WriteLine("Число не является палинромом");
}