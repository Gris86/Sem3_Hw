// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите пятизначное число:");
string number=Console.ReadLine();
if(number.Length!=5) Console.WriteLine($"Число {number} не пятизначное.");
//int num=new Random().Next(10000,99999);
else{
    int num =int.Parse(number);
    if(num/10000==num%10 && (num/1000)%10==(num/10)%10) Console.WriteLine($"Число {num} палиндром.");
    else Console.WriteLine($"Число {num} не палиндром.");}


