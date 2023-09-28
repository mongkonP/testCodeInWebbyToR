using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0280__Development.C0120__richTextBox1_Read
{
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/ReadinputfromrichTextBox1.htm
    public partial  class frmReadinputfromrichTextBox1:Form
    {
        public frmReadinputfromrichTextBox1()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmReadinputfromrichTextBox1
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmReadinputfromrichTextBox1";
            this.Text = "frmReadinputfromrichTextBox1";
            this.Load += new System.EventHandler(this.frmReadinputfromrichTextBox1_Load);
            this.ResumeLayout(false);

        }

        private void frmReadinputfromrichTextBox1_Load(object sender, EventArgs e)
        {

        }
    }
}
