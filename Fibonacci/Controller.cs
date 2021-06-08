using System;
using System.Collections.Generic;
using System.Text;

namespace Fibonacci
{
    class Controller
    {
        private View view;
        private Fibonacci fibonacci;
        public void Start()
        {
            view = new View();
            switch (view.ChoosePath())
            {
                case 1:
                    fibonacci = new Fibonacci(view.FibonacciLength());
                    fibonacci.ByLength();
                    break;
                case 2:
                    fibonacci = new Fibonacci(view.FibonacciRange());
                    fibonacci.ByRange();
                    break;
            }
        }
    }
}
