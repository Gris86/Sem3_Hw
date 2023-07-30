// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите пятизначное число:");
string num=Console.ReadLine();
if(num.Length!=5) Console.WriteLine("Число не пятизначное!");
else{
    if(num[0]==num[4] && num[1]==num[3]) Console.WriteLine($"Число {num} палиндром.");
    else Console.WriteLine($"Число {num} не палиндром.");
}

