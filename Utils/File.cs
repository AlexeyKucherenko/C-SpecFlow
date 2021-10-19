class File
{
    private string _filePath;
    private File(string root, params string[] filePath)
    {
    }

    public static File Resources()
    {
        return new File("gd");
    }
}
