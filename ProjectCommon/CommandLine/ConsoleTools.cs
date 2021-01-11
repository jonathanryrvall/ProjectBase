using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectCommon.CommandLine
{
    /// <summary>
    /// Outputs formatted stuff to console
    /// </summary>
    public class ConsoleTools
    {
        /// <summary>
        /// Prompt user to enter y/n
        /// </summary>
        public virtual bool GetYesNo()
        {
            while (true)
            {
                Console.Write(">");
                string response = Console.ReadLine();

                // User didnt like this!
                if (response == "n" ||
                    response == "N")
                {
                    return false;
                }

                // User confirms!
                if (response == "y" ||
                    response == "Y")
                {
                    return true;
                }
            }
        }

        /// <summary>
        /// Print a property to console
        /// </summary>
        public virtual void PrintProperty(string propertyName, string value)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("[" + propertyName + "] ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(value);
        }

        /// <summary>
        /// Write a message to console with a timestamp
        /// </summary>
        public virtual void WriteSimpleMessageWithTimestamp(string message, ConsoleColor color = ConsoleColor.White)
        {
            // Output timestamp
            WriteTimestamp();

            // Write message
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }

        /// <summary>
        /// Write the current timestamp
        /// </summary>
        public virtual void WriteTimestamp()
        {
            string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"[{timestamp}] ");
            Console.ForegroundColor = ConsoleColor.White;
        }

       
    }
}
