public class  Resume
{
    public string _persons_name = "";
    public List<Job> _jobs = new List<Job>(); //La lista es usada con Job en vez de con String porque:
    //esta diciento que se llenará con las variables de la clase job, a saber 4.
    
    public void DisplayResume() 
    {
        Console.WriteLine($"Name: {_persons_name} ");
        Console.WriteLine("Jobs:");

        foreach (Job job in _jobs)//en este codigo estamos llamando a la clase job
        // y luego de llamar a la clase decimos, de esta clase, cada X en _jobs (llmando a la variable de la clase que aintugamente llamamos)
        {
            // This calls the DisplayJobDetails method on each job
            job.DisplayJobDetails();
        }
    }

}
