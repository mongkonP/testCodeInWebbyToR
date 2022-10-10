using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0280__Development.C0060__richTextBox1_Output
{
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/richTextBox1IO.htm
    public partial  class frmrichTextBox1IO:Form
    {
        public frmrichTextBox1IO()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmrichTextBox1IO
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmrichTextBox1IO";
            this.Text = "frmrichTextBox1IO";
            this.Load += new System.EventHandler(this.frmrichTextBox1IO_Load);
            this.ResumeLayout(false);

        }

        private void frmrichTextBox1IO_Load(object sender, EventArgs e)
        {

        }
    }
}
