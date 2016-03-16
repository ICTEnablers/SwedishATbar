static int Main(string[] args)
{
    Process p = null;
    try
    {
        p = Process.Start("osk.exe");
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }

    if (p == null)
        return 0;
    else
        return p.Id;
}

