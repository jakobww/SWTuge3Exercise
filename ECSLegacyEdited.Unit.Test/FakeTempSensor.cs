using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECSLegacyEdited
{
    public class FakeTempSensor : ITempSensor
    {

        public int GetTemp()
        {
            return 34;
        }

        public bool RunSelfTest()
        {
            return true;
        }

    }
}
