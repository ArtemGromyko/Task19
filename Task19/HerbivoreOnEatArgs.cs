using System;
using System.Collections.Generic;
using System.Text;

namespace Task19
{
    class HerbivoreOnEatArgs : EventArgs
    {
        public string Message { get; set; }
        public HerbivoreOnEatArgs(string m)
        {
            Message = m;
        }
    }
}
