using System;
using System.Collections.Generic;
using System.Text;

namespace call
{
    public class GenerateUserpass
    {
        public GenerateUserpass()
        {
                
        }

        public  string getAuthorizationValue(string Username, string Password)
        {
            return $"Basic {base64Encode($"{Username}:{Password}")}";
        }


        private string base64Encode(string what)
        {
            return Convert.ToBase64String(System.Text.Encoding.ASCII.GetBytes(what));
        }
    }
}
