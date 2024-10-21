Console.WriteLine("Введите координаты пушки в виде (x0,y0): ");
string[] input = Console.ReadLine().Split(",");
double x0 = Convert.ToDouble(input[0]);
double y0 = Convert.ToDouble(input[1]);

Console.Write("Введите начальную скорость снаряда (v0): ");
double v0 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите угол вылета снаряда (α) в градусах: ");
double corner = Convert.ToDouble(Console.ReadLine());

double cornerRad = corner * (Math.PI/180) ;

double vx0 = v0 * Math.Cos(cornerRad);
double vy0 = v0 * Math.Sin(cornerRad);

double g = 9.81;
double t = 0; 
double dt = 0.1;

List<double> yVal = new List<double>();
Console.WriteLine($"time \t horiz \t height");
while (true)
{
    double x = x0 + vx0 * t; 
    double y = y0 + vy0 * t - 0.5 * g * t * t;
    yVal.Add(y);

    Console.WriteLine($"{t:F2} \t {x:F2} \t {y:F2}");
    if (y <= 0)
        break;
    t += dt;
}

Console.WriteLine($"Наивысшая точка траиктории снаряда ровна: {yVal.Max():F2}");

Console.WriteLine("Снаряд упал на землю.");