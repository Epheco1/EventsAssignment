using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegateAssign
{
    internal class FireAlarmSystem  //publisher
    {
        public delegate void NotifyHandler();
        public event NotifyHandler AlertOtherClasses;

        public void FireDetection()
        {
            Console.WriteLine("Fire incident detection in progress");
            OnFireIncidentDetected();
        }
        protected virtual void OnFireIncidentDetected()
        {
            AlertOtherClasses?.Invoke();
        }
    }

        public class FireDetector  //subscriber
        {
            public void ActOnFireIncident()
            {
                var fireAlarm = new FireAlarmSystem();
                fireAlarm.AlertOtherClasses += FireDetectionAction;
                fireAlarm.FireDetection();
            }
            public void FireDetectionAction()
            {
                Console.WriteLine("Raise alarm to fire incident resolution unit");
                Console.ReadLine();
            }

        }
    }
}
