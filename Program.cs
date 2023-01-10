List<int> sayiListesi = new List<int>();

sayiListesi.Add(0);
sayiListesi.Add(12);
sayiListesi.Add(24);
sayiListesi.Add(85);

List<string> renkler = new List<string>();

renkler.Add("Mavi");
renkler.Add("Sarı");
renkler.Add("Kırmızı");
renkler.Add("Yeşil");

Console.WriteLine(renkler.Count);
Console.WriteLine("====================");
Console.WriteLine(sayiListesi.Count);
Console.WriteLine("====================");

foreach (var sayi in sayiListesi)
{
    Console.WriteLine(sayi);
}
Console.WriteLine("====================");
foreach (var renk in renkler)
{
    Console.WriteLine(renk);
}

List<Kullanıcılar> kullanıcıListesi = new List<Kullanıcılar>();

Kullanıcılar kullanıcı1 = new Kullanıcılar();
kullanıcı1.Isim = "Gökberk";
kullanıcı1.Soyisim = "Perem";
kullanıcı1.Yas = 29;

Kullanıcılar kullanıcı2 = new Kullanıcılar();
kullanıcı2.Isim = "Ayşen";
kullanıcı2.Soyisim = "Perem";
kullanıcı2.Yas = 26;

kullanıcıListesi.Add(kullanıcı1);
kullanıcıListesi.Add(kullanıcı2);

foreach (var kullanıcılar in kullanıcıListesi)
{
    Console.WriteLine("Kullanıcı Adı : " + kullanıcılar.Isim);
    Console.WriteLine("Kullanıcı Soyadı : " + kullanıcılar.Soyisim);
    Console.WriteLine("Kullanıcı Yaşı : " + kullanıcılar.Yas);
    Console.WriteLine("===================");
}

public class Kullanıcılar
{
    string isim;

    string soyisim;

    int yas;

    public string Isim { get => isim; set => isim = value; }
    public string Soyisim { get => soyisim; set => soyisim = value; }
    public int Yas { get => yas; set => yas = value; }
}