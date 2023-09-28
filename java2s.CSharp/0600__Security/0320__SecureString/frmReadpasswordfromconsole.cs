using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0600__Security.C0320__SecureString
{
    //http://www.java2s.com/Tutorial/CSharp/0600__Security/ReadpasswordfromrichTextBox1.htm
    public partial  class frmReadpasswordfromrichTextBox1:Form
    {
        public frmReadpasswordfromrichTextBox1()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmReadpasswordfromrichTextBox1
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmReadpasswordfromrichTextBox1";
            this.Text = "frmReadpasswordfromrichTextBox1";
            this.Load += new System.EventHandler(this.frmReadpasswordfromrichTextBox1_Load);
            this.ResumeLayout(false);

        }

        private void frmReadpasswordfromrichTextBox1_Load(object sender, EventArgs e)
        {

        }
    }
}
