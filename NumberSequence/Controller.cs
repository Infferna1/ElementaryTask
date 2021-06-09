using System;
using System.Collections.Generic;
using System.Text;

namespace NumberSequence
{
    class Controller
    {
        private View view;
        private NumberSequence numberSequence;
        private string[] Args; 
        public Controller(string[] args)
        {
            Args = args;
        }

        public void Start()
        {
            view = new View();
            view.ViewArguments(Args);
            numberSequence = new NumberSequence(view.GetParameters());
            numberSequence.Sequence();
            view.PrintSequence(numberSequence);
        }
    }
}
