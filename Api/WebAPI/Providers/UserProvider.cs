using System.Collections.Generic;
using Roshani.data.Contract;
using Roshani.data.model;
using Roshani.Provider.Contract;

namespace Roshani.Provider.User{
    public class UserDetailProvider : IUserDetailProvider
    {
        IUsersDetailsData userdto;
        public UserDetailProvider(IUsersDetailsData _userdto){
            userdto=_userdto;
        }
        public IList<UserModel> GetUserDetails()
        {
            return userdto.GetUserDetails();
        }
    }
}