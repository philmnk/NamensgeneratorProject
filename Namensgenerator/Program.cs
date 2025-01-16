class Program
{
    //A6 a)
    static string[] firstnamesFemale = { "Aeloria", "Lyrielle", "Sylvara", "Elunara", "Seraphina", "Nymira", "Thalindra", "Isoldea", "Veylana", "Celyndra" };
    static string[] firstnamesMale = { "Kaelion", "Darakor", "Fenrik", "Thalion", "Ravendryn", "Orinvar", "Brynthar", "Zarathos", "Eryndor" };
    static string[] lastnames = { "Dämmerhain", "Nachtklinge", "Silbersturm", "Morgentau", "Eisenschlag", "Dunkelquell", "Flammenfels", "Sturmschatten" };

    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to: Fantasy Name Generator!");
        Console.WriteLine("-----------------------------------");
        //A6 b)
        Array.Sort(firstnamesFemale);
        Array.Sort(firstnamesMale);
        Array.Sort(lastnames);

        bool male = ShowFirstnames();
    }

    static bool ShowFirstnames()
    {
        string sex = "asdf";
        do
        {
            Console.WriteLine("Are you male or female?");
            sex = Console.ReadLine();
        }
        while (sex != "male" && sex != "female");

        bool male = true;
        if (sex == "male")
        {
            male = true;
            Console.WriteLine("Serkan");
        }
        else
        {
            male = false;
            Console.WriteLine("Alex");
        }
        return male;
    }
}