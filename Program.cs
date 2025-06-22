// 1. Katta harf tekshiruvi

Console.Write("Iltimos, bitta harf kiriting: ");
char harfInput = Console.ReadLine()[0];

bool kattaHarfmi = char.IsUpper(harfInput);

Console.WriteLine("Harf kattami? ");

if (kattaHarfmi)
{
    Console.WriteLine("HA");
}
else if (!kattaHarfmi)
{
    Console.WriteLine("YO'Q");
}
else
{
    Console.WriteLine("Boshqa belgi kiritdingiz!");
}

// 2. Ha/Yo'q tekshiruvi

Console.WriteLine("Dasturlash yoqadimi? (Ha/Yo'q)");

string javob = Console.ReadLine();
javob.ToLower();

if (javob == "ha" || javob == "h")
{
    Console.WriteLine("Ajoyib!");
}
else if (javob == "yo'q" || javob == "y" || javob == "yoq")
{
    Console.WriteLine("Afsus!");
}
else
{
    Console.WriteLine("Javobingizni tushunmadim!");
}

// 3. Ismdagi birinchi harf

Console.Write("Iltimos, ismingizni kiriting: ");
string ism = Console.ReadLine().Trim();

char birinchiHarf = ism[0];

Console.WriteLine($"Ismingiz birinchi harfi: {birinchiHarf}");