
using iniprosesor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using laptopku;
using VGA;


namespace laptopku
{
    public class inilaptop
    {
        public string merk;
        public string tipe;
        public Vga vga;
        public prosesor processor;

        public void LaptopDinyalakan()
        {
            Console.WriteLine("Laptop {0} {1} menyala", this.merk, this.tipe);

        }
        public void LaptopDimatikan()
        {
            Console.WriteLine("Laptop {0} {1} mati", this.merk, this.tipe);
        }

    }
    public class asus : inilaptop
    {
        public asus()
        {
            merk = "Asus 13 pro max";
        }
    }
    public class legion : asus
    {
        public legion()
        {
            tipe = "Legion yang kek punya haikal";
        }
    }
    public class acer : asus
    {
        public acer()
        {
            tipe = "Vivobook";
        }
        public void Ngoding()
        {
            Console.WriteLine("Ctak Ctak Ctak, error lagi!!");
        }
    }

    public class HP : inilaptop
    {
        public HP()
        {
            merk = "Lupa merknya, pokok kek punya pak yanuar";
        }
    }
    public class Aspire : HP
    {
        public Aspire()
        {
            tipe = "Aspire 5";
        }
    }
    public class Predator : HP
    {
        public Predator()
        {
            tipe = "Predator";
        }
        public void BermainGame()
        {
            Console.WriteLine("Laptop {0} {1} sedang memainkan game", this.merk, this.tipe);
        }

    }
    public class Lenovo : inilaptop
    {
        public Lenovo()
        {
            merk = "Lenovo";
        }
    }
    public class aspire2 : Lenovo
    {
        public aspire2()
        {
            tipe = "IdeaPad";
        }
    }
    public class Legion : Lenovo
    {
        public Legion()
        {
            tipe = "Legion";
        }
    }
}
namespace iniprosesor
{
    public class prosesor
    {
        public string merk, tipe;
    }
    public class Intel : prosesor
    {
        public Intel()
        {
            merk = "Intel";
        }
    }
    public class Corei3gen9 : Intel
    {
        public Corei3gen9()
        {
            tipe = "Core i3 Gen 9";
        }
    }
    public class CoreI5 : Intel
    {
        public CoreI5()
        {
            tipe = "Core i5 11900kf";
        }
    }
    public class CoreI7 : Intel
    {
        public CoreI7()
        {
            tipe = "Core i7 10900h";
        }
    }
    public class AMD : prosesor
    {
        public AMD()
        {
            merk = "AMD";
        }
    }
    public class Ryzen : AMD
    {
        public Ryzen()
        {
            tipe = "BTR RIZEN";
        }
    }
    public class Athlon : AMD
    {
        public Athlon()
        {
            tipe = "ATHLON jujur aku gatau ini merk apa";
        }
    }
}
namespace VGA
{
    public class Vga
    {
        public string merk;
    }
    public class Nvidia : Vga
    {
        public Nvidia()
        {
            merk = "Nvidia";
        }
    }
    public class AMD : Vga
    {
        public AMD()
        {
            merk = "AMD";
        }
    }
}
public class eksekusi
{

    static void Main(string[] args)
    {

        inilaptop laptop1 = new inilaptop();
        laptop1 = new acer();
        laptop1.vga = new VGA.Nvidia();
        laptop1.processor = new CoreI5();

        inilaptop laptop2 = new inilaptop();
        laptop2 = new aspire2();
        laptop2.vga = new VGA.AMD();
        laptop2.processor = new Ryzen();

        Predator predator = new Predator();
        predator = new Predator();
        predator.vga = new VGA.AMD();
        predator.processor = new CoreI7();

        Console.WriteLine("\nSoal 1");
        laptop2.LaptopDinyalakan();
        laptop2.LaptopDimatikan();

        Console.WriteLine("\nSoal 2");
        laptop1.Ngoding();

        Console.WriteLine("\nSoal 3");
        Console.WriteLine(laptop1.vga.merk);
        Console.WriteLine(laptop1.processor.merk);
        Console.WriteLine(laptop1.processor.tipe);

        Console.WriteLine("\nsoal 4");
        predator.BermainGame();

        Console.WriteLine("\nSoal 5");
        HP acer = new HP();
        acer = new Predator();
        acer.BermainGame();

    }

}