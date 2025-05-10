Console.WriteLine("=== FileLogger App ===");

string filePath = Directory.GetCurrentDirectory();
string currentFolder = filePath.Substring(0, filePath.IndexOf("FileLoggerApp") + 13);
string filename = Path.Combine(currentFolder, "LogFile.txt");

if (!File.Exists(filename))
{
    using (FileStream fs = new FileStream(filename, FileMode.CreateNew)) { }
}

Console.WriteLine("write your text then hit enter to save to file.");
Console.WriteLine("write 'exit' to end the app.");

StreamWriter sw = File.AppendText(filename);

while (true)
{
    string line = Console.ReadLine();
    Console.WriteLine(line);
    if (line.ToLower() == "exit")
        break;
    sw.WriteLine(line);
    

    Console.WriteLine("text saved");
}

sw.Close();