// See https://aka.ms/new-console-template for more information

public class program
{
    public static void Main(String[] args)
    {
        Penjumlahan hitung = new Penjumlahan();
        Console.WriteLine(hitung.JumlahTigaAngka<int>(13, 02, 21));
    }
}
public class Penjumlahan
{
    public T JumlahTigaAngka<T>(T input1, T input2, T input3)
    {
        dynamic number1 = input1;
        dynamic number2 = input2;
        dynamic number3 = input3;
        return number1 + number2 + number3;
    }
}
