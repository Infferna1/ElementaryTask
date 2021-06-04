using System;
using System.Collections.Generic;
using System.Text;

namespace SortingTriangles
{

    class Controller
    {
        private View view;
        public void Start()
        {
            view = new View();
            Dictionary<string, double> triangle = view.NewTriangle();
            view.TrianglesPrint(triangle);
        }
    }
}
