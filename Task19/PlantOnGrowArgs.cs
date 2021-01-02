using System;
using System.Collections.Generic;
using System.Text;

namespace Task19
{
    class PlantOnGrowArgs : EventArgs
    {
        public string Message { get; set; }
        public PlantOnGrowArgs(string m)
        {
            Message = m;
        }
    }
}
