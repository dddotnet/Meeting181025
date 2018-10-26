using System;
using UserDemo;
using UserDemo.Services;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void ValuesControllerReturnStringArray()
        {
            //Arrange           
            var service = new ValuesService(new neueimplemntierungOfUltra(), new neuerimplemntierungOfUltra());
            //Act
            var values = service.GetValues();
            //Assert
            Assert.IsType<string[]>(values);
            Assert.Equal(5, values.Length);
            Assert.Equal("test2", values[3]);
            Assert.Equal("test3", values[4]);
        }

        class neueimplemntierungOfUltra : IUltraAwesomeClass
        {
            public string MyProperty1 { get => "test"; set => throw new NotImplementedException(); }
            public string MyProperty2 { get => "test2"; set => throw new NotImplementedException(); }
        }

        class neuerimplemntierungOfUltra : IUltraAwesomeClass
        {
            public string MyProperty1 { get => "test"; set => throw new NotImplementedException(); }
            public string MyProperty2 { get => "test3"; set => throw new NotImplementedException(); }
        }
    }
}
