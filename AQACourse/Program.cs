using System;
using System.Diagnostics;

namespace  assert_sim
{
   static class Program
    {
        public static void Main() {
            int val = 1;
            Debug.Assert(val != 1, "Value should not be 2");
            string name = "Anastasiia";
        }
    }
}
