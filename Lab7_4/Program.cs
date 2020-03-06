using System;
using System.Collections.Generic;
using System.Text;

namespace Lab7_4
{
    class Program
    {
        static void Main(string[] args)
        {
            DatingProfile Lisa = new DatingProfile("Lisa", "Rolfe", 55, "Female");
            Lisa.WriteBio("I love dogs.");

            DatingProfile Kurt = new DatingProfile("Kurt", "Kutschke", 58, "Male");
            Kurt.WriteBio("I drive a corvette.");

            Kurt.SendMessage("Hey Lisa", "Do you like weiner dogs?", Lisa);
            Lisa.ReadMessage();
        }
    }
    
}
