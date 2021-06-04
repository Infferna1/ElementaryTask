using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortingTriangles
{
    class SortingTriangles
    {
        private double ASide;
        private double BSide;
        private double CSide;
        private double S;

        public SortingTriangles(double aSide, double bSide, double cSide)
        {
            ASide = aSide;
            BSide = bSide;
            CSide = cSide;
        }

        public double TrianglesAnalysis()
        {
            double p = (ASide + BSide + CSide) / 2;
            S = Math.Sqrt(p * ((p - ASide) * (p - BSide) * (p - CSide)));
            S = Math.Round(S, 2);
            return S;
        }
    }
}
