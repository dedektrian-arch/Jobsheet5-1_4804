Console.Write("Nama pelanggan: ");
string namaPelanggan = Console.ReadLine() ?? "";

Console.Write("Jumlah halaman: ");
int jumlahHalaman = Convert.ToInt32(Console.ReadLine());

Console.Write("Harga per halaman: ");
int hargaPerHalaman = Convert.ToInt32(Console.ReadLine());

const int biayaAdmin = 2000;

int subtotal = jumlahHalaman * hargaPerHalaman;
int totalBayar = subtotal + biayaAdmin;

Console.WriteLine("\n=== RINCIAN PENCETAKAN ===");
Console.WriteLine("Nama pelanggan = " + namaPelanggan);
Console.WriteLine("Jumlah halaman = " + jumlahHalaman);
Console.WriteLine("Harga per halaman = " + hargaPerHalaman);
Console.WriteLine("Subtotal = " + subtotal);
Console.WriteLine("Biaya administrasi = " + biayaAdmin);
Console.WriteLine("Total bayar = " + totalBayar);
