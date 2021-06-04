using System;
using System.Collections.Generic;
using System.Text;

namespace AnalysisOfEnvelopes
{
    class AnalysisOfEnvelopes
    {
        private double ASide;
        private double BSide;
        private double CSide;
        private double DSide;

        public AnalysisOfEnvelopes(double aSide, double bSide, double cSide, double dSide)
        {
            ASide = aSide;
            BSide = bSide;
            CSide = cSide;
            DSide = dSide;
        }

        public void CompareSides()
        {
            double per;
            if (ASide > BSide)
            {
                per = ASide;
                ASide = BSide;
                BSide = per;
            }

            if (CSide > DSide)
            {
                per = CSide;
                CSide = DSide;
                DSide = per;
            }
            if (((ASide > CSide) && (BSide > DSide)) || ((ASide < CSide) && (BSide < DSide)))//2 Envelopes not 4 side
            {
                Console.WriteLine("One of the envelopes can be inserted into the other");//
            }
            else
            {
                Console.WriteLine("None of the envelopes can be inserted into the other");
            }
        }
    }
}
