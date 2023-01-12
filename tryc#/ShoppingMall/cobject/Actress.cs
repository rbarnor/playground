class Actress
{
    Actress(string name, int age, string ethnic, bool is_fav)
    {
        name = name;
        age = age;
        ethnic = ethnic;
        is_fav = is_fav;
    }
}

namespace PornStar
{
    class PornStar
    {
        Actress actress = new Actress();
     
        static void Main()
        {
            Console.WriteLine(actress);
        }

    }
}