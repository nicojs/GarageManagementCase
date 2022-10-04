

using GarageManagementCase;

public static class Program
{

    static string QuestionString(string question)
    {
        Console.WriteLine($"{question}?");
        string? answer = null;
        while (answer == null)
        {
            answer = Console.ReadLine();
        };
        return answer;
    }

    static int QuestionInt(string question)
    {
        int? answer = null;
        while (answer == null)
        {
            var str = QuestionString(question);
            if (int.TryParse(str, out int a))
            {
                answer = a;
            }
        }
        return answer.Value;
    }

    static KlantRepository klantRepository = new KlantRepository();

    static void AddKlant()
    {
        var voornaam = QuestionString("Voornaam");
        var achternaam = QuestionString("Achternaam");
        var straat = QuestionString("Straat");
        var huisnummer = QuestionInt("Huisnummer");
        var plaats = QuestionString("Plaats");
        var postcode = QuestionString("Postcode");
        var telefoonnummer = QuestionString("Telefoonnummer");
        var email = QuestionString("Email");

        var klant = new Klant(voornaam, achternaam, new Adres(straat, huisnummer, plaats, postcode), telefoonnummer, email);
        klantRepository.AddKlant(klant);
    }

    static void KlantenBeheer()
    {
        while (true)
        {
            Console.WriteLine("Klantenbeer. (A)dd. (S)earch. (B)ack.");
            var choice = Console.ReadKey(true);
            switch (choice.KeyChar)
            {
                case 'b':
                    return;
                case 'a':
                    AddKlant();
                    break;
                case 's':
                    SearchKlant();
                    break;
            }
        }


    }

    private static void SearchKlant()
    {
        var naam = QuestionString("Naam");
        foreach(var klant in klantRepository.SearchKlant(naam))
        {
            Console.WriteLine(klant.ToString());
        }
    }

    public static void Main()
    {
        while (true)
        {
            Console.WriteLine("Hoofdmenu. (K)lantenbeheer. (Q)uit");
            var choice = Console.ReadKey(true);
            switch (choice.KeyChar)
            {
                case 'q':
                    return;
                case 'k':
                    KlantenBeheer();
                    break;
            }
        }

    }


}
