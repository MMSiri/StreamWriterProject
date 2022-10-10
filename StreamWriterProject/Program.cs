using System;
using System.IO;

namespace StreamWriterProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var sw = new StreamWriter("secret_plan.txt");

            sw.WriteLine("How I'll defeat Captain Amazing");
            sw.WriteLine("Another genius plan by The Swindler");
            sw.WriteLine("I'll unleash my army of clones upon the citizens of Objectville.");

            var location = "the mall";

            for (int number = 1; number <= 5; number++)
            {
                sw.WriteLine("Clone #{0} attacks {1}", number, location);
                location = (location == "the mall") ? "downtown" : "the mall";
            }
            sw.Close();

            Flobbo f = new Flobbo("blue yellow");
            StreamWriter SW = f.Snobbo();
            f.Blobbo(f.Blobbo(f.Blobbo(SW), SW), SW);
        }

        public class Flobbo
        {
            private string zap;
            public Flobbo(string zap)
            {
                this.zap = zap;
            }
            public StreamWriter Snobbo()
            {
                return new
                 StreamWriter("macaw.txt");

            }

            public bool Blobbo(StreamWriter sw)
            {
                sw.WriteLine(zap);
                zap = "green purple";
                return false;
            }

            public bool Blobbo(bool Already, StreamWriter sw)
            {
                if (Already)
                {
                    sw.WriteLine(zap);
                    sw.Close();
                    return false;
                }
                else
                {
                    sw.WriteLine(zap);
                    zap = "red orange";
                    return true;
                }
            }
        }

    }
}
