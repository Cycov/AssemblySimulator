using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileFormatter
{
    [Serializable]
    public enum ModelType
    {
        Tiny,
        small
    }

    [Serializable]
    public enum AdressingTypes
    {
        AM = 0b00,
        AD = 0b01,
        AI = 0b10,
        AX = 0b11
    }

    [Serializable]
    public struct Instruction
    {
        public byte Class;
        public ushort Opcode;
    }

    [Serializable]
    public struct Label
    {
        public string Name;
        public int Adress;
    }
}
