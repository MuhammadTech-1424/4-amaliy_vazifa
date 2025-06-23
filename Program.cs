// 1. Aqqli robot

Console.Write("Robotga buyruq bering: ");
string buyruq = Console.ReadLine().Trim().ToLower();

string bajarish = buyruq switch
{
    "sakra" => "Robot sakradi.",
    "burul" => "Robot buruldi.",
    "yur" => "Robot yurdi.",
    "to'xta" => "Robot to'xtadi.",
    _ => " < Noma'lum buyruq > "
};

Console.WriteLine(bajarish);
Console.WriteLine();

// 2. Sehrli do'kon

Console.WriteLine("Do'konda bor mashulotlar: olma, anor, olcha, qovun, tarvuz, sabzi, pomidor, sut, non, uzum");
Console.Write("Mahsulot nomini kiriting: ");
string mahsulot = Console.ReadLine().Trim().ToLower();

double narx = mahsulot switch
{
    "olma" => 5000,
    "anor" => 9000,
    "olcha" => 3000,
    "qovun" => 20000,
    "tarvuz" => 15000,
    "sabzi" => 4000,
    "pomidor" => 5000,
    "sut" => 6000,
    "non" => 3000,
    "uzum" => 10000,
    _ => 0
};

if (narx == 0)
{
    Console.WriteLine(" < Bunday mahsulot yo'q > ");
}
else
{
    Console.WriteLine($"Mahsulot narxi: {narx} so'm");
}
Console.WriteLine();

// 3. Trafik yoritgich

Console.Write("Rang kiriting: ");
string rang = Console.ReadLine().Trim().ToLower();

string harakat = (rang == "yashil")    
    ? "Yuring!" 
    : (rang == "sariq")
        ? "Tayyrolaning!"
        : (rang == "qizil")
            ? "To'xtang!"
            : " <Noma'lum rang> ";

Console.WriteLine(harakat);
Console.WriteLine();
