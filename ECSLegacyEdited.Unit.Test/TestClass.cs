using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ECSLegacyEdited;

namespace ECSLegacyEdited.Unit.Test
{
    [TestFixture]
    public class TestClass
    {

        [Test]
        public void TurnOnHeater_TurnOnWhen25Degrees_WriteHeaterON()
        {


            
            IHeater myHeater = new FakeHeater();
            ITempSensor myTempSensor = new FakeTempSensor();
            ECS.LegacyEdited.ECS myEcs = new ECS.LegacyEdited.ECS();


        }

    }
}
