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
    public partial class FrmUrunEklemeDuzenleme : Form
    {
        public FrmUrunEklemeDuzenleme()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            ProductRepository productRepository=new ProductRepository();
            productRepository.Add(new Product
            {
                
            });
        }
    }
}
