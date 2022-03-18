class Calculator
{
    static void Main(string[] args)
    {
        int a;
        int b;

        console.WriteLine("Pilih menu calculator:");
        console.WriteLine("1. Penambahan");
        console.WriteLine("2. Pengurangan");
        console.WriteLine("3. Perkalian");
        console.WriteLine("4. Pembagian");

        console.WriteLine("Input nomor menu [1..4]:");
        int pilih = Convert.ToInt32(console.ReadLine());
		
		if(read == '1')
		{
			console.WriteLine("Inputkan nilai a = ");
			int a = Convert.ToInt32(console.ReadLIne());
			console.writeLine("Inputkan nilai b = ");
			int b = Convert.ToInt32(console.ReadLine());
			console.WriteLine($"Hasil Penambahan adalah : {a + b}");
		} else if(read == '2')
		{
			console.WriteLine("Inputkan nilai a = ");
			int a = Convert.ToInt32(console.ReadLIne());
			console.writeLine("Inputkan nilai b = ");
			int b = Convert.ToInt32(console.ReadLine());
			console.WriteLine($"Hasil Pengurangan adalah : {a - b}");
		} else if(read == '3')
		{
			console.WriteLine("Inputkan nilai a = ");
			int a = Convert.ToInt32(console.ReadLIne());
			console.writeLine("Inputkan nilai b = ");
			int b = Convert.ToInt32(console.ReadLine());
			console.WriteLine($"Hasil Perkalian adalah : {a * b}");
		} else if(read == '4')
		{
			console.WriteLine("Inputkan nilai a = ");
			int a = Convert.ToInt32(console.ReadLIne());
			console.writeLine("Inputkan nilai b = ");
			int b = Convert.ToInt32(console.ReadLine());
			console.WriteLine($"Hasil Pembagian adalah : {a / b}");
		} else 
		{
			console.WriteLine("Maaf, menu tidak tersedia");
		}
        

        Console.WriteLine("\nTekan sembarang key untuk keluar");
        Console.ReadKey();
    }
}

