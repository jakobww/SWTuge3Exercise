using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ECSLegacyEdited.Unit.Test
{
    [TestFixture]
    class TestClass
    {

        [Test]
        TurnOnHeater_TurnOnWhen25Degrees_WriteHeaterON()
        {


            
            IHeater myHeater = new FakeHeater();
            ITempSensor myTempSensor = new FakeTempSensor();


            
            


        }

    }
}
