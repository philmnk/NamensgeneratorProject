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
        Console.WriteLine("Are you male or female?");
        do
        {
            string gender = Console.ReadLine();
        }
        while (gender != "male" && gender != "female"):

        if (gender == "male")
        {
            bool male = true;
        }
        else
        {
            bool male = false;
        }

        
        return male;
    }
}