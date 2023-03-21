// See https://aka.ms/new-console-template for more information
public class SimpleDataBase<T>
{
    private List<T> storeddata;
    private List<DateTime> inputDates;

    public SimpleDataBase()
    {
        this.storeddata = new List<T>();
        this.inputDates = new List<DateTime>();
    }

    public void AddNewData(T data)
    {
        this.storeddata.Add(data);
        this.inputDates.Add(DateTime.Now);
    }

    public void printAllData()
    {
        for (int i = 0; i < this.inputDates.Count; i++)
        {
            Console.WriteLine(" Data " + (i+1) + " berisi: " 
                + this.storeddata[i] + " yang disimpan pada waktu " + this.inputDates[i] );
        }
    }
    
}

public class Program
{
    public static void Main(string[] args)
    {
        SimpleDataBase<int> data = new SimpleDataBase<int>();
        data.AddNewData(13);
        data.AddNewData(02);
        data.AddNewData(21);
        data.printAllData();
    }
}
