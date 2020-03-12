class calculator
{
	static void Main (string[] args)
	{
		int a=10;
		int b=6;
		console.writeLine("Hasil Penambahan: {0} + {1} = {2}", a, b, penjumlahan);
		console.writeLine("Hasil Pengurangan: {0} - {1} = {2}", a, b, pengurangan);
		console.writeLine("\ntekan sembarang key untuk keluar..");
		console.readKey();
	}
	static int penjumlahan(int a, int b)
	{
		return a+b;
	}
	static int pengurangan(int a, int b)
	{
		return a-b;
	}
}
