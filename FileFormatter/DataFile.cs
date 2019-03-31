using System;

namespace FileFormatter
{
    [Serializable]
    public class DataFile
    {
        public Header Header;
        public byte[] Data;
        public byte[] Code;
        
        public DataFile(Header header, byte[] data, byte[] code)
        {
            Header = header;
            Data = data;
            Code = code;
        }

        public DataFile(int memorySize)
        {
            Data = new byte[memorySize / 4];
            Code = new byte[memorySize / 4];
        }

        public void SetDataByte(int adress, byte value)
        {
            if (Data == null || adress > Data.Length)
                throw new IndexOutOfRangeException("Adress out of range memory: " + adress.ToString());
            Data[adress] = value;
        }
        public void SetDataWord(int adress, ushort value)
        {
            if (Data == null || adress > Data.Length)
                throw new IndexOutOfRangeException("Adress out of range memory: " + adress.ToString());
            Data[adress] = (byte)value;
            Data[adress + 1] = (byte)(value >> 8);
        }
        public void SetDataDWord(int adress, UInt32 value)
        {
            if (Data == null || adress > Data.Length)
                throw new IndexOutOfRangeException("Adress out of range memory: " + adress.ToString());
            Data[adress] = (byte)value;
            Data[adress + 1] = (byte)(value >> 8);
            Data[adress + 2] = (byte)(value >> 16);
            Data[adress + 3] = (byte)(value >> 24);
        }
        public void SetDataQWord(int adress, UInt64 value)
        {
            if (Data == null || adress > Data.Length)
                throw new IndexOutOfRangeException("Adress out of range memory: " + adress.ToString());
            Data[adress] = (byte)value;
            Data[adress + 1] = (byte)(value >> 8);
            Data[adress + 2] = (byte)(value >> 16);
            Data[adress + 3] = (byte)(value >> 24);
            Data[adress + 4] = (byte)(value >> 32);
            Data[adress + 5] = (byte)(value >> 40);
            Data[adress + 6] = (byte)(value >> 48);
            Data[adress + 7] = (byte)(value >> 56);
        }

        public void SetCodeWord(int adress, ushort value)
        {
            if (Code == null || adress > Code.Length)
                throw new IndexOutOfRangeException("Adress out of range memory: " + adress.ToString());
            Code[adress] = (byte)value;
            Code[adress + 1] = (byte)(value >> 8);
        }
    }
}
