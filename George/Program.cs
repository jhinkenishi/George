using System;

public delegate int addTears(int x);
namespace George
{
    struct Anime
    {
        public string name;
        public int released;
    }

    enum Attitude
    {
        good,
        bad
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Person implements to IPerson
            Person person = new Person();
            person.eat();
            //Struct
            Anime anime = new Anime();
            anime.name = "Your name";
            anime.released = 2016;
            Console.WriteLine("Anime: " + anime.name + " , Released: " + anime.released);
            //Delegate
            addTears addTears = new addTears(person.tears);
            addTears(10);
            Console.WriteLine("MyTears: " + person.myTears);
            //Enum
            Console.WriteLine(Attitude.good);
            Console.WriteLine(Attitude.bad); 

        }
    }
}
