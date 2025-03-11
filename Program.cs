using modul4_103022330128;

class Program
{
    static void Main(string[] args)
    {
        KodeProduk kodeProduk = new KodeProduk();
        int i = 0;
        Console.WriteLine(
            $"Kode Laptop = {kodeProduk.getKodeProduk(KodeProduk.produkElektronik.Laptop)}" +
            $"Kode Smartphone = {kodeProduk.getKodeProduk(KodeProduk.produkElektronik.Smartphone)}" +
            $"Kode Tablet = {kodeProduk.getKodeProduk(KodeProduk.produkElektronik.Tablet)}" +
            $"Kode Headset = {kodeProduk.getKodeProduk(KodeProduk.produkElektronik.Headset)}" +
            $"Kode Keyboard= {kodeProduk.getKodeProduk(KodeProduk.produkElektronik.Keyboard)}" +
            $"Kode Mouse = {kodeProduk.getKodeProduk(KodeProduk.produkElektronik.Mouse)}" +
            $"Kode Printer = {kodeProduk.getKodeProduk(KodeProduk.produkElektronik.Printer)}" +
            $"Kode Monitor = {kodeProduk.getKodeProduk(KodeProduk.produkElektronik.Monitor)}" +
            $"Kode Smartwatch = {kodeProduk.getKodeProduk(KodeProduk.produkElektronik.Smartwatch)}" +
            $"Kode Kamera= {kodeProduk.getKodeProduk(KodeProduk.produkElektronik.Kamera)}" 
        ); 
    }

}
  