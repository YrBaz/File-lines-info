using System.Text.RegularExpressions;

namespace TextFileInfo
{
    public class FileReader
    {
        public string[] ReadArrayFromFile { get; set; }
        public string FilePath { get; }

        public FileReader(string filePath)
        {
            FilePath = filePath;
            ReadArrayFromFile = File.ReadAllLines(filePath);
        }

        public int GetLineWithMaxSum()
        {
            int[] sumOfLines = new int[FilePath.Length];

            for (int i = 0; i < ReadArrayFromFile.Length; i++)
            {
                var sumOfLineValues = Regex.Matches(ReadArrayFromFile[i], @"\d+").Cast<Match>().Select(x => int.Parse(x.Value)).Sum();
                sumOfLines[i+1] = sumOfLineValues;
            }
            var indexOfLineWithMaxSum = Array.IndexOf(sumOfLines, sumOfLines.Max());
            return indexOfLineWithMaxSum;
        }

        public List<int> GetRowsWithNonNumbers()
        {
            var arrayOfRawsWithNonNumbers = new List<int>();

            for (int i = 0; i < ReadArrayFromFile.Length; i++)
            {
                var nonNumbers = Regex.IsMatch(ReadArrayFromFile[i], @"[a-zA-Z]");
                if (nonNumbers)
                {
                    arrayOfRawsWithNonNumbers.Add(i+1);
                }
            }
            return arrayOfRawsWithNonNumbers;
        }
    }
}
