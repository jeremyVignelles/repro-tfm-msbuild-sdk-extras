using System;

namespace TestTFM {
    public static class Program {
        public static void Main() {
            #if NET6_0
            Console.WriteLine("NET6_0");
            #endif

            #if NET6_0_OR_GREATER
            Console.WriteLine("NET6_0_OR_GREATER");
            #endif
        }
    }
}