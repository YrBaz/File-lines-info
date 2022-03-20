using System.Collections.Generic;
using TextFileInfo;
using Xunit;

namespace UnitTest
{
    public class FileReaderTest
    {
        [Fact]
        public void FileReader_ArrayOfNumbersInput_ReturnIndexOfRawWithMaxSum()
        {

            string filePath = @"C:\Users\Enix\Project\TextFileInfo\TextFileInfo\bin\Debug\net6.0\Values.txt";
            var fileReader = new FileReader(filePath);
            var result = 5;
            
            var sut = fileReader.GetLineWithMaxSum();

            Assert.Equal(result, sut);
        }

        [Fact]
        public void FileReader_RawsWithNonNumbers_ReturnIndexOfRawWithNonNumbers()
        {
            string filePath = @"C:\Users\Enix\Project\TextFileInfo\TextFileInfo\bin\Debug\net6.0\Values.txt";
            var fileReader = new FileReader(filePath);
            var result = new List<int> {3, 6, 8};

            var sut = fileReader.GetRowsWithNonNumbers();

            Assert.Equal(result, sut);
        }
    }
}