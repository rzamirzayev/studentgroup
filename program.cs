using ClassTask;
using System.Security.Cryptography.X509Certificates;
using System.Xml;

string secim;

StudentService service = new StudentService();
do
{
    Console.WriteLine("1.Create");
    Console.WriteLine("2.Delte");
    Console.WriteLine("3.Edit");
    Console.WriteLine("4.Siyahi gosterilir");
    Console.WriteLine("5.Telebe yoxlanisi");
    Console.WriteLine("Cixis elemek ucun 0 basin");
    secim = Console.ReadLine();
    if (secim == "1")
    {
        service.Create();




    }
    else if (secim == "2")
    {
        service.Delete();

    }
    else if (secim == "3")
    {
        service.Edit();

    }
    else if (secim == "4")
    {
        service.GetAll();


    }
    else if (secim == "5")
    {

    }
    


} while (secim != "0");
