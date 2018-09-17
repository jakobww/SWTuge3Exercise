using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECSLegacyEdited
{
    public class FakeHeater : IHeater
    {
        public int _calledTurnOn { set; get; }
        public int _calledTurnOff { set; get; }

        public void TurnOn()
        {
            _calledTurnOn++;
        }

        public void TurnOff()
        {
            _calledTurnOff++;
        }

        public bool RunSelfTest()
        {
            return true;
        }
    }
}
