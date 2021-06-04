using System;
using System.Collections.Generic;
using System.Text;

namespace AnalysisOfEnvelopes
{
    class Controller
    {
        private View view;

        public void Start()
        {
            view = new View();
            view.NewAnalysisOfEnvelopes();//Работа с методом
        }
    }
}
