using System;

namespace Generic
{
    internal class Program
    {
        public class sample<P>
        {
            //field
            private P data;

            //property
            public P value
            {
                //accessors
                get
                {
                    return this.data;
                }
                set
                {
                    this.data = value;
                }

            }

        }
        static void Main(string[] args)
        {

            sample<string> name = new sample<string>();
            name.value = "Pavani";

            sample<float> version = new sample<float>();
            version.value = 6.0F;

            sample<int> count = new sample<int>();
            count.value = 84;
            //display Name
            Console.WriteLine(name.value);
            //display version
            Console.WriteLine(version.value);
            //display count
            Console.WriteLine(count.value);
        }
    }
}