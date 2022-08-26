using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    /// <summary>
    /// Events: when something is happend, the event is fired and it executes some code. 
    /// The object that hold the event is publisher.
    /// The methods that are added to that events are subscribers (respond to the event)
    /// The subscriber (EntryPoint) doesn't know anything about the publisher (Shooter) - no code mix between two, only the possibility to subscribe for the event
    /// </summary>
    class EntryPoint
    {

        private static int score = 0;

        static void Main(string[] args)
        {
            var shooter = new Shooter();
            //Subscribe to the KillingCompleted event and call the KilledEnemy and AddScore of the subscriber.
            shooter.ShotsFired += KilledEnemy;
            shooter.ShotsFired += AddScore;

            shooter.OnShoot();

        }

        public static void KilledEnemy(object sender, ShotsFiredEventArgs e)
        {
            var tempSender = sender as Shooter;

            Console.WriteLine($"I am {tempSender.Name} and killed an enemy! My Score is: { score} ");
            Console.WriteLine($"Date: {e.TimeOfKill.ToString("MM.dd.yyyy hh:mm:ss")}");
        }

        //When we kill enemy, add the score
        public static void AddScore(object sender, EventArgs e)
        {
            score += 1;
        }

    }
}
