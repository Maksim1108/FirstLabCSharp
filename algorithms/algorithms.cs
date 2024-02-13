using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLab.algorithms
{
    internal class Algorithms
    {
        // Функция для проверки пересечения отрезка и прямоугольника
        public bool doIntersect(double x1, double y1, double x2, double y2,
                            double x3, double y3, double x4, double y4)
        {
            // Проверка, что точки отрезка находятся по разные стороны от границ прямоугольника
            return (x3 <= x2 && x4 >= x1 && y3 <= y2 && y4 >= y1);
        }


        // Функция для нахождения координат точек пересечения
        public double[] findIntersection(double x1, double y1, double x2, double y2,
                                     double x3, double y3, double x4, double y4)
        {
            double[] intersection = new double[2];

            // Находим координаты точки пересечения
            intersection[0] = Math.Max(x1, x3);
            intersection[1] = Math.Max(y1, y3);

            return intersection;
        }

        public bool outputResultForTests(double x1, double y1, double x2, double y2,
                                     double x3, double y3, double x4, double y4)
        {
            if (doIntersect(x1, y1, x2, y2, x3, y3, x4, y4))
            {
                // Нахождение координат точек пересечения
                double[] intersection = findIntersection(x1, y1, x2, y2, x3, y3, x4, y4);
                Console.WriteLine($"\nОтрезок и прямоугольник пересекаются. Координаты точки пересечения: ({intersection[0]}, {intersection[1]})\n");
                return true;
            }
            else
            {
                Console.WriteLine("\nОтрезок и прямоугольник не пересекаются.\n");
                return true;
            }
        }
    }
}
