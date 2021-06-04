using System;
using System.Collections.Generic;
using System.Text;

namespace NumberToText
{
    class Controller
    {
        private View view;
        private NumberToText nTT;
        public void Start()
        {
            view = new View();
            nTT = new NumberToText();
            nTT.ConvertNumberToString(view.InputNumber());
        }
    }
}
