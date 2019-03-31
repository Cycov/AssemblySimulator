using FileFormatter;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Assembler
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm());
            }
            else
            {
                //var parser = new Parser(args[1]);
                if (!File.Exists(args[0]))
                {
                    Console.WriteLine("File {0} does not exist", args[0]);
                    Environment.Exit(1);
                }
                else
                {
                    using (Stream ms = File.OpenWrite(args[0].Split('.')[0] + ".df"))
                    {
                        Parser parser = new Parser();
                        DataFile parsed = parser.Parse(File.ReadAllLines(args[0]));
                        BinaryFormatter bf = new BinaryFormatter();
                        bf.Serialize(ms, parsed);

                        ms.Flush();
                        ms.Close();
                    }
                }
            }
        }
    }
}
