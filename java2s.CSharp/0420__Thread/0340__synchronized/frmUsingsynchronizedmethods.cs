using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0420__Thread.C0340__synchronized
{
    //http://www.java2s.com/Tutorial/CSharp/0420__Thread/Usingsynchronizedmethods.htm
    public partial  class frmUsingsynchronizedmethods:Form
    {
        public frmUsingsynchronizedmethods()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsingsynchronizedmethods
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsingsynchronizedmethods";
            this.Text = "frmUsingsynchronizedmethods";
            this.Load += new System.EventHandler(this.frmUsingsynchronizedmethods_Load);
            this.ResumeLayout(false);

        }

        private void frmUsingsynchronizedmethods_Load(object sender, EventArgs e)
        {

        }
    }
}
