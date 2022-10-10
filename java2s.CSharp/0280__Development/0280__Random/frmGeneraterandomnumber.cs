using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0280__Development.C0280__Random
{
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/Generaterandomnumber.htm
    public partial  class frmGeneraterandomnumber:Form
    {
        public frmGeneraterandomnumber()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGeneraterandomnumber
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGeneraterandomnumber";
            this.Text = "frmGeneraterandomnumber";
            this.Load += new System.EventHandler(this.frmGeneraterandomnumber_Load);
            this.ResumeLayout(false);

        }

        private void frmGeneraterandomnumber_Load(object sender, EventArgs e)
        {

        }
    }
}
