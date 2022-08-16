using System;

namespace EventsAndDelegateAssign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FireDetector firedetect = new FireDetector();
            firedetect.ActOnFireIncident();
        }
    }
}