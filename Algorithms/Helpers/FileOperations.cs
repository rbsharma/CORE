using System;
using System.IO;

namespace DSA.Helpers
{
    public static class FileOperations
    {
        public static int[] GetTestData()
        {
            return ReadTestFiles();
        }

        static int[] ReadTestFiles()
        {
            try
            {
                var testCaseFolderPath = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", "\\testcases");
                var testCaseFiles = Directory.GetFiles(testCaseFolderPath);

                var lines = File.ReadAllLines(testCaseFiles[0]);
                int[] arr = new int[lines.Length];
                for (int i = 0; i < lines.Length; i++)
                {
                    arr[i] = Convert.ToInt32(lines[i]);
                }
                return arr;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
