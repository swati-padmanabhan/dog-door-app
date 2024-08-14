using System.Timers;

namespace DogDoorApp.Models
{
    internal class Remote
    {
        //this will allow the remote to control the DogDoor
        private DogDoor _door;

        //this is the timer that will help to automatically close the door after 7 seconds
        private System.Timers.Timer _timer;

        public Remote(DogDoor door)
        {
            _door = door;
            //initialize the timer to 7 secs
            _timer = new System.Timers.Timer(7000);
            //when time finishes, the method is called
            _timer.Elapsed += TimerElapsedCloseDoor;
        }

        public void PressButton()
        {
            Console.WriteLine("\nPressing the Remote Control Button...");

            //check if the dog door is currently open
            if (_door.isOpen)
                //if the door is open, call the close method on the DogDoor object to close it
                _door.close();
            else
            {
                //if the door is closed, call the open method on the DogDoor to open it
                _door.open();
                //start the timer to auto close the door
                _timer.Start();
            }
        }


        //this method is called when the timer times up
        private void TimerElapsedCloseDoor(object sender, ElapsedEventArgs e)
        {
            //close the door
            _door.close();

            //stop the timer
            _timer.Stop();
        }
    }
}
