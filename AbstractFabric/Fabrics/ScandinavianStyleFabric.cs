using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFabric
{
    class ScandinavianStyleFabric : IAbstractFabric, CreateSofa, CreateTable
    {
        private static ScandinavianStyleFabric _instance;

        private ScandinavianStyleFabric() { }

        public static ScandinavianStyleFabric Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new ScandinavianStyleFabric();
                }
                return _instance;
            }
        }

        public IAbstractFabric Clone()
        {
            return new ScandinavianStyleFabric();
        }

        public ISofa CreateSofa()
        {
            return new SSofa();
        }

        public ITable CreateTable()
        {
            return new STable();
        }
    }
}
