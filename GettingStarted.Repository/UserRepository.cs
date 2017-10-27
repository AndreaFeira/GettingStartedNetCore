using GettingStarted.Entities;
using GettingStarted.Repository.Interfaces;
using System;
using System.Collections.Generic;

namespace GettingStarted.Repository
{
    public class UserRepository : BaseRepository , IUserRepository
    {
        public bool AddUser(User user)
        {
            try
            {
                //DynamicParameters parameters = new DynamicParameters();
                //parameters.Add("@UserName", user.UserName);
                //parameters.Add("@UserMobile", user.UserMobile);
                //parameters.Add("@UserEmail", user.UserEmail);
                //parameters.Add("@FaceBookUrl", user.FaceBookUrl);
                //parameters.Add("@LinkedInUrl", user.LinkedInUrl);
                //parameters.Add("@TwitterUrl", user.TwitterUrl);
                //parameters.Add("@PersonalWebUrl", user.PersonalWebUrl);
                //SqlMapper.Execute(con, "AddUser", param parameters, commandType StoredProcedure);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool DeleteUser(int userId)
        {
            //DynamicParameters parameters = new DynamicParameters();
            //parameters.Add("@UserId", userId);
            //SqlMapper.Execute(con, "DeleteUser", param parameters, commandType StoredProcedure);
            return true;
        }
        public IList<User> GetAllUser()
        {
            #region FakeClass for test purpose
            User u1 = new User();
            u1.UserId = 1;
            u1.UserName = "Ciccio";
            User u2 = new User();
            u2.UserId = 2;
            u2.UserName = "Pasticcio";
            #endregion

            IList<User> customerList = new List<User>();
            customerList.Add(u1);
            customerList.Add(u2);

            return customerList;
        }
        public User GetUserById(int userId)
        {
            #region FakeClass for test purpose
            User u1 = new User();
            u1.UserId = 1;
            u1.UserName = "Ciccio";
            #endregion

            return u1;
        }
        public bool UpdateUser(User user)
        {
            return true;
        }
    }
}
