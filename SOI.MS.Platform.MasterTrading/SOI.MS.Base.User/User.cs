﻿namespace SOI.MS.Base.User
{
    public class User
    {
       
        #region  "  Constructor  "
        public User()
        {

        }
        #endregion


        #region "  Public Properties  "
       
        public int iduser { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string Status { get; set; }      
        #endregion
    }
}