using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthForm
{
    public class User
    {
        public static User localuser;

        public int idUsers;
        public string Login, Password;
        public int Passport_seria, Passport_num;
        public DateTime Birth;
        public Role Role;

        

        public static string GetRoleName(Role role)
        {
            switch (role)
            {
                case AuthForm.Role.admin:
                    return "Администратор";
                case AuthForm.Role.employee:
                    return "Сотрудник";
                case AuthForm.Role.client:
                    return "Клиент";
                default:
                    return "";
            }
        }

        public User(DataRow row)
        {
            idUsers = Convert.ToInt32(row["idUsers"]);
            Login = Convert.ToString(row["Login"]);
            Password = Convert.ToString(row["Password"]);
            Passport_seria = Convert.ToInt32(row["Passport_seria"]);
            Passport_num = Convert.ToInt32(row["Passport_num"]);
            Birth = Convert.ToDateTime(row["Birth"]);
            Role = (Role)Convert.ToInt32(row["Role"]);
        }
    }

    public enum Role
    {
        admin = 0,
        employee = 1,
        client = 2
    }
}
