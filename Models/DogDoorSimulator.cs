namespace DogDoorApp.Models
{
    internal class DogDoorSimulator
    {
        public static void TestDogDoor(int dogOutsideTime)
        {
            DogDoor door = new DogDoor();
            Remote remote = new Remote(door);

            Console.WriteLine("\nFido barks to go outside...");
            remote.PressButton();

            Console.WriteLine("\nFido has gone outside for " + dogOutsideTime / 1000 + " seconds...");
            //pause the program for the specified time
            System.Threading.Thread.Sleep(dogOutsideTime);
            Console.WriteLine("\nFido is all done...");


            Console.WriteLine("\n...But he is stuck outside!");
            Console.WriteLine("\nFido starts barking...");
            Console.WriteLine("\nSo Gina grabs the remote control...");
            remote.PressButton();

            Console.WriteLine("\nFido is back inside...");

            while (door.isOpen)
            {
            }
            Console.WriteLine("\nTesting done...");
        }
    }
}
