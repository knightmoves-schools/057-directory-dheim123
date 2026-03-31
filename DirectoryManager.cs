using System.IO;

namespace knightmoves;

public class DirectoryManager 
{
    public void Create(string directoryName) 
    {
        Directory.CreateDirectory(directoryName);
    }
}

