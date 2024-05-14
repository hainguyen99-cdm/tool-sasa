using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace click_pc.Helpper
{
    public static class UtilitiesFiles
    {
        public static void Writeline(this List<string> theList, string nameFile)
        {
            System.IO.File.WriteAllLines(nameFile, theList);

        }
        public static void WriteFile(string conttent, string fileName = null, string locationPath = null)
        {
            string pathName = locationPath + "\\" + fileName;
            try
            {
                using (System.IO.StreamWriter sw = new StreamWriter(pathName, true))
                {
                    sw.WriteLine(conttent + Environment.NewLine);
                }

            }
            catch
            {

            }
        }
        public static string[] ReadFiles( string inputFile)
        {
            string[] lines = File.ReadAllLines(@inputFile);
            //foreach (string line in lines)
            //{
            //    // Use a tab to indent each line of the file.
            //    string[] words = line.Split(key);
            //    // Console.WriteLine(words[0]) ;
            //    //  Console.ReadKey(); // stop screen
            //    return words;
            //}
            return lines;

        }
        public static ReaderWriterLockSlim _readWriteLock = new ReaderWriterLockSlim();
        public static void WriteToFileThreadSafe(string text, string path)
        {
            _readWriteLock.EnterWriteLock();
            try
            {
                using (StreamWriter sw = System.IO.File.AppendText(path))
                {
                    sw.WriteLine(text);
                    sw.Close();
                }

            }
            finally
            {
                _readWriteLock.ExitWriteLock();
            }
        }
    }
}
