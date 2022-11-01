string sourceDirectory = @"C:\Users\rlasj\Downloads\Google 7zip\Takeout\Google Photos";
string targetDirectory = @"C:\Users\rlasj\OneDrive\Documents\Images";

try
{
    Console.WriteLine( $"{sourceDirectory}");
    recursiveSubFolders(sourceDirectory,"");
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

static void recursiveSubFolders(string dir, string indent)
{
    var subFolders = Directory.EnumerateDirectories(dir);
    foreach (var folder in subFolders)
    {
        Console.WriteLine( $"{indent}\\_{folder}");
        var newIndent = "  " + indent;
        recursiveSubFolders(folder,newIndent);
        enumFiles(folder,indent);
    }
}

static void enumFiles(string dir, string indent)
{
    var txtFiles = Directory.EnumerateFiles(dir, "*.*");
    var debug = 0;
    foreach (string currentFile in txtFiles)
    {
        debug++;
        //string fileName = currentFile.Substring(sourceDirectory.Length + 1);
        if ( debug == 5) break;
        Console.WriteLine($"{indent}\\_{currentFile}");
        // Directory.Move(currentFile, Path.Combine(archiveDirectory, fileName));
    }
}

static bool isFileExistInTargetDirectory(string fileName, string targetDirectory){

}