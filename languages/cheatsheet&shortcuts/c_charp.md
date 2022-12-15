## PRINTING OUT INFO
```
Console.WriteLine("Hello World")
```

## ACCEPTING INPUT

```
Console.ReadLine()

//Accepting input into a variable
string input = Console.ReadLine()
```

## VARIABLE and DECLARATIONS 
```
Method 1:
var name = "Ransben";

Method2:
int age = 32;
string name = "Ransben";

```

## STRINGS
#### STRING INTERPOLATION
```
string name = "Mark";
var date = DateTime.Now;

// Composite formatting:
Console.WriteLine("Hello, {0}! Today is {1}, it's {2:HH:mm} now.", name, date.DayOfWeek, date);

// String interpolation:
Console.WriteLine($"Hello, {name}! Today is {date.DayOfWeek}, it's {date:HH:mm} now.");
```

## METHODS / FUNCTIONS
```
FUNCTION1:
// A function that accepts parameters and returns a value
static string Namer(string firstname, string surname)
{
    Console.WriteLine("What is your firstname");
    firstname = Console.ReadLine();
    Console.WriteLine("What is your surname");
    surname = Console.ReadLine();

    return firstname + surname;
   // Console.WriteLine(firstname+surname);
}


FUNCTION 2:
//A function that accepts parameter but doesnt return a value

static void Namer(string firstname, string surname)
{
    Console.WriteLine("What is your firstname");
    firstname = Console.ReadLine();
    Console.WriteLine("What is your surname");
    surname = Console.ReadLine();
    Console.WriteLine(firstname+surname);
}

```

## PARSING 
#### INT TO STRING
```

```


### FLOAT TO INT
```
int age = (int)12.75

```

### NUMBER STRING TO INT
```
int userage =  int.Parse("12")
```