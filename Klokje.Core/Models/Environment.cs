using System;
using System.Collections.Generic;
using System.Text;

namespace HetKlokje.Core.Models
{
    public class Environment
    {
        public int DefaultTariff { get; set; }

        public Environment(int defaultTariff)
        {
            DefaultTariff = defaultTariff;
        }
    }
}
