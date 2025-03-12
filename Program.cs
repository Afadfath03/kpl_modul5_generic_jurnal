class Program {
    static void Main(string[] args) {
        Penjumlahan penjumlahan = new Penjumlahan();
        long angka1 = 22;
        long angka2 = 11;
        long angka3 = 10;
        var result = penjumlahan.JumlahTigaAngka(angka1, angka2, angka3);
        Console.WriteLine($"{angka1} + {angka2} + {angka3} = {result}");
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