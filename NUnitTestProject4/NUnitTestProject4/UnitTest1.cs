using NUnit.Framework;

namespace NUnitTestProject4
{
    public class Tests
    {

        [Test]
        public void Test1()
        {


            for (int x = 0; x <= 20; x++)
            {
                for (int y = 0; y <= 20; y++)
                {

                    Calculator.Methods s = new Calculator.Methods();
                    s.addition(x, y);
                    var result = s.addition(x, y);
                    Assert.IsTrue(x + y == result, "При x= {0}, y= {1}, получили result = {2}", x, y, result);

                    s.difference(x, y);
                    var result1 = s.difference(x, y);
                    Assert.IsTrue(x - y == result1, "При x = {0}, y = {1}, получили result = {2}", x, y, result1);

                    s.division(x, y);
                    var result2 = s.division(x, y);
                    
                    if (y == 0)
                    { Assert.Pass(); }
                    else
                    {
                        Assert.IsTrue(x / y == result2, "При x = {0}, y = {1}, получили result = {2}", x, y, result2);
                    }

                    s.multiplication(x, y);
                    var result3 = s.multiplication(x, y);
                    Assert.IsTrue(x * y == result3, "При x = {0}, y = {1}, получили result = {2}", x, y, result3);

                }
            }
        }
    }
}