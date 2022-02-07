using System;
using ClassesLibrary;
using Xunit;

namespace Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            var obj = new Class1(17);
            


            //Act
            var expectedvalue = obj.ReturnCondition();


            //Assert
            Assert.True(expectedvalue);
        }
    }
}
