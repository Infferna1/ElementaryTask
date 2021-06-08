using System;
using System.Collections.Generic;
using System.Text;

namespace SortingTriangles
{

    class Controller
    {
        private View view;
        private string[] Args;
        public Controller(string[] args)
        {
            Args = args;
        }
        public void Start()
        {
            view = new View();
            view.ViewArguments(Args);
            view.TrianglesStart();
        }
    }
}
