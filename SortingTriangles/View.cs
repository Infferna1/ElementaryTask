using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortingTriangles
{
    class View
    {
        public double GetASide()
        {
            Console.WriteLine("Enter A side of triangle:");//Валидация
            double aSide = double.Parse(Console.ReadLine());
            while ((aSide <= 0) || (aSide >= 51))
            {
                Console.WriteLine("Side A must be bigger than 0 and lower than 51\nEnter A side:");
                aSide = double.Parse(Console.ReadLine());
            }
            return aSide;
        }
        public double GetBSide()
        {
            Console.WriteLine("Enter B side of triangle:");//Валидация
            double bSide = double.Parse(Console.ReadLine());
            while ((bSide <= 0) || (bSide >= 51))
            {
                Console.WriteLine("Side B must be bigger than 0 and lower than 51\nEnter B side:");
                bSide = double.Parse(Console.ReadLine());
            }
            return bSide;
        }
        public double GetCSide()
        {
            Console.WriteLine("Side C side of triangle:");//Валидация
            double cSide = double.Parse(Console.ReadLine());
            while ((cSide <= 0) || (cSide >= 51))
            {
                Console.WriteLine("Side C must be bigger than 0 and lower than 51\nEnter Enter C side:");
                cSide = double.Parse(Console.ReadLine());
            }
            return cSide;
        }
        
        public string GetNameTriangle()
        {
            Console.WriteLine("Enter name of triangle:");//Валидация
            string nameOfTriangle = Console.ReadLine();
            return nameOfTriangle;
        }

        public Dictionary<string, double> NewTriangle()
        {
            string answer;
            Dictionary<string, double> triangle = new Dictionary<string, double>();
            do
            {
                SortingTriangles srtTr = new SortingTriangles(GetASide(), GetBSide(), GetCSide()/*, GetNameTriangle()*/);
                triangle.Add(GetNameTriangle(), srtTr.TrianglesAnalysis());
                Console.WriteLine("Do you want to continue?(y/n)");
                answer = Console.ReadLine();
            } while (answer == "y");
            return triangle;
        }

        public void TrianglesPrint(Dictionary<string, double> triangle)
        {
            Console.WriteLine("============= Triangles list: ===============");
            int i = 1;
            foreach (var keyValue in triangle.OrderByDescending(keyValue => keyValue.Value))
            {
                Console.WriteLine(i + ". [" + keyValue.Key + "]:" + keyValue.Value + " cm");
                i++;
            }
        }

    }
}
