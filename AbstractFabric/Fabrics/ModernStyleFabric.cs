using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFabric
{
    class ModernStyleFabric : IAbstractFabric
    {
        private static ModernStyleFabric _instance;

        private ModernStyleFabric() { }

        public static ModernStyleFabric Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new ModernStyleFabric();
                }
                return _instance;
            }
        }

        public IAbstractFabric Clone()
        {
            return new ModernStyleFabric();
        }

        public ISofa CreateSofa()
        {
            return new MSofa();
        }

        public ITable CreateTable()
        {
            return new MTable();
        }
    }
}
