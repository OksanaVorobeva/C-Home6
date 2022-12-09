Console.WriteLine("Введите значение b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение k1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение b2");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение k2");
double k2 = Convert.ToInt32(Console.ReadLine());
Amount(b1,k1,b2,k2);

void Amount(double b1, double k1, double b2, double k2)
{
double x = 0;
double y = 0;
if(k1!=k2)
{
 x = ((b1 - b2) / (k2 - k1));
    y = ((k2 * x) + b2);
    Console.WriteLine($"Точки пересечения двух прямых [{x}; {y}]");
    
}
else if(b1==b2||k1==k2)
{
    Console.WriteLine("Прямые совпадают");
}
else
{
    Console.WriteLine("Точек пересечения нет");
}   
}