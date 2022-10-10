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
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/ReadingrichTextBox1Input.htm
    public partial  class frmReadingrichTextBox1Input:Form
    {
        public frmReadingrichTextBox1Input()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmReadingrichTextBox1Input
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmReadingrichTextBox1Input";
            this.Text = "frmReadingrichTextBox1Input";
            this.Load += new System.EventHandler(this.frmReadingrichTextBox1Input_Load);
            this.ResumeLayout(false);

        }

        private void frmReadingrichTextBox1Input_Load(object sender, EventArgs e)
        {

        }
    }
}
