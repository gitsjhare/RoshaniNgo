using System.Collections.Generic;
using Roshani.data.model;
namespace Roshani.data.Contract{
    public interface IUsersDetailsData
    {
        IList<UserModel> GetUserDetails();
    }
}