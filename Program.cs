using DogDoorApp.Models;

namespace DogDoorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DogDoor door = new DogDoor();
            //create a new instance of the remote class passing the DogDoor instance to its constructor
            Remote remote = new Remote(door);

            Console.WriteLine("Fido barks to go outside...");
            //press the remote button to open the dog door
            remote.PressButton();
            Console.WriteLine("Fido has gone outside");
            //press the remote button to close the dog door
            remote.PressButton();
            Console.WriteLine("Fido has finished its work");
            //press the remote button to open the dog door again
            remote.PressButton();
            Console.WriteLine("Fido is back inside");
            //press the remote button to close the dog door
            remote.PressButton();
        }
    }
}
