using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using MathCalculus;

namespace MathCalculus.UnitTest
{
    [TestFixture]
    public class Class1
    {

        [TestCase(1, 1, ExpectedResult = 1)]
        [TestCase(9, 25, ExpectedResult = 225)]
        [TestCase(7, 14, ExpectedResult = 14)]
        public int getMCMValidNumber(int numero1, int numero2)
        {
            Calculus clc = new Calculus();

            var numeroMCM = clc.getMCM(numero1, numero2);

            return numeroMCM;
        }


        [TestCase(8, 14, ExpectedResult = 2)]
        [TestCase(9, 25, ExpectedResult =1 )]
        [TestCase(7, 14, ExpectedResult = 7)]
        public int getMCMInvalidNumber(int numero1, int numero2)
        {
            Calculus clc = new Calculus();

            var numeroMCM = clc.getMCD(numero1, numero2);

            return numeroMCM;
        }




        [TestCase(9, 40)]
        [TestCase(9, 35)]
        public void getListEmpycontent(int numero1, int numero2)
        {
            Calculus clc = new Calculus();
            List<int> lista = new List<int>();

            lista = clc.setCalculs(numero1, numero2);

            Assert.That(lista, Is.Empty);
        }

        [TestCase(8, 24)]
        [TestCase(5, 32)]
        [TestCase(4, 12)]
        public void getListWithData(int numero1, int numero2)
        {
            Calculus clc = new Calculus();
            List<int> lista = new List<int>();

            lista = clc.setCalculs(numero1, numero2);
            
            Assert.That(lista, Is.Not.Empty);
        }

    }
}
