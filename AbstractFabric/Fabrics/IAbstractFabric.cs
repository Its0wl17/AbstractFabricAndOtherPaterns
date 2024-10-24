using System;
namespace AbstractFabric
{
    interface IAbstractFabric
    {
        ISofa CreateSofa();
        ITable CreateTable();
        IAbstractFabric Clone();
    }
}