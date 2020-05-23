using NLog;
using NUnit.Framework;
using NUnit.Framework.Internal.Builders;
using System;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;



namespace NUnitTestProject2
{
    public class Tests
    {

        [SetUp]
        public static object[] SetUp()
        {

            object[] name =
        {
            new object[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 }
        };
            for (int x = 0; x <= 20; x++) ; 
            for (int y = 0; y <= 20; y++) ;
            return name;
        }

        [Test, TestCaseSource(typeof(Val), "name")]
        public void addition(int x, int y)
        {          
            Calculator.Methods s = new Calculator.Methods();
            double result = s.addition(x, y);
            Assert.IsTrue(x + y == result, "При x = {0} и y = {1} получили result = {2}", x, y, result);
        }

        [Test, TestCaseSource(typeof(Val), "name")]
        public void difference(int x, int y)
        {
                    Calculator.Methods s = new Calculator.Methods();
                    double result = s.difference(x, y);
                    Assert.IsTrue(x - y == result, "При x = {0} и y = {1} получили result = {2}", x, y, result);
        }

        [Test, TestCaseSource(typeof(Val), "name")]
        public void division(int x, int y)
        {
                    Calculator.Methods s = new Calculator.Methods();
                    double result = s.division(x, y);
                    Assert.IsTrue(x / y == result, "При x = {0} и y = {1} получили result = {2}", x, y, result);
        }

        [Test, TestCaseSource(typeof(Val), "name")]
        public void multiplication(int x, int y)
        {
                    Calculator.Methods s = new Calculator.Methods();
                    double result = s.multiplication(x, y);
                    Assert.IsTrue(x * y == result, "При x = {0} и y = {1} получили result = {2}", x, y, result);
        }
    }
}