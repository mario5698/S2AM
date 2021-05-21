
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace OperacionsM5
{
    [TestFixture]

    class UnitTesting
    { OperacionsBasiques opb =new OperacionsBasiques();

        // prestigi > 100  => Impacte = A    
        // prestigi entre 50 i  100  
        //            lectors > 1000 => Impacte = A
        //            lectors entre 500 i 1000 => Impacte = B
        //            lectors < 500 => Impacte = C
        // prestigi entre 1 i  49  
        //            lectors > 1000 => Impacte = B
        //            lectors  =<1000  Impacte = C

        [TestCase(101, 20, ExpectedResult = "C")]
        [TestCase(100, 1001, ExpectedResult = "A")]
        [TestCase(300, 20, ExpectedResult = "C")]
        [TestCase(1000, 3, ExpectedResult = "C")]
        [TestCase(50, 3, ExpectedResult = "C")]
        [TestCase(73, 1002, ExpectedResult = "A")]
        [TestCase(73, 400, ExpectedResult = "A")]
        [TestCase(6, 4, ExpectedResult = "C")]
        public string probaPrestiguisLectors(int prestigi, int lector)
        {
           return opb.CalculaImpacte(prestigi, lector);
        }
    }
}
