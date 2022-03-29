// See https://aka.ms/new-console-template for more information
using Smoogle;
using Smoogle.Commands;
Console.WriteLine("Hello, World!");

//Laver en controller med 2 af hver knap
SmoogleController sc = new SmoogleController(2);

Light myLight = new Light();
LightOnCommand lightOnCommand = new LightOnCommand(myLight);
LightOffCommand lightOffCommand = new LightOffCommand(myLight);
sc.setCommand(0, lightOnCommand, lightOffCommand);

Blinds myBlinds = new Blinds();
BlindsDownCommand blindsDownCommand = new BlindsDownCommand(myBlinds);
BlindsUpCommand blindsUpCommand = new BlindsUpCommand(myBlinds);

sc.setCommand(1, blindsDownCommand, blindsUpCommand);

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