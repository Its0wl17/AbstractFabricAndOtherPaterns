using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFabric
{
    public class Client
    {
        public static void Main()
        {
            ModernStyleFabric modern = ModernStyleFabric.Instance;
            ScandinavianStyleFabric scandinavian = ScandinavianStyleFabric.Instance;
            ISofa msofa = modern.CreateSofa();
            ITable mtable = modern.CreateTable();

            Console.WriteLine($"{msofa.SofaStyle()}\n{mtable.TableStyle()}");

            ISofa ssofa = scandinavian.CreateSofa();
            ITable stable = scandinavian.CreateTable();

            Console.WriteLine($"\n\n{ssofa.SofaStyle()}\n{stable.TableStyle()}");

            ModernStyleFabric cloneM = (ModernStyleFabric)modern.Clone();
            ScandinavianStyleFabric cloneS = (ScandinavianStyleFabric)scandinavian.Clone();

            ISofa testM = cloneM.CreateSofa();
            ITable testS = cloneS.CreateTable();

            Console.WriteLine($"\n\n{testM.SofaStyle()}\n{testS.TableStyle()}");
            Console.ReadLine();
        }
    }
}
