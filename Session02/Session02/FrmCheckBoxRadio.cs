using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session02
{
    public partial class FrmCheckBoxRadio : Form
    {
        public FrmCheckBoxRadio()
        {
            InitializeComponent();
        }

        private void btnSelectCheckBox_Click(object sender, EventArgs e)
        {
            string result = "Bạn chọn:" + Environment.NewLine;
            if (chkGame.Checked)
                result += chkGame.Text + Environment.NewLine;
            if (chkShopping.Checked)
                result += chkShopping.Text + Environment.NewLine;
            if (chkSing.Checked)
                result += chkSing.Text + Environment.NewLine;
            if (chkSport.Checked)
                result += chkSport.Text + Environment.NewLine;
            MessageBox.Show(result);
        }

        private void btnRadio_Click(object sender, EventArgs e)
        {
            string result = "Bạn chọn:";
            if (rdoExcel.Checked)
                result += rdoExcel.Text;
            if (rdoWord.Checked)
                result += rdoWord.Text;
            if (rdoPdf.Checked)
                result += rdoPdf.Text;
            if (rdoText.Checked)
                result += rdoText.Text;
            MessageBox.Show(result);

        }

        private void btnChoosePicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofile = new OpenFileDialog();
            ofile.Filter = "Các tệp png|*png|Các tệp jpg|*.jpg";
            ofile.ShowDialog();
            if(ofile.FileName!=null)
            {
                ptAnh.Image = Image.FromFile(ofile.FileName);
            }
        }
    }
}
