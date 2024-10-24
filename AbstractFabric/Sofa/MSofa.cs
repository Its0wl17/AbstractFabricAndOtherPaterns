using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFabric
{
    public class MSofa : ISofa
    {
        public string SofaStyle()
        {
            return $"Диван в стиле Modern";
        }
    }
}
