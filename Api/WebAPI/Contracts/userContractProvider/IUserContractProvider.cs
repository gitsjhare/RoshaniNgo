
using System.Collections.Generic;
using Roshani.data.model;
namespace Roshani.Provider.Contract{
   public interface IUserDetailProvider
   {
       IList<UserModel> GetUserDetails();
   } 
}