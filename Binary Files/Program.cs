using System.IO;

FileStream ReaderFile;
FileStream WriterFile;
BinaryReader Reader;
BinaryWriter Writer;

WriterFile = new FileStream("countries.dat",FileMode.OpenOrCreate,FileAccess.Write);
Writer = new BinaryWriter (WriterFile);

Writer.Write("COUNTRIES");
Writer.Write("\nItaly");
Writer.Write("Holand");
Writer.Write("Thailand");
Writer.Write("Japan");
Writer.Write("Germany");
Writer.Write("Iceland");

Writer.Close();
WriterFile.Close();

ReaderFile = new FileStream("countries.dat", FileMode.OpenOrCreate, FileAccess.Read);
Reader = new BinaryReader(ReaderFile);

while (ReaderFile.Position != ReaderFile.Length)
{
    Console.WriteLine(Reader.ReadString());
    Console.WriteLine(Reader.ReadString());
    Console.WriteLine(Reader.ReadString());
    Console.WriteLine(Reader.ReadString());
    Console.WriteLine(Reader.ReadString());
    Console.WriteLine(Reader.ReadString());
    Console.WriteLine(Reader.ReadString());
}
Reader.Close();
ReaderFile.Close();
Console.ReadKey();