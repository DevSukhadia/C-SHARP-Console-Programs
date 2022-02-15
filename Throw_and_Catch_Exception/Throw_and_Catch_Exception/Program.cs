using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Throw_and_Catch_Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Program Foobar = new Program();
                Methodone();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally { //cleanup code
                Console.WriteLine("In finally of Main.");
            }
        }
        static void Methodone()
        {
            try
            {
                Methodtwo();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            { //cleanup code
                Console.WriteLine("In finally of Methoddone.");
            }
        }
        static void Methodtwo()
        {
            throw new Exception("Excception thrown in method two");
        }

    }
}
