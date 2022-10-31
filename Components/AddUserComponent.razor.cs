using Microsoft.AspNetCore.Components;
using VSRPP_labs.Infrastructure;

namespace VSRPP_labs.Components
{
    public partial class AddUserComponent : ComponentBase
    {
        //[Parameter] public List<UserItem> UserList { get; set; }
        private IList<UserItem> users = new List<UserItem>();

        private string newUserName;

        private string newUserEmail;

        private string newUserLastName;

        private UserItem User = new();

        private int LastID()
        {
            if (users.Count == 0)
            {
                return 1;
            }
            else
            {
                return (users.Last().UserId + 1);
            }
        }

        private void AddUser()
        {
            if (!string.IsNullOrWhiteSpace(newUserName) && !string.IsNullOrWhiteSpace(newUserEmail) && !string.IsNullOrWhiteSpace(newUserLastName))
            {
                users.Add(new UserItem{UserEmail = newUserEmail ,UserName = newUserName, UserId = (LastID()),UserLastName = newUserLastName});

            }
        }

        private void DeleteUser(UserItem deletedUserItem)
        {
            users.Remove(deletedUserItem);
        }
    }
}
