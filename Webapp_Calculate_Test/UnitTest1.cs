using System;
using Webapp_Calculate_Main.Controllers;
using Xunit;

namespace Webapp_Calculate_Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //const int num1 = 1;
            //const int num2 = 4;
            var method = new HomeController.sumModel();
            int result = method.sumOfAll(1, 4);
            Assert.True(result == 5, "Test case is passed");
        }
    }
}
