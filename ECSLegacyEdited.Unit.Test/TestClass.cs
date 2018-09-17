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

        [Test]
        public void ECS_GetCurTemp_ReturnTemp()
        {
            FakeHeater myHeater = new FakeHeater();
            FakeTempSensor myTempSensor = new FakeTempSensor();

            ECS.LegacyEdited.ECS uut = new ECS.LegacyEdited.ECS(25, myHeater, myTempSensor);

            myTempSensor._temp = 23;

            Assert.That(uut.GetCurTemp().Equals(23));

        }


    }
}
