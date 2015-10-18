/*
 * creating classes: http://www.csharp-station.com/Tutorial/CSharp/Lesson07
 * inheritance: http://www.csharp-station.com/Tutorial/CSharp/Lesson08
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CORS_Analyser
{
    class User
    {

        //String userID;
        //String password;

        protected String userID { get; set; }
        protected string password { get; set; }

        public User(String id, String pw)
        {
            userID = id;
            password = pw;
        }
        /* set using properties
        public String getID()
        {
            return userID;
        }

        public String getPassword()
        {
            return password;
        }*/
        
        /*Missing destructor?*/
    }
    
}
