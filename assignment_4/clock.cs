using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegate_1
{
    public class clock
    {
        static string set_time;
        private string time;
        public delegate void TickHandler(Object sender, TickEventArgs e);
        public event TickHandler Show_time;

        
        public class TickEventArgs : EventArgs
        {
            public readonly string Time;
            public TickEventArgs(string time)
            {
                Time = time;
            }
        }
        protected virtual void Alarm(TickEventArgs e)
        {
            if(Show_time != null)
            {
                Show_time(this, e);
            }
        }

        public void Tick()
        {
            while (true)
            {
                time = string.Format("{0:yyyy-MM-dd HH:mm:ss}", DateTime.Now);
                //TickEventArgs e = new TickEventArgs(time);
                //Alarm(e);

                if (time == set_time)
                {
                     TickEventArgs e = new TickEventArgs(time);
                    Alarm(e);
                }
            }
        }

        public class Shower
        {
            public void time(Object sender,clock.TickEventArgs e) {

                clock c = (clock)sender;
                Console.WriteLine("Time is {0} now. ", e.Time);
                Console.WriteLine();


            }
        }

        public class Alarmer
        {
            
            public static void Alarming(Object sender, clock.TickEventArgs e)
            {
                clock c = (clock)sender;
                for (int a = 0; a < 60; a++)
                    Console.WriteLine("Alarming!! Alarming!!");
                Console.WriteLine();
            }


        }
        public class Program
        {
            static void Main() {
                clock c = new clock();
                Shower s = new Shower();
                c.Show_time += s.time;
                c.Show_time += (new Shower()).time;
                c.Show_time += Alarmer.Alarming;

                c.Tick();

            }

        }


    }
}
