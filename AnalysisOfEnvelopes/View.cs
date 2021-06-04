using System;
using System.Collections.Generic;
using System.Text;

namespace AnalysisOfEnvelopes
{
    class View
    {
        public double InputFirstSide()
        {
            Console.WriteLine("Enter A side:");
            double aSide = double.Parse(Console.ReadLine());
            while ((aSide <= 0) || (aSide >= 51))
            {
                Console.WriteLine("Side A must be bigger than 0 and lower than 51\nEnter A side:");//Почему 51
                aSide = double.Parse(Console.ReadLine());
            }
            return aSide;
        }
        public double InputSecondSide()
        {
            Console.WriteLine("Enter B side:");
            double bSide = double.Parse(Console.ReadLine());
            while ((bSide <= 0) || (bSide >= 51))
            {
                Console.WriteLine("Side B must be bigger than 0 and lower than 51\nEnter B side:");//Почему 51
                bSide = double.Parse(Console.ReadLine());
            }
            return bSide;
        }
        public double InputThirdSide()
        {
            Console.WriteLine("Enter C side:");
            double cSide = double.Parse(Console.ReadLine());
            while ((cSide <= 0) || (cSide >= 51))
            {
                Console.WriteLine("Side C must be bigger than 0 and lower than 51\nEnter C side:");//Почему 51
                cSide = double.Parse(Console.ReadLine());
            }
            return cSide;
        }
        public double InputFourthSide()
        {
            Console.WriteLine("Enter D side:");
            double dSide = double.Parse(Console.ReadLine());
            while ((dSide <= 0) || (dSide >= 51))
            {
                Console.WriteLine("Side D must be bigger than 0 and lower than 51\nEnter D side:");//Почему 51
                dSide = double.Parse(Console.ReadLine());
            }
            return dSide;
        }

        public void NewAnalysisOfEnvelopes()
        {
            string answer;//Валидация ответа
            do {
                AnalysisOfEnvelopes analysisOfEnvelopes = new AnalysisOfEnvelopes(InputFirstSide(), InputSecondSide(), InputThirdSide(), InputFourthSide());
                analysisOfEnvelopes.CompareSides();
                Console.WriteLine("Do you want to continue?(y/n)");
                answer = Console.ReadLine();
            } while (answer == "y");
        }
    }
}
