using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestReemplazaCadena;
using ReemplazaCadena;

namespace UnitTestReemplazaCadena
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //First  
            string cadenaPrueba = "**Casa 52Z";
            ChangeString objetoPrueba = new ChangeString();
            Console.WriteLine(objetoPrueba.build(cadenaPrueba));
        }


        [TestMethod]
        public void TestMethod2()
        {
            //First  
            string cadenaPrueba = "123 abcd*3";
            ChangeString objetoPrueba = new ChangeString();
            Console.WriteLine(objetoPrueba.build(cadenaPrueba));
        }


        [TestMethod]
        public void TestMethod3()
        {
            //First  
            string cadenaPrueba = "Daniel 2019 Gutierrez";
            ChangeString objetoPrueba = new ChangeString();
            Console.WriteLine(objetoPrueba.build(cadenaPrueba));
        }
    }
}
