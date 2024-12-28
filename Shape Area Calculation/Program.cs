using System;

public class Sekil
{
    public virtual double AlanHesapla()
    {
        return 0;
    }
}


public class Kare : Sekil
{
    public double Kenar { get; set; }

    public Kare(double kenar)
    {
        Kenar = kenar;
    }

    public override double AlanHesapla()
    {
        return Kenar * Kenar;
    }
}

public class Dikdortgen : Sekil
{
    public double Uzunluk { get; set; }
    public double Genislik { get; set; }

    public Dikdortgen(double uzunluk, double genislik)
    {
        Uzunluk = uzunluk;
        Genislik = genislik;
    }

    public override double AlanHesapla()
    {
        return Uzunluk * Genislik;
    }
}

public class DikdortgenPrizmasi : Sekil
{
    public double Uzunluk { get; set; }
    public double Genislik { get; set; }
    public double Yukseklik { get; set; }

    public DikdortgenPrizmasi(double uzunluk, double genislik, double yukseklik)
    {
        Uzunluk = uzunluk;
        Genislik = genislik;
        Yukseklik = yukseklik;
    }


    public override double AlanHesapla()
    {
        return Uzunluk * Genislik * Yukseklik;
    }
}


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Şekil Alan ve Hacim Hesaplama Uygulaması");

        // Kare
        Console.Write("Kare'nin kenar uzunluğunu girin: ");
        double kareKenar = double.Parse(Console.ReadLine());
        Kare kare = new Kare(kareKenar);
        Console.WriteLine($"Karenin Alanı: {kare.AlanHesapla()}");

        // Dikdörtgen
        Console.Write("Dikdörtgen'in uzunluğunu girin: ");
        double dikdortgenUzunluk = double.Parse(Console.ReadLine());
        Console.Write("Dikdörtgen'in genişliğini girin: ");
        double dikdortgenGenislik = double.Parse(Console.ReadLine());
        Dikdortgen dikdortgen = new Dikdortgen(dikdortgenUzunluk, dikdortgenGenislik);
        Console.WriteLine($"Dikdörtgenin Alanı: {dikdortgen.AlanHesapla()}");

        // Dikdörtgen Prizması
        Console.Write("Dikdörtgen Prizması'nın uzunluğunu girin: ");
        double prizmaUzunluk = double.Parse(Console.ReadLine());
        Console.Write("Dikdörtgen Prizması'nın genişliğini girin: ");
        double prizmaGenislik = double.Parse(Console.ReadLine());
        Console.Write("Dikdörtgen Prizması'nın yüksekliğini girin: ");
        double prizmaYukseklik = double.Parse(Console.ReadLine());
        DikdortgenPrizmasi prizma = new DikdortgenPrizmasi(prizmaUzunluk, prizmaGenislik, prizmaYukseklik);
        Console.WriteLine($"Dikdörtgen Prizması'nın Hacmi: {prizma.AlanHesapla()}");

        Console.ReadLine();
    }
}
