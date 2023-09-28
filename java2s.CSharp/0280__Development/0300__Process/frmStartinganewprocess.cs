using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0280__Development.C0300__Process
{
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/Startinganewprocess.htm
    public partial  class frmStartinganewprocess:Form
    {
        public frmStartinganewprocess()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmStartinganewprocess
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmStartinganewprocess";
            this.Text = "frmStartinganewprocess";
            this.Load += new System.EventHandler(this.frmStartinganewprocess_Load);
            this.ResumeLayout(false);

        }

        private void frmStartinganewprocess_Load(object sender, EventArgs e)
        {

        }
    }
}
