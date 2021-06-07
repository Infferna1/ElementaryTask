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
        //private double S;
        private string Name;

        public SortingTriangles()
        {
        }
        public SortingTriangles(string name, double aSide, double bSide, double cSide)
        {
            Name = name;
            ASide = aSide;
            BSide = bSide;
            CSide = cSide;
        }

        public void TriangleExist()
        {
            if (!(ASide + BSide > CSide && ASide + CSide > BSide && BSide + CSide > ASide))
            {
                throw new Exception("Triangle with this parameters can't exist");
            }
        }

        public double TriangleArea()
        {
            double p = (ASide + BSide + CSide) / 2;
            //S = Math.Sqrt(p * (p - ASide) * (p - BSide) * (p - CSide));
            //S = Math.Round(S, 2);
            return Math.Sqrt(p * (p - ASide) * (p - BSide) * (p - CSide));
        }
        public override string ToString()
        {
            return $"[{Name}]: {Math.Round(TriangleArea(), 2)} cm^2";
        }
    }
}
