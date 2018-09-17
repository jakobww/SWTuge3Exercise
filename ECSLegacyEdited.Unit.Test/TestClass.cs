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
        public void TurnOnHeater_TurnOnWhen15Degrees_calledTurnOnEquals1()
        {

            //Arrange
            int threshold = 20;
            FakeHeater myHeater = new FakeHeater();
            FakeTempSensor myTempSensor = new FakeTempSensor();
            myTempSensor._temp = 15;
            ECS.LegacyEdited.ECS myEcs = new ECS.LegacyEdited.ECS(threshold,myHeater,myTempSensor);

            //Act
            myEcs.Regulate();

            //Assert
            Assert.That(myHeater._calledTurnOn.Equals(1));
            
        }


        [Test]
        public void TurnOffHeater_TurnOffWhen25Degrees_calledTurnOffEquals1()
        {

            //Arrange
            int threshold = 20;
            FakeHeater myHeater = new FakeHeater();
            FakeTempSensor myTempSensor = new FakeTempSensor();
            myTempSensor._temp = 25;
            ECS.LegacyEdited.ECS myEcs = new ECS.LegacyEdited.ECS(threshold, myHeater, myTempSensor);

            //Act
            myEcs.Regulate();

            //Assert
            Assert.That(myHeater._calledTurnOff.Equals(1));

        }


    }
}