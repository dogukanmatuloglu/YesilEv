using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YesilEv.Dal.Repositories.Concrete;

namespace YesilEv.WinForm
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserRepository userRepository = new UserRepository();
            userRepository.Add(new Core.Entities.Concrete.User { FirstName = tbxAd.Text, LastName = tbxSoyad.Text, Email = tbxSoyad.Text, Password = tbxSoyad.Text ,CreatedDate=DateTime.Now,ModifiedDate=DateTime.Now,CreatedBy=1,ModifiedBy=1,IsActive=true,RoleId=1});
        }
    }
}
