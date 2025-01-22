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
        ShowNamesWithTwoFirstName(male);
    }

    //A& c)
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

    //A6 d)
    static void ShowCombinationOfFirstAndLastName(bool male)
    {
        if(male == true)
        {
            Console.WriteLine("\nHere are the last names with a variaty of male first names.");
            foreach (string lastname in lastNames)
            {
                for (int i = 0; i < firstNamesMale.Length; i++)
                {
                    Console.WriteLine(firstNamesMale[i] + " " + lastname);
                } 
            }
        }
        else
        {
            Console.WriteLine("\nHere are the last names with a variaty of female first names.");
            foreach (string lastname in lastNames)
            {
                for (int i = 0; i < firstNamesFemale.Length; i++)
                {
                    Console.WriteLine(firstNamesFemale[i] + " " + lastname);
                }
            }
        }
    }

    //A6 e)
    static void ShowNamesWithTwoFirstName(bool male)
    {
        if (male == true)
        {
            Console.WriteLine("Here are names with two male first names and a last name.");
            foreach (string lastName in lastNames)
            {
                foreach (string firstName2 in firstNamesMale)
                {
                    foreach (string firstName in firstNamesMale)
                    {
                        if(firstName != firstName2)
                        {
                            Console.WriteLine(firstName + " " + firstName2 + " " + lastName);
                        }
                    }
                }
            }
        }
        else
        {
            Console.WriteLine("Here are names with two female first names and a last name.");
            foreach (string lastName in lastNames)
            {
                foreach (string firstName2 in firstNamesFemale)
                {
                    foreach (string firstName in firstNamesFemale)
                    {
                        if (firstName != firstName2)
                        {
                            Console.WriteLine(firstName + " " + firstName2 + " " + lastName);
                        }
                    }
                }
            }
        }
    }

    //A8 a)

}