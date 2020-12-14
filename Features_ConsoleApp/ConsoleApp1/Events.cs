using System;
using System.Collections.Generic;

namespace Features_ConsoleApp.Events
{
    class Event
    {
        // Declare an events with delegate type that handler function will match.
        public event EventHandler myEvent;
 
        // Event handler function that must match EventHandler (or any other delegate assigned to an event) delegate signature
        public void handleMyEvent(object sender, EventArgs eventArgs)
        {
            Console.WriteLine("I am an event handler, yeay!");
        }

        // Functions can be added or removed as event handlers, there can also be multiple event handler functions
        public void handleMyEvent2(object sender, EventArgs eventArgs)
        {
            Console.WriteLine("I am a second event handler, yeay more");
        }

        // helper function that checks if any handler function is assigned to an event/delegate and raises the event
        public void onMyEvent()
        {
            if (myEvent != null)
            {
                myEvent(this, EventArgs.Empty);
            }
        }

        public event Action<string> myStringEvent;

        public void handleMyStringEvent(string param)
        {
            Console.WriteLine(param);
        }

        public void demonstrate()
        {
            myEvent += handleMyEvent;
            onMyEvent();

            myEvent += handleMyEvent2;
            onMyEvent();

            myStringEvent += handleMyStringEvent;
            myStringEvent("I AM A PARAMETER Yeay the most!");
        }
    }
}