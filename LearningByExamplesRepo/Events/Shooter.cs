using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Events
{
    /// <summary>
    /// Publisher which will trigger the event
    /// </summary>
    public class Shooter
    {
        private Random rng = new Random();

        //public delegate void ShootingHandler(object sender, ShotsFiredEventArgs e);
        //public event ShootingHandler ShotsFired;

        //use this instead of the previous 2 lines
        public event EventHandler<ShotsFiredEventArgs> ShotsFired;

        public string Name { get; set; } = "Billy";

        public void OnShoot()
        {
            while (true)
            {
                if(rng.Next(0,100) %2 == 0)
                {
                     //Shooter class is raising the event -> this
                     ShotsFired?.Invoke(this, new ShotsFiredEventArgs());
                }
                else
                {
                    Console.WriteLine("I missed");
                }

                Thread.Sleep(500);
            }
        }
    }
}
