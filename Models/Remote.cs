namespace DogDoorApp.Models
{
    internal class Remote
    {
        //this will allow the remote to control the DogDoor
        private DogDoor _door;


        public Remote(DogDoor door)
        {
            _door = door;
        }

        public void PressButton()
        {
            Console.WriteLine("Pressing the Remote Control Button...");
            //check if the dog door is currently open
            if (_door.isOpen)
                //if the door is open, call the close method on the DogDoor object to close it
                _door.close();
            else
                //if the door is closed, call the open method on the DogDoor to open it
                _door.open();
        }

    }
}
