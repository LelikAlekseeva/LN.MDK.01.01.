using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database
{
    public partial class AddForm: Form
    {
        PgUsersLoader loader_;

        public AddForm(PgUsersLoader loader)
        {
            InitializeComponent();
            loader_ = loader;
        }

        internal void SetUser(User selectedUser)
        {
            throw new NotImplementedException();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            User user = new User
            {
                Login = textBoxLogin.Text,
                Password = textBoxPassword.Text,
                Last_Name = textBoxLastname.Text,
                Name = textBoxName.Text,
                Phone = textBoxTelefon.Text,
                Email = textBoxEmail.Text,
            };
            loader_.AddUser(user);
            this.Close();
        }
    }
}
