// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите координаты первой точки через пробел:");
string a=Console.ReadLine();
string[] a1=a.Split(' ');
Console.WriteLine("Введите координаты второй точки через пробел:");
string b=Console.ReadLine();
string[] b1=b.Split(' ');
Console.WriteLine($"Координаты первой точки: ({a1[0]};{a1[1]};{a1[2]}).");
Console.WriteLine($"Координаты второй точки: ({b1[0]};{b1[1]};{b1[2]}).");
int l1=int.Parse(a1[0])-int.Parse(b1[0]);
int l2=int.Parse(a1[1])-int.Parse(b1[1]);
int l3=int.Parse(a1[2])-int.Parse(b1[2]);
double dist=Math.Sqrt(Math.Pow(l1,2)+Math.Pow(l2,2)+Math.Pow(l3,2));
Console.WriteLine($"Расстояние между точками ({a1[0]};{a1[1]};{a1[2]}) и ({b1[0]};{b1[1]};{b1[2]}) равно {dist:f2}");

