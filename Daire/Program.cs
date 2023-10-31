using System;

public class CircleDrawer
{
    public void DrawCircle(int radius)
    {
        double angleIncrement = 0.01;
        for (double angle = 0; angle < 2 * Math.PI; angle += angleIncrement)
        {
            int x = (int)(radius * Math.Cos(angle));
            int y = (int)(radius * Math.Sin(angle));

            Console.SetCursorPosition(radius + x, radius - y);
            Console.Write("*");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Dairenin yarıçapını girin: ");
        int radius = int.Parse(Console.ReadLine());

        CircleDrawer circleDrawer = new CircleDrawer();
        circleDrawer.DrawCircle(radius);

        Console.ReadLine(); // Çizim ekranda kalsın diye bekleyin
    }
}
