using System;
using System.Collections.Generic;
using System.Text;

namespace Task19
{
    class CarnivoreOnEatArgs : EventArgs
    {
        public string Message { get; set; }
        public CarnivoreOnEatArgs(string m)
        {
            Message = m;
        }
    }
}
