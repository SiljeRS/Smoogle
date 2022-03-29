// See https://aka.ms/new-console-template for more information
using Smoogle;
using Smoogle.Commands;
Console.WriteLine("Hello, World!");

//Laver en controller med 3 af hver knap
SmoogleController sc = new SmoogleController(3);

//Laver en instans af Light
Light myLight = new Light();
//Medgiver myLight i parameteren af on og of command for light
LightOnCommand lightOnCommand = new LightOnCommand(myLight);
LightOffCommand lightOffCommand = new LightOffCommand(myLight);
//Tilknytter de to kommandoer til index 0 på controlleren
sc.setCommand(0, lightOnCommand, lightOffCommand);

//Laver en instans af Blinds
Blinds myBlinds = new Blinds();
//Medgiver myBlinds i parameteren for up og down kommandoerne for Blinds
BlindsDownCommand blindsDownCommand = new BlindsDownCommand(myBlinds);
BlindsUpCommand blindsUpCommand = new BlindsUpCommand(myBlinds);
//Tilknytter de to kommandoer til index 1 på controlleren
sc.setCommand(1, blindsDownCommand, blindsUpCommand);

//Laver en instans af Coffee med 100 beans
Coffee myCoffee = new Coffee(100);
//Medgiver myCoffee i parameteren for MakeCoffeeCommand og CleanCoffeeMachineCommand
MakeCoffeeCommand makeCoffeeCommand = new MakeCoffeeCommand(myCoffee);
CleanCoffeeMachineCommand cleanCoffeeMachineCommand = new CleanCoffeeMachineCommand(myCoffee);
//Tilknytter de to kommandoer til index 2 på controlleren
sc.setCommand(2, makeCoffeeCommand, cleanCoffeeMachineCommand);

string input = "";
string number = "";
int intNumber = 0;

while(input != "e")
{
    Console.WriteLine("");
    Console.WriteLine("Press key: e(Exit), f(off button), n(on button): ");
    input = Console.ReadLine();
    switch (input)
    {
        case "e":
            break;

        case "f":
            Console.Write("Write off button number: ");
            number = Console.ReadLine();
            intNumber = Int16.Parse(number);
            sc.offButtonWasPushed(intNumber);
            break;

        case "n":
            Console.Write("Write on button number: ");
            number = Console.ReadLine();
            intNumber = Int16.Parse(number);
            sc.onButtonWasPushed(intNumber);
            break;

        default:
            Console.WriteLine("Wrong letter");
            break;
    }
}