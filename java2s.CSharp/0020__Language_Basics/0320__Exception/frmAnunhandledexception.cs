using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0020__Language_Basics.C0320__Exception
{
    //http://www.java2s.com/Tutorial/CSharp/0020__Language-Basics/Anunhandledexception.htm
    public partial  class frmAnunhandledexception:Form
    {
        public frmAnunhandledexception()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAnunhandledexception
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAnunhandledexception";
            this.Text = "frmAnunhandledexception";
            this.Load += new System.EventHandler(this.frmAnunhandledexception_Load);
            this.ResumeLayout(false);

        }

        private void frmAnunhandledexception_Load(object sender, EventArgs e)
        {

        }
    }
}
