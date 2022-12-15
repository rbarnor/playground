Console.WriteLine("Hello Welcome to the Pet Store!");

Console.WriteLine("How many can would you like to purchase?" + " ");

 var user_input = Console.ReadLine();

int number_of_cans = int.Parse(user_input);


Console.WriteLine($"The price for the {number_of_cans} cans you want is GH₵{number_of_cans * 2}");