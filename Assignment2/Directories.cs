using System;
using System.IO;

public class Directories
{
    public void CreateDirectories()
    {
        string directoryName = @"E:\Study materials\Dot Net Class\MBM\Anish.Ghimire\Assignment2\ABC";
        string subDirectoryName = "Subfolder";
        Directory.CreateDirectory(directoryName);

        string helloWorldProgram = File.ReadAllText(@"E:\Study materials\Dot Net Class\MBM\Anish.Ghimire\Assignment2\HelloWorld.cs");

        for (int i = 1; i <= 10; i++)
        {
            string subDirectory = $"{directoryName}/{subDirectoryName + i}";
            Directory.CreateDirectory(subDirectory);
            string fileName = $"{directoryName}/{subDirectoryName + i}/HelloWorld.cs";
            File.WriteAllText(fileName, helloWorldProgram);
        }
        Console.WriteLine("Created folders and added Hello World program successfully!!");
    }
}