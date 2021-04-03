using System;
using Xunit;
using SimpleAPI.Controllers; // add namespace here

namespace SimpleAPI.Test
{
    public class UnitTest
    {
        WeatherForecastController controller = new WeatherForecastController(); // create an object of the WeatherForecastController

        [Fact]
        public void GetReturnWeatherData()
        {
            var returnValue = controller.Get(1);
            Assert.Equal("abhc", returnValue.Value); // grab the value
        }


        //[Fact]
        //public void Test()
        //{

        //}
    }
}
