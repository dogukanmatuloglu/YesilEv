using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YesilEv.Core.Entities.Concrete;
using YesilEv.Dal.Repositories.Concrete;

namespace YesilEv.WinForm
{
    public partial class FrmLoginRegisterForm : Form
    {
        public FrmLoginRegisterForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserRepository userRepository =new UserRepository();
          bool isLogin=  userRepository.Login(tbxEmail.Text,tbxPassword.Text);
            if (isLogin)
            {
                MessageBox.Show("Başarılı Giriş");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }
    }
}
