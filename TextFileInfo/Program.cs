namespace TextFileInfo
{
    class Program
    {   
        public static void Main()
        {
            string filePath = @"C:\Users\Enix\Project\TextFileInfo\TextFileInfo\bin\Debug\net6.0\Values.txt";

            var arrayOfFileLines = new FileReader(filePath);
            var lineWithMaxSum = arrayOfFileLines.GetLineWithMaxSum();
            var rawsWithNonNumbers = arrayOfFileLines.GetRowsWithNonNumbers();

            using (StreamWriter w = File.AppendText(filePath))
            {
                w.WriteLine("\n-------");
                w.WriteLine("Biggest sum is in " + lineWithMaxSum + " line");
                w.WriteLine("Lines with non numeric values are:");

                foreach (var item in rawsWithNonNumbers)
                {
                    w.WriteLine(item);
                }
            }
        }
    }
}