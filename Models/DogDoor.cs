namespace DogDoorApp.Models
{
    internal class DogDoor
    {
        //property to indicate whether the dog door is open or not
        public bool isOpen { get; set; }

        public DogDoor()
        {
            //this means that the door is closed when a new DogDoor object is created
            isOpen = false;
        }

        //it sets the isOpen property to true to indicate that the door has been opened
        public void open()
        {
            isOpen = true;
            Console.WriteLine("\nThe dog door opens...");
        }

        //it sets the isOpen to false to indicate that the door has been closed
        public void close()
        {
            isOpen = false;
            Console.WriteLine("\nThe dog door closes...");
        }
    }
}
