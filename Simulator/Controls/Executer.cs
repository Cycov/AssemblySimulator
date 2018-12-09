using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulator.Controls
{
    public enum Instructions
    {
        AAA = 0x37,
        AAD = 0xD5,
        AAM = 0xD4,
        AAS = 0x3F,
        ADC = 0x10,
        ADD = 0x00,
        AND = 0x20,
        CALL = 0x9A,
        CBW = 0x98,
        CLC = 0xF8,
        CLD = 0xFC,
        CLI = 0xFA,
        CMC = 0xF5,
        CMP = 0x38,
        CMPSB = 0xA6,
        CMPSW = 0xA7,
        CWD = 0x99,
        DAA = 0x27,
        DAS = 0x2F,
        DEC = 0x48,
    }

    class Executer
    {

    }
}
