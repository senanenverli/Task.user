using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class User
    {

        public int Id {  get; set; }
        public string Fullname { get; set; }
        public string Email { get; set; }
        public string Password {  get; set; }

        public bool PaswordChecker(string password)
        {
            
            for(int i = 0; i < Password.Length; i++)
            {
                if (password.Length >= 8 && char.IsUpper((char)i) && char.IsLower((char)i) && char.IsDigit((char)i))
                {
                    return true;
                }
                else
                {
                    return false;
                }
                
           
            }
            return false;
            
        }
        public void ShowInfo(string name, string email,int id)
        {
            Console.WriteLine($"{name }- { id} -{email }");
        }
 


    }
}
