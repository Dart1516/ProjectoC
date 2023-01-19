public class Read_and_Write
{
    public string _myfile;
    public string _writed_entry = "";
    
    public void for_reading_the_file()
    {
        foreach (string line in System.IO.File.ReadLines(_myfile!))
        {  
            System.Console.WriteLine(line);  
        }  
    }
    public void creating_a_file()
    {
        using (StreamWriter outputFile = new StreamWriter(_myfile!))
        {
            outputFile.WriteLine($"--------------------{_myfile}--------------------");
        }
    }
    public void writing_on_file(string rando_pharase, string dateText)
    {
        using (StreamWriter archivo = File.AppendText(_myfile!))
        {
            archivo.WriteLine($"{_writed_entry}");
        }
    }
}
