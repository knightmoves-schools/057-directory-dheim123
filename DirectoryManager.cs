using System.IO;

namespace knightmoves;

public class DirectoryManager 
{
    public void Create(string directoryName) 
    {
        string fullPath = Path.Combine(directoryName, "test-directory");
        
        Directory.CreateDirectory(fullPath);
    }
}

