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
            numberSequence = new NumberSequence(view.GetLength(), view.GetSquare());
            numberSequence.Sequence();
            view.PrintSequence(numberSequence);
        }
    }
}
