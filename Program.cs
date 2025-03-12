class Program {
    static void Main(string[] args) {
        Penjumlahan penjumlahan = new Penjumlahan();
        long angka1 = 22;
        long angka2 = 11;
        long angka3 = 10;
        var result = penjumlahan.JumlahTigaAngka(angka1, angka2, angka3);
        Console.WriteLine($"{angka1} + {angka2} + {angka3} = {result}\n");

        SimpleDataBase<long> simpleDataBase = new SimpleDataBase<long>();
        simpleDataBase.AddNewData(angka1);
        simpleDataBase.AddNewData(angka2);
        simpleDataBase.AddNewData(angka3);
        simpleDataBase.ShowData();
    }
}

public class Penjumlahan {
    public T JumlahTigaAngka<T>(T a, T b, T c) {
        dynamic x = a;
        dynamic y = b;
        dynamic z = c;
        return x + y + z;
    }
}

public class SimpleDataBase<T> {
    List<T> storedData = new List<T>();
    List<DateTime> inputDates = new List<DateTime>();

    public SimpleDataBase() {
        storedData = new List<T>();
        inputDates = new List<DateTime>();
    }

    public void AddNewData(T data) {
        storedData.Add(data);
        inputDates.Add(DateTime.Now);
    }

    public void ShowData() {
        for(int i = 0; i < storedData.Count; i++) {
            Console.WriteLine($"Data {i + 1} berisi : {storedData[i]}, yang disimpan pada waktu UTC: {inputDates[i]}");
        }
    }
}