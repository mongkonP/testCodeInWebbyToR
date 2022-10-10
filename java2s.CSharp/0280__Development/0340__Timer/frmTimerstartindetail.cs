using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0280__Development.C0340__Timer
{
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/Timerstartindetail.htm
    public partial  class frmTimerstartindetail:Form
    {
        public frmTimerstartindetail()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmTimerstartindetail
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmTimerstartindetail";
            this.Text = "frmTimerstartindetail";
            this.Load += new System.EventHandler(this.frmTimerstartindetail_Load);
            this.ResumeLayout(false);

        }

        private void frmTimerstartindetail_Load(object sender, EventArgs e)
        {

        }
    }
}
