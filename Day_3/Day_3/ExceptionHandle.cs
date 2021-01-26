using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;

namespace Day_3
{
    class ExceptionHandle
    {
        public string fileRead(string filePath)
        {
            StreamReader streamReader = null;
            string val;
            try
            {
                streamReader = new StreamReader(filePath);
                val = streamReader.ReadToEnd();
                return val;

            }
            catch (FileNotFoundException ex)
            {
                return ex.Message;
                //return ex.StackTrace;

            }
            catch (Exception ex)
            {

                return ex.Message;
            }
            finally {
                if (streamReader!=null)
                {
                    streamReader.Close();
                }
                Console.WriteLine("Finally Block executed");
 
                
            }

        }

        public void caculation(string filePath) 
        {
            try
            {

                try
                {
                    Console.WriteLine("Enter First Value: ");
                    int a = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter Second Value: ");
                    int b = Convert.ToInt32(Console.ReadLine());

                    int result = a / b;
                    Console.WriteLine("Result : {0}",result);
                }
                catch (Exception ex)
                {
                    if (File.Exists(filePath))
                    {
                        StreamWriter streamWriter = new StreamWriter(filePath);
                        streamWriter.Write(ex.GetType().Name);
                        streamWriter.WriteLine();
                        streamWriter.Write(ex.Message);
                        streamWriter.Close();

                    }
                    else
                    {
                        throw new FileNotFoundException(filePath + " is not found", ex);
                    }
                    Console.WriteLine("Exception block");
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine("Current Exception: "+exception.Message);
                if (exception.InnerException!=null)
                {
                    Console.WriteLine("Inner Exception: " + exception.InnerException.Message);
                }
            }
        }
    }


    [Serializable]
    class UserAlreayLoggedIn : Exception
    {
        /// <summary>
        ///  constructor overloadding with custom excetion
        /// </summary>
        public UserAlreayLoggedIn() : base()
        {
            
        }
        public UserAlreayLoggedIn(string message) : base(message)
        { 

        }
        public UserAlreayLoggedIn(string message, Exception innterException) : base(message, innterException)
        { 

        }
        public UserAlreayLoggedIn(SerializationInfo info, StreamingContext context) : base(info, context)
        {
            
        }
    }
}
