using System;
using System.Collections.Generic;
using System.Text;

namespace NumberSequence
{
    class Controller
    {
        private View view;
        private NumberSequence numberSequence;

        public void Start()
        {
            view = new View();
            numberSequence = new NumberSequence(view.GetParameters());
            numberSequence.Sequence();
            view.PrintSequence(numberSequence);
        }
    }
}
