// Console.WriteLine("Hello Welcome to the Pet Store!");

// Console.WriteLine("How many can would you like to purchase?" + " ");

// var user_input = Console.ReadLine();

// int number_of_cans = int.Parse(user_input);


// Console.WriteLine($"The price for the {number_of_cans} cans you want is GH₵{number_of_cans * 2}");

class Actress
{
    public string name;
    public int age;
    public string ethnic;
    public bool is_fav;

    public Actress(string name, int age, string ethnic){
        this.name = name;
        this.age =age;
        this.ethnic = ethnic;
    
    }

}


namespace PornStar
{
    class PornStar
    {

        static void Main()
        {
            Actress actress = new Actress("Kira Noir", 21, "black");
            Console.WriteLine(actress.name);
        }

    }
}