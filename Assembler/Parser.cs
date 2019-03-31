using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileFormatter;

namespace Assembler
{
    class Parser
    {
        struct ParsedCode
        {
            public ushort Code;
            public ushort ExtraCode;
            public int Offset;
        }

        struct Operand
        {
            public AdressingTypes AdressingMode;
            public byte Register;
        }

        public static readonly int DefaultStackSize = 512;
        public static readonly int DefaultInstructionLength = 2; //instruction length in bytes

        public static readonly Dictionary<string, Instruction> Instructions = new Dictionary<string, Instruction>()
        {
            //Clasa 1 - b1) Instructiuni cu 2 operanzi			

            { "mov", new Instruction { Class = 0, Opcode = 0b0_000 } },
            { "add", new Instruction { Class = 0, Opcode = 0b0_001 } },
            { "sub", new Instruction { Class = 0, Opcode = 0b0_010 } },
            { "cmd", new Instruction { Class = 0, Opcode = 0b0_011 } },
            { "and", new Instruction { Class = 0, Opcode = 0b0_100 } },
            { "or", new Instruction { Class = 0, Opcode = 0b0_101 } },
            { "xor", new Instruction { Class = 0, Opcode = 0b0_110 } },

            //Clasa 2 - b2) Instructiuni cu un operand
            
            { "clr", new Instruction { Class = 1, Opcode = 0b101_0000_000 } },
            { "neg", new Instruction { Class = 1, Opcode = 0b101_0001_000 } },
            { "inc", new Instruction { Class = 1, Opcode = 0b101_0010_000 } },
            { "dec", new Instruction { Class = 1, Opcode = 0b101_0011_000 } },
            { "asl", new Instruction { Class = 1, Opcode = 0b101_0100_000 } },
            { "asr", new Instruction { Class = 1, Opcode = 0b101_0101_000 } },
            { "lsr", new Instruction { Class = 1, Opcode = 0b101_0110_000 } },
            { "rol", new Instruction { Class = 1, Opcode = 0b101_0111_000 } },
            { "ror", new Instruction { Class = 1, Opcode = 0b101_1000_000 } },
            { "rlc", new Instruction { Class = 1, Opcode = 0b101_1001_000 } },
            { "rrc", new Instruction { Class = 1, Opcode = 0b101_1010_000 } },
            { "jmp", new Instruction { Class = 1, Opcode = 0b101_1011_000 } },
            { "call", new Instruction { Class = 1, Opcode = 0b101_1100_000 } },
            { "push", new Instruction { Class = 1, Opcode = 0b101_1101_000 } },
            { "pop", new Instruction { Class = 1, Opcode = 0b101_1110_000 } },

            //Clasa 3 - b3) Instructiuni de salt
                        
            { "br", new Instruction { Class = 2, Opcode = 0b110_0000_0 } },
            { "bne", new Instruction { Class = 2, Opcode = 0b110_0001_0 } },
            { "beq", new Instruction { Class = 2, Opcode = 0b110_0010_0 } },
            { "bpl", new Instruction { Class = 2, Opcode = 0b110_0011_0 } },
            { "bmi", new Instruction { Class = 2, Opcode = 0b110_0100_0 } },
            { "bcs", new Instruction { Class = 2, Opcode = 0b110_0101_0 } },
            { "bcc", new Instruction { Class = 2, Opcode = 0b110_0110_0 } },
            { "bvs", new Instruction { Class = 2, Opcode = 0b110_0111_0 } },
            { "bvc", new Instruction { Class = 2, Opcode = 0b110_1000_0 } },

            //Clasa 4 - b4) Instructiuni diverse
            
            { "clc", new Instruction { Class = 3, Opcode = 0b111_00000_00000000 } },
            { "clv", new Instruction { Class = 3, Opcode = 0b111_00001_00000000 } },
            { "clz", new Instruction { Class = 3, Opcode = 0b111_00010_00000000 } },
            { "cls", new Instruction { Class = 3, Opcode = 0b111_00011_00000000 } },
            { "ccc", new Instruction { Class = 3, Opcode = 0b111_00100_00000000 } },
            { "sec", new Instruction { Class = 3, Opcode = 0b111_00101_00000000 } },
            { "sev", new Instruction { Class = 3, Opcode = 0b111_00110_00000000 } },
            { "sez", new Instruction { Class = 3, Opcode = 0b111_00111_00000000 } },
            { "ses", new Instruction { Class = 3, Opcode = 0b111_01000_00000000 } },
            { "scc", new Instruction { Class = 3, Opcode = 0b111_01001_00000000 } },
            { "nop", new Instruction { Class = 3, Opcode = 0b111_01010_00000000 } },
            { "ret", new Instruction { Class = 3, Opcode = 0b111_01011_00000000 } },
            { "reti", new Instruction { Class = 3, Opcode = 0b111_01100_00000000 } },
            { "halt", new Instruction { Class = 3, Opcode = 0b111_01101_00000000 } },
            { "wait", new Instruction { Class = 3, Opcode = 0b111_01110_00000000 } },
            { "pushpc", new Instruction { Class = 3, Opcode = 0b111_01111_00000000 } },
            { "poppc", new Instruction { Class = 3, Opcode = 0b111_10000_00000000 } },
            { "pushf", new Instruction { Class = 3, Opcode = 0b111_10001_00000000 } },
            { "popf", new Instruction { Class = 3, Opcode = 0b111_10010_00000000 } }
        };

        public Dictionary<string, int> Labels, Variables;
        private List<ParsedCode> ParsedCodes;
        private int dataBytesAdded, codeOffset;

        private byte[] data, code;

        public Parser()
        {
            Labels = new Dictionary<string, int>();
            ParsedCodes = new List<ParsedCode>();
        }

        public string FileName { get; protected set; }

        public DataFile Parse(string[] lines)
        {
            int dataStartLine = -1, codeStartLine = -1;
            dataBytesAdded = codeOffset = 0;

            Header newHeader = new Header();

            for (int i = 0; i < lines.Length; i++)
            {
                var line = lines[i].Trim();
                var param = line.Split(' ');
                if (!String.IsNullOrWhiteSpace(line))
                {
                    line = line.ToLower();
                    bool isDirective = (line[0] == '.');
                    if (isDirective)
                    {
                        ParseDirective(i, param, lines, ref newHeader, ref codeStartLine, ref dataStartLine);
                    }
                    else
                    {
                        //Is on data section
                        if (dataStartLine != -1 && codeStartLine == -1)
                        {
                            ParseData(i, line);
                        } 
                        //Is on code section
                        else if (codeStartLine != -1)
                        {
                            if (param[0] == "end")
                            {
                                if (param.Length == 2)
                                {
                                    if (Labels.ContainsKey(param[1]))
                                        newHeader.StartAdressOffset = Labels[param[1]];
                                    else
                                        throw new ParseException(i, $"Could not find label {param[1]}");
                                }
                                else
                                {
                                    throw new ParseException(i, "Invalid number of parameters");
                                }
                            }
                            else if (Instructions.ContainsKey(param[0]))
                            {
                                Instruction instruction = Instructions[param[0]];
                                param = line.Split(new char[] { ' ', ',' }).Trim(); // mov r1, (r4) => {"mov", "r1", "(r4)"}
                                switch (instruction.Class)
                                {
                                    case 0:
                                        {
                                            //Source
                                            Operand source = ParseOperand(i, param[2]);

                                            //Destination
                                            Operand destination = ParseOperand(i, param[1]);
                                            if (destination.AdressingMode == AdressingTypes.AI)
                                                throw new ParseException(i, "Can not use immediate value as destination");
                                            var code = GetClass0MachineInstruction(instruction.Opcode, (byte)source.AdressingMode, source.Register, (byte)destination.AdressingMode, destination.Register);
                                            ParsedCodes.Add(new ParsedCode() { Code = code, Offset = codeOffset });
                                            codeOffset += 2;
                                        }
                                        break;
                                    case 1:
                                        {
                                            //Destination
                                            Operand destination = ParseOperand(i, param[1]);
                                            if (destination.AdressingMode == AdressingTypes.AI)
                                                throw new ParseException(i, "Can not use immediate value as destination");

                                            var code = GetClass1MachineInstruction(instruction.Opcode, (byte)destination.AdressingMode, destination.Register);
                                            ParsedCodes.Add(new ParsedCode() { Code = code, Offset = codeOffset });
                                            codeOffset += 2;
                                        }
                                        break;
                                    case 2:
                                        {
                                            byte offset;
                                            if (param.Length > 2)
                                                throw new ParseException(i, "Unknown number of parameters recieved");
                                            if (Char.IsDigit(param[1][0]))
                                            {
                                                if (param[1][param[1].Length - 1] == 'h')
                                                {
                                                    if (!byte.TryParse(param[1].TrimEnd('h'), System.Globalization.NumberStyles.HexNumber, System.Globalization.CultureInfo.InvariantCulture, out offset))
                                                        throw new ParseException(i, $"Unknon hexadecimal number {param[1]}");
                                                }
                                                else if (!byte.TryParse(param[1], out offset))
                                                    throw new ParseException(i, $"Can not parse number {param[1]}");
                                            }
                                            else
                                            {
                                                if (Labels.ContainsKey(param[1]))
                                                {
                                                    offset = (byte)(Labels[param[1]] - codeOffset);
                                                }
                                            }
                                        }
                                        break;
                                    case 3:
                                        {

                                        }
                                        break;
                                    default:
                                        break;
                                }
                            }
                        }
                        else if (line[line.Length - 1] == ':')
                        {
                            if (codeStartLine == -1)
                                throw new ParseException(i, "Can not declare labels before .code directive");
                        }
                    }
                }
            }

            return new DataFile(newHeader, data, code);
        }

        private Operand ParseOperand(int i, string input)
        {
            Operand operand = new Operand();
            if (input[input.Length - 1] == ')')
            {
                if (input.Contains('('))
                {
                    if (input[0] == '(')
                    {
                        operand.AdressingMode = AdressingTypes.AI;
                        var value = input.Substring(2, length: input.Length - 3);
                        if (!byte.TryParse(value, out operand.Register))
                            throw new ParseException(i, $"Unknown register: {value}");
                    }
                    else
                    {
                        operand.AdressingMode = AdressingTypes.AX;
                        throw new NotImplementedException("Parser does not support indexed adressing on line " + i.ToString());
                    }
                }
                else
                {
                    throw new ParseException(i, "Found ')' but not opening '('. Did you add any spaces?");
                }
            }
            else if (input[0] == 'r')
            {
                var value = input.Substring(1);
                if (!byte.TryParse(value, out operand.Register))
                    throw new ParseException(i, $"Unknown register: {value}");
                else
                    operand.AdressingMode = AdressingTypes.AD;
            }
            else if (byte.TryParse(input, out operand.Register))
            {
                operand.AdressingMode = AdressingTypes.AI;
            }
            else
            {
                throw new ParseException(i, $"Unknown operand: {input}");
            }

            return operand;
        }
        private void ParseDirective(int i, string[] param, string[] lines, ref Header header, ref int codeStartLine, ref int dataStartLine)
        {
            switch (param[0])
            {
                case ".model":
                    {
                        if (param.Length == 1)
                            throw new ParseException(i, "Missing model type");
                        else
                        {
                            ModelType model;
                            if (Enum.TryParse(param[1], out model))
                                header.Model = model;
                            else
                                throw new ParseException(i, "Invalid model type");
                        }
                    }
                    break;
                case ".stack":
                    {
                        int stackSize;
                        if (param.Length <= 1)
                            stackSize = DefaultStackSize;
                        else
                        {
                            if (int.TryParse(param[1], out stackSize))
                            {
                                if (stackSize % 2 != 0)
                                    throw new ParseException(i, "Stack size must be an even number");
                                header.StackSize = stackSize;
                            }
                            else
                                throw new ParseException(i, "Invalid stack size");
                        }
                    }
                    break;
                case ".data":
                    dataStartLine = i;
                    break;
                case ".code":
                    {
                        codeStartLine = i;
                        ParseLabels(i, codeStartLine, lines);
                    }
                    break;
                default:
                    throw new ParseException(i, "Invalid directive");
            }
        }
        private void ParseData(int i, string line)
        {
            var param = line.Split(' ');

            int type = 0;
            if (line.Contains("db"))
                type = 1;
            if (line.Contains("dw"))
                type = 2;
            if (line.Contains("dd"))
                type = 4;
            if (line.Contains("dq"))
                type = 8;


            Variables.Add(param[0], dataBytesAdded);
            if (type == 1 && param.Length == 3 && param[2][0] == '\'')
            {
                var newData = param[2].Trim('\'').ToArray();
                Array.Reverse(newData);
                Array.Copy(newData, 0, data, dataBytesAdded, newData.Length);
                dataBytesAdded += newData.Length;
            }
            else if (type != 0)
            {

                for (int k = 2; k < param.Length; k++)
                {
                    switch (type)
                    {
                        case 1:
                            {
                                byte converted;
                                if (byte.TryParse(param[k], out converted))
                                {
                                    SetDataByte(dataBytesAdded, converted);
                                    dataBytesAdded++;
                                }
                                else
                                {
                                    throw new ParseException(i, $"${converted} is not a valid byte number");
                                }
                            }
                            break;
                        case 2:
                            {
                                ushort converted;
                                if (ushort.TryParse(param[k], out converted))
                                {
                                    SetDataWord(dataBytesAdded, converted);
                                    dataBytesAdded += 2;
                                }
                                else
                                {
                                    throw new ParseException(i, $"${converted} is not a valid word number");
                                }
                            }
                            break;
                        case 4:
                            {
                                uint converted;
                                if (uint.TryParse(param[k], out converted))
                                {
                                    SetDataDWord(dataBytesAdded, converted);
                                    dataBytesAdded += 4;
                                }
                                else
                                {
                                    throw new ParseException(i, $"${converted} is not a valid double word number");
                                }
                            }
                            break;
                        case 8:
                            {
                                ulong converted;
                                if (ulong.TryParse(param[k], out converted))
                                {
                                    SetDataQWord(dataBytesAdded, converted);
                                    dataBytesAdded += 8;
                                }
                                else
                                {
                                    throw new ParseException(i, $"{converted} is not a valid quad word number");
                                }
                            }
                            break;
                        default:
                            {
                                if (Instructions.ContainsKey(param[0]))
                                    throw new ParseException(i, "Can not contain instructions before .code directive");
                                throw new ParseException(i, "Could not parse line");
                            }
                    }
                }
            }
            else
            {
                throw new ParseException(i, "Illegal data definition");
            }
        }
        private void ParseLabels(int i, int codeStartLine, string[] lines)
        {
            string line;
            int instructions = 0;
            for (int k = 0; k < lines.Length; k++)
            {
                line = lines[k];
                if (line[line.Length - 1] == ':')
                {
                    string label = line.Substring(0, line.Length - 1);
                    if (Labels.ContainsKey(label))
                        throw new ParseException(k, "Can not add duplicate labels. Case insensitive.");
                    else
                        Labels.Add(label, k - codeStartLine);
                }
                else if (Instructions.ContainsKey(line.Split(' ')[0]))
                    instructions++;
            }
        }

        private void SetDataByte(int adress, byte value)
        {
            if (data == null || adress > data.Length)
                throw new IndexOutOfRangeException("Adress out of range memory: " + adress.ToString());
            data[adress] = value;
        }
        private void SetDataWord(int adress, ushort value)
        {
            if (data == null || adress > data.Length)
                throw new IndexOutOfRangeException("Adress out of range memory: " + adress.ToString());
            data[adress] = (byte)value;
            data[adress + 1] = (byte)(value >> 8);
        }
        private void SetDataDWord(int adress, UInt32 value)
        {
            if (data == null || adress > data.Length)
                throw new IndexOutOfRangeException("Adress out of range memory: " + adress.ToString());
            data[adress] = (byte)value;
            data[adress + 1] = (byte)(value >> 8);
            data[adress + 2] = (byte)(value >> 16);
            data[adress + 3] = (byte)(value >> 24);
        }
        private void SetDataQWord(int adress, UInt64 value)
        {
            if (data == null || adress > data.Length)
                throw new IndexOutOfRangeException("Adress out of range memory: " + adress.ToString());
            data[adress] = (byte)value;
            data[adress + 1] = (byte)(value >> 8);
            data[adress + 2] = (byte)(value >> 16);
            data[adress + 3] = (byte)(value >> 24);
            data[adress + 4] = (byte)(value >> 32);
            data[adress + 5] = (byte)(value >> 40);
            data[adress + 6] = (byte)(value >> 48);
            data[adress + 7] = (byte)(value >> 56);
        }
        
        private void SetCodeWord(int adress, ushort value)
        {
            if (code == null || adress > code.Length)
                throw new IndexOutOfRangeException("Adress out of range memory: " + adress.ToString());
            code[adress] = (byte)value;
            code[adress + 1] = (byte)(value >> 8);
        }

        private ushort GetClass0MachineInstruction(ushort opcode, byte mas, byte rs, byte mad, byte rd)
        {
            return (ushort)(opcode << 12 |
                            mas << 10 |
                            rs << 8 |
                            mad << 4 |
                            rd);
        }
        private ushort GetClass1MachineInstruction(ushort opcode, byte mad, byte rd)
        {
            return (ushort)(opcode << 6 |
                            mad << 4 |
                            rd);
        }
        private ushort GetClass2MachineInstruction(ushort opcode, byte offset)
        {
            return 0;
        }

        
    }
}
