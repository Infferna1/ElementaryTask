using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortingTriangles
{
    class View
    {
        //public double GetASide()
        //{
        //    Console.WriteLine("Enter A side of triangle:");//Валидация
        //    double aSide = double.Parse(Console.ReadLine());
        //    while ((aSide <= 0) || (aSide >= 51))
        //    {
        //        Console.WriteLine("Side A must be bigger than 0 and lower than 51\nEnter A side:");
        //        aSide = double.Parse(Console.ReadLine());
        //    }
        //    return aSide;
        //}
        //public double GetBSide()
        //{
        //    Console.WriteLine("Enter B side of triangle:");//Валидация
        //    double bSide = double.Parse(Console.ReadLine());
        //    while ((bSide <= 0) || (bSide >= 51))
        //    {
        //        Console.WriteLine("Side B must be bigger than 0 and lower than 51\nEnter B side:");
        //        bSide = double.Parse(Console.ReadLine());
        //    }
        //    return bSide;
        //}
        //public double GetCSide()
        //{
        //    Console.WriteLine("Side C side of triangle:");//Валидация
        //    double cSide = double.Parse(Console.ReadLine());
        //    while ((cSide <= 0) || (cSide >= 51))
        //    {
        //        Console.WriteLine("Side C must be bigger than 0 and lower than 51\nEnter Enter C side:");
        //        cSide = double.Parse(Console.ReadLine());
        //    }
        //    return cSide;
        //}


        //public string GetNameTriangle()
        //{
        //    Console.WriteLine("Enter name of triangle:");//Валидация
        //    string nameOfTriangle = Console.ReadLine();
        //    return nameOfTriangle;
        //}
        //public void 
        public List<SortingTriangles> NewTriangle()
        {
            string answer;
            string name;
            double aSide, bSide, cSide;
            string inputString;
            string[] triangleParameters;
            bool check;
            SortingTriangles triangle = new SortingTriangles();
            List<SortingTriangles> listOfTriangles = new List<SortingTriangles>();
            do
            {
                check = true;
                while (check)
                {
                    Console.WriteLine("Enter <name of triangle>, <length of side>, <length of side>, <length of side>");
                    inputString = Console.ReadLine();
                    triangleParameters = inputString.Split(',');
                    name = triangleParameters[0].Trim();
                    try
                    {
                        aSide = double.Parse(triangleParameters[1]);
                        bSide = double.Parse(triangleParameters[2]);
                        cSide = double.Parse(triangleParameters[3]);
                        triangle = new SortingTriangles(name, aSide, bSide, cSide);
                        triangle.TriangleExist();
                        check = false;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                listOfTriangles.Add(triangle);
                Console.WriteLine("Do you want to continue?(y/n)");
                answer = Console.ReadLine().ToLower();
            } while (answer == "y" || answer == "yes");
            return listOfTriangles;
        }
        public void TrianglesPrint(List<SortingTriangles> listOfTriangles)
        {
            Console.WriteLine("============= Triangles list: ===============");

            SortTriangles(listOfTriangles);
            for (int i = 0; i < listOfTriangles.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {listOfTriangles[i]}");
            }
        }
        public void SortTriangles(List<SortingTriangles> listOfTriangles)
        {
            for (int i = 0; i < listOfTriangles.Count; i++)
            {
                for (int j = i + 1; j < listOfTriangles.Count; j++)
                {
                    if (listOfTriangles[i].TriangleArea() < listOfTriangles[j].TriangleArea())
                    {
                        SortingTriangles temp = listOfTriangles[i];
                        listOfTriangles[i] = listOfTriangles[j];
                        listOfTriangles[j] = temp;
                    }
                }
            }
        }
        public void TrianglesStart()
        {
            List<SortingTriangles> triangle = NewTriangle();
            TrianglesPrint(triangle);
        }
    }
}
