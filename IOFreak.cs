using System.IO;

namespace TheFightForSurvivingInTheIoTWorld
{
    public class IOFreak
    {
        const int numberOfItems = 100000000;
        const string fileName = "dump.txt";
        public void Process()
        {
            for (int i = 0; i < 10; i++)
            {
            WriteContentToFile();
            ReadContentFromFile();

            File.Delete(fileName);    
            }
        }

        private void ReadContentFromFile()
        {
            FileStream fileStream = new FileStream(fileName, FileMode.Open);
            using (StreamReader reader = new StreamReader(fileStream))
            {
                while(reader.ReadLine()!=null)
                {

                }
            }
        }

        private void WriteContentToFile()
        {
            FileStream fileStream = new FileStream(fileName, FileMode.OpenOrCreate);
            using (StreamWriter writer = new StreamWriter(fileStream))
            {
                for (int i = 0; i < numberOfItems; i++)
                {
                    writer.WriteLine(i);
                }
            }
        }
    }
}