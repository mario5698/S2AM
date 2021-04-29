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
        //funcion prova si les dades introduides retornen un numero en concret
        [TestCase(1, 1, ExpectedResult = 5)]
        [TestCase(9, 25, ExpectedResult = 225)]
        [TestCase(7, 14, ExpectedResult = 14)]
        public int getMCMValidNumber(int numero1, int numero2)
        {
            //Arrage
            Calculus clc = new Calculus();
            //Act
            var numeroMCM = clc.getMCM(numero1, numero2);
            //Expected Result
            return numeroMCM;
        }
        
        //Funcion prova si la funcion de getMCD es correcta cridant comparant el valor retornat
        //y el comprara amb la funcio creada dins del programa
      
        [TestCase(0, 1)]
        [TestCase(9, 0)]
        [TestCase(0, 0)]
        public void getMCMZeroNumber(int numero1, int numero2)
        {
            //Arrage
            Calculus clc = new Calculus();
            //Act
            // var numeroMCM = clc.getMCM(numero1, numero2);
            //Expected Result
            Assert.Throws<DivideByZeroException>(() => clc.getMCM(numero1, numero2));
        }


      
        //La funcio de getCalculs retorna una lista sense dades degut a que en la multiplicacio dona un resultat mayor a 300
        [TestCase(9, 39)]
        [TestCase(9, 35)]
        [TestCase(8, 38)]
        public void getListEmpycontent(int numero1, int numero2)
        {
            //Arrage
            Calculus clc = new Calculus();
            List<int> lista = new List<int>();
            //Act
            lista = clc.setCalculs(numero1, numero2);
            //Assert
            Assert.IsEmpty(lista);
        }

        //La funcion de setCalculs retorna una llista amb dades degut a que cap numero multiplicat per el altre supera el numero 300 
        [TestCase(8, 24)]
        [TestCase(5, 32)]
        [TestCase(4, 12)]
        public void getListWithData(int numero1, int numero2)
        {
            //Arrage
            Calculus clc = new Calculus();
            List<int> lista = new List<int>();
            //Act
            lista = clc.setCalculs(numero1, numero2);
            //Assert
            //Assert.That(lista, Is.Not.Empty);
            Assert.IsNotEmpty(lista);
        }

        [TestCase(8, 24)]
        public void getListWithArrayData(int numero1, int numero2)
        {
            //Arrage
            Calculus clc = new Calculus();
            List<int> lista = new List<int>();
            //Act
            lista = clc.setCalculs(numero1, numero2);
            //Assert
            Assert.IsNotEmpty(lista);
            Assert.That(lista.Count(), Is.EqualTo(6));
            Assert.That(lista, Is.EquivalentTo( new[] { 32, -16, 16, 192, 0, 3}));
        }
    }
}
