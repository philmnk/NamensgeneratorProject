class Program
{
    //A6 a)
    static string[] firstNamesFemale = { "Aeloria", "Lyrielle", "Sylvara", "Elunara", "Seraphina", "Nymira", "Thalindra", "Isoldea", "Veylana", "Celyndra" };
    static string[] firstNamesMale = { "Kaelion", "Darakor", "Fenrik", "Thalion", "Ravendryn", "Orinvar", "Brynthar", "Zarathos", "Eryndor" };
    static string[] lastNames = { "Dämmerhain", "Nachtklinge", "Silbersturm", "Morgentau", "Eisenschlag", "Dunkelquell", "Flammenfels", "Sturmschatten" };

    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to: Fantasy Name Generator!");
        Console.WriteLine("-----------------------------------");
        //A6 b)
        Array.Sort(firstNamesFemale);
        Array.Sort(firstNamesMale);
        Array.Sort(lastNames);

        bool male = ShowFirstNamesBasedOfSex();
        ShowCombinationOfFirstAndLastName(male);
    }

    static bool ShowFirstNamesBasedOfSex()
    {
        string sex = "asdf";
        do
        {
            Console.WriteLine("Is your character male or female?");
            sex = Console.ReadLine();
        }
        while (sex != "male" && sex != "female");

        bool male = true;
        if (sex == "male")
        {
            male = true;
            Console.WriteLine("There are " + firstNamesMale.Length + " male names.");
            foreach (string firstNameMale in firstNamesMale)
            {
                Console.WriteLine(firstNameMale);
            }

        }
        else
        {
            male = false;
            Console.WriteLine("There are " + firstNamesFemale.Length + " female names.");
            foreach(string firstNameFemale in firstNamesFemale)
            {
                Console.WriteLine(firstNameFemale);
            }
        }
        return male;
    }

    static void ShowCombinationOfFirstAndLastName(bool male)
    {
        if(male == true)
        {
            foreach (string lastname in lastNames)
            {
                for (int i = 0; i < firstNamesMale.Length; i++)
                {
                    Console.WriteLine(firstNamesMale[i] + lastname);
                } 
            }
        }
        else
        {
            foreach (string lastname in lastNames)
            {
                for (int i = 0; i < firstNamesFemale.Length; i++)
                {
                    Console.WriteLine(firstNamesFemale[i] + lastname);
                }
            }
        }
    }
}