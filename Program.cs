// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
int l=2;
Console.Write($"{number}->1");
while(l<=number){
    Console.Write($", {Math.Pow(l,3)}");
    l++;
}
