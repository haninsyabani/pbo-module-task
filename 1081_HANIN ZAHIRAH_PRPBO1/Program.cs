using System;

class Program
{
    static void Main(string[] args)
    {
        // Membuat objek kebun binatang
        KebunBinatang kebunBinatang = new KebunBinatang();

        // Membuat objek hewan
        Singa singa = new Singa("Mufasa", 30, 4);
        Gajah gajah = new Gajah("Trunk", 10, 4);
        Ular ular = new Ular("Naagin", 27, 100);
        Buaya buaya = new Buaya("Boy", 20, 3);

        // Menambahkan hewan ke kebun binatang
        kebunBinatang.TambahHewan(singa);
        kebunBinatang.TambahHewan(gajah);
        kebunBinatang.TambahHewan(ular);
        kebunBinatang.TambahHewan(buaya);

        // Menampilkan semua hewan
        kebunBinatang.DaftarHewan();

        // Polimorfisme (Analisis1)
        singa.Bersuara();
        gajah.Bersuara();
        ular.Bersuara();
        buaya.Bersuara();

        // Memanggil method khusus (Analisis2,4)
        singa.Mengaum();
        ular.Merayap();

        // Menggunakan objek bertipe Reptil (Analisis5)
        Reptil reptil = buaya;
        reptil.Bersuara();

    }
}



// KELAS HEWAN (2A)
public class Hewan
{
    public string Nama;
    public int Umur;

    public Hewan(string nama, int umur)
    {
        Nama = nama;
        Umur = umur;
    }

    public virtual void Bersuara()
    {
        Console.WriteLine("Hewan bersuara");
    }

    public void Bersuara(string suara)
    {
        Console.WriteLine($"Hewan bersuara {suara}");
    }

    public void Bersuara(string suara, int lama)
    {
        Console.WriteLine($"Hewan bersuara {suara} selama {lama} detik");
    }

    public void Bersuara(string suara, double lama)
    {
        Console.WriteLine($"Hewan bersuara {suara} selama {lama} detik");
    }

    public virtual void Makan(string makanan)
    {
        Console.WriteLine($"Hewan sedang makan {makanan}");
    }

    public virtual string InfoHewan()
    {
        return $"Nama: {Nama}, Umur: {Umur}";
    }
}



// KELAS MAMALIA YG MEWARISI HEWAN (2B)
public class Mamalia : Hewan
{
    public int JumlahKaki;

    public Mamalia(string nama, int umur, int jumlahKaki) : base(nama, umur)
    {
        JumlahKaki = jumlahKaki;
    }

    public override void Bersuara()
    {
        Console.WriteLine("Mamalia bersuara");
    }

    public override string InfoHewan()
    {
        return base.InfoHewan() + $", Jumlah Kaki: {JumlahKaki}";
    }
}



// KELAS REPTIL YANG MEWARISI HEWAN (2C)
public class Reptil : Hewan
{
    public double PanjangTubuh;

    public Reptil(string nama, int umur, double panjangTubuh) : base(nama, umur)
    {
        PanjangTubuh = panjangTubuh;
    }

    public override void Bersuara()
    {
        Console.WriteLine("Reptil bersuara");
    }

    public override string InfoHewan()
    {
        return base.InfoHewan() + $", Panjang Tubuh: {PanjangTubuh} meter";
    }
}



// KELAS SINGA YANG MEWARISI MAMALIA (2D)
public class Singa : Mamalia
{
    public Singa(string nama, int umur, int jumlahKaki) : base(nama, umur, jumlahKaki) { }

    public override void Bersuara()
    {
        Console.WriteLine("Singa MENGAUM NGAMUUK!");
    }

    public void Mengaum()
    {
        Console.WriteLine("Singa ngamuk sambil bilang :  RAwwRrrrR~!");
    }
}



// KELAS GAJAH YANG MEWARISI MAMALIA (2D)
public class Gajah : Mamalia
{
    public Gajah(string nama, int umur, int jumlahKaki) : base(nama, umur, jumlahKaki) { }

    public override void Bersuara()
    {
        Console.WriteLine("Gajah mengeluarkan suara DJ TEROMPET!");
    }
}



// KELAS ULAR YANG MEWARISI REPTIL (2E)
public class Ular : Reptil
{
    public Ular(string nama, int umur, double panjangTubuh) : base(nama, umur, panjangTubuh) { }

    public override void Bersuara()
    {
        Console.WriteLine("Ular menderik!");
    }

    public void Merayap()
    {
        Console.WriteLine("Ular merayap meliuk-liuk mau makan kamu! ");
    }
}



// KELAS BUAYA YANG MEWARISI REPTIL (2E)
public class Buaya : Reptil
{
    public Buaya(string nama, int umur, double panjangTubuh) : base(nama, umur, panjangTubuh) { }

    public override void Bersuara()
    {
        Console.WriteLine("Buaya menggerang : hai manis boleh minta no wa nya?");
    }
}



// KELAS KEBUNBINATANG (2F)
public class KebunBinatang
{
    public List<Hewan> KoleksiHewan;

    public KebunBinatang()
    {
        KoleksiHewan = new List<Hewan>();
    }

    public void TambahHewan(Hewan hewan)
    {
        KoleksiHewan.Add(hewan);
    }

    public void DaftarHewan()
    {
        foreach (var hewan in KoleksiHewan)
        {
            Console.WriteLine(hewan.InfoHewan());
        }
    }
}


