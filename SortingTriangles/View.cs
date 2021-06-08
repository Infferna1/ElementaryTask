using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortingTriangles
{
    class View
    {
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
                    Console.WriteLine("Enter <name of triangle> <length of side> <length of side> <length of side>");
                    inputString = Console.ReadLine();
                    triangleParameters = inputString.Split(' ');
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
                        DisplayTask();
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
        public void ViewArguments(string[] args)
        {
            foreach (var arg in args)
            {
                switch (arg)
                {
                    case "-help":
                        DisplayHelp();
                        break;
                    case "-task":
                        DisplayTask();
                        break;
                    default:
                        Console.WriteLine("The specified argument does not exist. To see a list of arguments, enter -help.");
                        break;
                }
            }
        }
        public void DisplayHelp()
        {
            Console.WriteLine("========================================================");
            Console.WriteLine("Possible arguments:\n -help - Information about possible arguments\n -task - Information about task");

        }
        public void DisplayTask()
        {
            Console.WriteLine("========================================================");
            Console.WriteLine("User can enter 4 parameters: \n<string with cymbols more than 0>, \n<double positive number>, \n<double positive number>, \n<double positive number>");
            Console.WriteLine("========================================================");
            Console.WriteLine("User can enter data in the form: <name of triangle> <length of side> <length of side> <length of side>");

        }
        public void TrianglesStart()
        {
            List<SortingTriangles> triangle = NewTriangle();
            TrianglesPrint(triangle);
        }
    }
}
