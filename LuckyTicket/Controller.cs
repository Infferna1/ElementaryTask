using System;
using System.Collections.Generic;
using System.Text;

namespace LuckyTicket
{
    class Controller
    {
        private View view;
        private LuckyTicket luckyTicket;

        public void Start()
        {
            view = new View();
            luckyTicket = new LuckyTicket(view.GetMinTicket(), view.GetMaxTicket());
            view.PrintResult(luckyTicket.QuantitySimpleMethod(), luckyTicket.QuantityHardMethod());
        }
    }
}
