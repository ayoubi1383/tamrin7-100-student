using System.Globalization;
using System.Xml.Linq;


List<student> kollnomarat = new List<student>();
StreamReader sr = new StreamReader(@"C:\homework\vorod\tamrin7\tamrin7\nomarat.txt");
while (!sr.EndOfStream)
{
    string zakhire = sr.ReadLine();
    student nomre = new student();
    nomre.FirstName = zakhire.Split(",")[0];
    nomre.LastName = zakhire.Split(",")[1];
    nomre.Pishrafte1 = Convert.ToDouble(zakhire.Split(",")[2]);
    nomre.Pishrafte2 = Convert.ToDouble(zakhire.Split(",")[3]);
    nomre.SheyGeraii = Convert.ToDouble(zakhire.Split(",")[4]);
    nomre.SystemAmel = Convert.ToDouble(zakhire.Split(",")[5]);
    nomre.Algoritm = Convert.ToDouble(zakhire.Split(",")[6]);
    nomre.Riazi = Convert.ToDouble(zakhire.Split(",")[7]);
    nomre.English = Convert.ToDouble(zakhire.Split(",")[8]);
    nomre.Tafsir = Convert.ToDouble(zakhire.Split(",")[9]);
    nomre.Kargah = Convert.ToDouble(zakhire.Split(",")[10]);
    nomre.TarbiatBadani = Convert.ToDouble(zakhire.Split(",")[11]);
    kollnomarat.Add(nomre);
}



do 
{ 
       Console.WriteLine(" Hi, please chose one of them for continue !");
         Console.WriteLine
       ("\n namayesh nam ba moadel ha = 1" +
        "\n namayesh moadelkoll moratab shode = 2" +
        "\n namayesh adad aval moadel ha = 3" +
        "\n namayedh grade daneshjo ha = 4" +
        "\n namayesh nam ba moadelkoll = 5" +
        "\n namayesh doros ba zarayeb = 6" +
        "\n namayesh moadel zir mozo = 7" +
        "\n exit = 0");




 int x = Convert.ToInt32(Console.ReadLine());

    switch (x)
    {
        case 1:
            foreach (var item in kollnomarat)
            {
                Console.WriteLine(item.FirstName + "      " + item.LastName + "      moadel amali :     " + item.amaliaverage()
                    + "      moadel teory :      " + item.teoryaverage() + "      moadelomomy :      " + item.omomyaverage() +
                    "       moadelkoll :      " + item.totalaverage());
                Console.WriteLine("=========================================================================================" +
                  "========================================================");
            }
            break;
        case 2:
            foreach (var s in kollnomarat)
            {
                var items = new[]
                {
                 new {name= s.FirstName ,lname = s.LastName ,score = s.totalaverage()  }
                };
                var sortitems = items.OrderBy(item => item.score);

                foreach (var d in items)
                {
                    Console.WriteLine(d.name + "   "+d.lname + "     koll :   "+ d.score);
                }

            }
            break;
        case 3:
            foreach (var s in kollnomarat)
            {
                List <int > adad = new List <int>();
                    adad.Add(Convert.ToInt32(s.Pishrafte1));            adad.Add(Convert.ToInt32(s.Pishrafte2)); 
                    adad.Add(Convert.ToInt32(s.SheyGeraii));            adad.Add(Convert.ToInt32(s.SystemAmel));  
                    adad.Add(Convert.ToInt32(s.Riazi));                 adad.Add(Convert.ToInt32(s.English));  
                    adad.Add(Convert.ToInt32(s.Tafsir));                adad.Add(Convert.ToInt32(s.Kargah));   
                    adad.Add(Convert.ToInt32(s.TarbiatBadani));         adad.Add(Convert.ToInt32(s.Algoritm));

                for (int y = 0; y < 8; y++)
                {
                    bool primenumber = true;
                    for (int i = 2; i * i <= adad[y]; i++)
                    {
                        if (adad[y] % i == 0)
                        {
                            primenumber = false;
                            break;
                        }
                    }
                    if (primenumber)
                    {
                        Console.WriteLine(adad[y]);
                    }
                    else { }
                }
            }
            break;
        case 4:
            foreach (var s in kollnomarat)
            {
                switch (s.totalaverage())
                {
                    case double n when n > 17 && n <= 20:
                        Console.WriteLine(s.FirstName + "   "+ s.LastName + "       your grade is : A  ");
                        Console.WriteLine("==================================================================================");
                        break;
                    case double n when n > 15 && n <= 17:
                        Console.WriteLine(s.FirstName + "   " + s.LastName + "       your grade is : B  ");
                        Console.WriteLine("==================================================================================");
                        break;
                    case double n when n > 13 && n <= 15:
                        Console.WriteLine(s.FirstName + "   " + s.LastName + "       your grade is : C  "); 
                        Console.WriteLine("==================================================================================");
                        break;
                    case double n when n > 10 && n <= 13:
                        Console.WriteLine(s.FirstName + "   " + s.LastName + "       your grade is : D  ");
                        Console.WriteLine("==================================================================================");
                        break;
                    case double n when n > 7 && n <= 10:
                        Console.WriteLine(s.FirstName + "   " + s.LastName + "       your grade is : E  ");
                        Console.WriteLine("==================================================================================");
                        break;
                    case double n when n > 3 && n <= 7:
                        Console.WriteLine(s.FirstName + "   " + s.LastName + "       your grade is : F  ");
                        Console.WriteLine("==================================================================================");
                        break;
                    case double n when n >= 0 && n <= 3:
                        Console.WriteLine(s.FirstName + "   " + s.LastName + "       your grade is : G ");
                        Console.WriteLine("==================================================================================");
                        break;
                }
            }
            break;
        case 5:
            foreach (var item in kollnomarat)
            {
                Console.WriteLine(item.FirstName + "     " + item.LastName + "   koll :   " + item.totalaverage());
                Console.WriteLine("================================================================================");
            }
            break;
        case 6:
                Console.WriteLine
                       ("\n Pishrafte1 * 3   " +
                        "\n Pishrafte2 * 3   " +
                        "\n SheyGeraii * 3   " +
                        "\n SystemAmel * 3   " +
                        "\n Algoritm * 3     " +
                        "\n Riazi * 2        " +
                        "\n English * 2      " +
                        "\n Tafsir * 1       " +
                        "\n Kargah * 1       " +
                        "\n TarbiatBadani * 1");
            break;
        case 7:
            foreach (var item in kollnomarat)
            {
                Console.WriteLine(item.FirstName + "      " + item.LastName + "      moadel amali :     " + item.amaliaverage()
                    + "      moadel teory :      " + item.teoryaverage() + "      moadelomomy :      " + item.omomyaverage());
                Console.WriteLine("=========================================================================================" +
                  "====================================");
            }
            break;
        case 0:
            throw new ArgumentOutOfRangeException();
    }

} while (true);


class student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public double Pishrafte1 { get; set; }
    public double Pishrafte2 { get; set; }
    public double SheyGeraii { get; set; }
    public double SystemAmel { get; set; }
    public double Algoritm { get; set; }
    public double Riazi { get; set; }
    public double English { get; set; }
    public double Tafsir { get; set; }
    public double Kargah { get; set; }
    public double TarbiatBadani { get; set; }
    public double totalaverage()
    {
        double ave = (Pishrafte1 * 3) + (Pishrafte2 * 3) + (SheyGeraii * 3)
            + (SystemAmel * 3) + (Algoritm * 3)
            + (Riazi * 2) + (English * 2) + (Tafsir * 1)
            + (Kargah * 1) + (TarbiatBadani * 1) ;
        double aveg = ave / 22;
        aveg = Math.Round(aveg, 2);
        return aveg;
    }
    public double amaliaverage()
    {
        double ave = ((Pishrafte1 * 3) + (Pishrafte2 * 3) + (SheyGeraii * 3)
           + (SystemAmel * 3) + (Algoritm * 3)) / 15;
        ave = Math.Round(ave, 2);
        return ave;
    }
    public double teoryaverage()
    {
        double ave = ((Riazi * 2) + (English * 2)) / 4;
        ave = Math.Round(ave, 2);
        return (ave);
    }
    public double omomyaverage()
    {
        double ave = ((Tafsir * 1) + (Kargah * 1) + (TarbiatBadani * 1)) / 3;
        ave = Math.Round(ave, 2);
        return (ave);
    }

}






