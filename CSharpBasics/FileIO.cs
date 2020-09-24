using System;
using System.IO;

public class FileIO
{
    public void LearnFileHandling()
    {
        string fileName="Iterati.cs";
        if (File.Exists(fileName))
        {
            string fileContent=File.ReadAllText("Iteration.cs");
        Console.WriteLine(fileContent);

        }
        File.WriteAllText(fileName,"this is just a test file");


        

        
    }
    public void LearnFileInfo()
    {
        string fileName="file.txt";
        FileInfo fileInfo= new FileInfo(fileName);
        var size=fileInfo.Length;
        var createdDate =fileInfo.CreationTime;
        Console.WriteLine($"File Size:{size}bytes");
        Console.WriteLine($"Created:{createdDate}");



    }
    public void LearnDirectories()
    {
        string directoryName="A";
        Directory.CreateDirectory(directoryName);

    }
    //Create a folder "ABC", create 10 sub folders in "Parent".
    //Each sub folder should contain a C# file with "Hello World" program

}