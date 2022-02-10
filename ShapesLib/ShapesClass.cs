using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesLib
{
    public class ShapesClass
    {
        /// <summary>Площадь треугольника по трем сторонам</summary>
        /// <param name="sideA">Сторона А</param>
        /// <param name="sideB">Сторона B</param>
        /// <param name="sideC">Сторона C</param>
        /// <returns>Площадь</returns>
        public static double ShapesTiangle(double sideA, double sideB, double sideC) 
        {
            double halfP = (sideA + sideB + sideC) / 2;
            double Shapes = Math.Sqrt(halfP * (halfP - sideA) * (halfP - sideB) * (halfP - sideC));
            return Math.Round(Shapes, 2);
        }
        /// <summary>Площадь треугольника по двум сторонам и углу</summary>
        /// <param name="sideA">Сторона А</param>
        /// <param name="sideB">Сторона B</param>
        /// <param name="Angle">Угол в градусах</param>
        /// <returns>Площадь</returns>
        public static double ShapesTiangle2(double sideA, double sideB, float Angle)
        {
            double Shapes = 0.5 * sideA * sideB * Math.Sin(Math.PI * Angle / 180.0);
            return Math.Round( Shapes, 3);
        }
        /// <summary>Площадь треугольника по трем сторонам</summary>
        /// <param name="sideA">Сторона А</param>
        /// <param name="sideB">Сторона B</param>
        /// <returns>Площадь</returns>
        public static double ShapesRectangle(double sideA, double sideB)
        {
            double Shapes = sideA * sideB;
            return Math.Round(Shapes, 2);
        }

        /// <summary>Площадь круга</summary>
        /// <param name="sideA">Радиус</param>
        /// <returns>Площадь</returns>
        public static double ShapesCircle(double sideA)
        {
            double Shapes = Math.PI * sideA * sideA;
            return Math.Round(Shapes, 2);
        }
    }
}
