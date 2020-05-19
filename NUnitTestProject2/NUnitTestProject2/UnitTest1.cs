using NLog;
using NUnit.Framework;
using System;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace NUnitTestProject2
{
    public class Tests
    {
        [Test]
        public void addition()

        {          
            for (int x = 0; x <= 20; x++)
            for (int y = 0; y <= 20; y++)
                {
                Calculator.Methods s = new Calculator.Methods();
                double result = s.addition(x, y);
                Assert.IsTrue(x + y == result, "При x = {0} и y = {1} получили result = {2}", x, y, result);
                continue;
                }
        }
        [Test]
        public void difference()
        {
                for (int x = 0; x <= 20; x++)
                for (int y = 0; y <= 20; y++)
                {
                Calculator.Methods s = new Calculator.Methods();
                double result = s.addition(x, y);
                Assert.IsTrue(x - y == result, "При x = {0} и y = {1} получили result = {2}", x, y, result);
                continue;
                }
        }
        [Test]
        public void division()
        {
                for (int x = 0; x <= 20; x++)
                for (int y = 0; y <= 20; y++)
                {
                Calculator.Methods s = new Calculator.Methods();
                double result = s.addition(x, y);
                Assert.IsTrue(x / y == s.division(x, y), "При x = {0} и y = {1} получили result = {2}", x, y, result);
                continue;
                }
        }
        [Test]
        public void multiplication()
        {
                for (int x = 0; x <= 20; x++)
                for (int y = 0; y <= 20; y++)
                {
                Calculator.Methods s = new Calculator.Methods();
                double result = s.addition(x, y);
                Assert.IsTrue(x * y == s.multiplication(x, y), "При x = {0} и y = {1} получили result = {2}", x, y, result);
                }

        }
    }
}