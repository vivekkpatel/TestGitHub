using System;

namespace ConsoleAppTest
{
    internal static class Program
    {
        private static void Main()
        {
            try
            {
                Console.WriteLine("Hello World");
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}