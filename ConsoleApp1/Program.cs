using System.Xml;

Console.WriteLine("skriv in din ålder");

int ageNum = 0;
bool success = false;
int para = 100;
bool access = false;
int product = 0;
string producttemp

while (success == false)
{
    string age = Console.ReadLine();
    success = int.TryParse(age, out ageNum);
    if (success == false)
    {
        Console.WriteLine("aja baja det måste vara endast siffror i din ålder");
    }
}

if (ageNum >= 18)
{
    Console.WriteLine($"wilkommen, du är {ageNum} år gammal, vilket är över 18 år.");
    access = true;
} else
{
    Console.WriteLine("GET OUT!!!");
}

if (access)
{
    while (para >= 0)
    {
        Console.WriteLine($"Du har {para} kronor kvar.");
        Console.WriteLine("\nVilken vara vill du köpa?  ...Eller vill du tagga jalla walla balla?");
        Console.WriteLine("\nVara nr 1: Äcklig päron 1kr");
        Console.WriteLine("Vara nr 2: Vanlig päron 2kr");
        Console.WriteLine("Vara nr 3: As cool päron 5kr");

        producttemp = Console.ReadLine();
        int.TryParse(producttemp, out product);
        


    }
}





Console.ReadLine();