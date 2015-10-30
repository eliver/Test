using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funny
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Test");
        }

    }
	public class Box : IEqualityComparer<Box>
	{
		private int height;
		public bool Equals(Box b1, Box b2) => false;
		public int GetHashCode(Box b) => b.height; // <- no compiler error - bug? 
	}
	public class BoxComparer : IEqualityComparer<Box>
	{
		public bool Equals(Box b1, Box b2) => false;
	
	}

}
