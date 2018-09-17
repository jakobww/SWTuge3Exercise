using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECSLegacyEdited
{
    public class FakeTempSensor : ITempSensor
    {
        public int _temp { set; get; }

        public int GetTemp()
        {
            return _temp;
        }

        public bool RunSelfTest()
        {
            return true;
        }

    }
}
