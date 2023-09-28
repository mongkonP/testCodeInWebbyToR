using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0280__Development.C0360__GC
{
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/Displaycurrentgenerations.htm
    public partial  class frmDisplaycurrentgenerations:Form
    {
        public frmDisplaycurrentgenerations()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDisplaycurrentgenerations
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDisplaycurrentgenerations";
            this.Text = "frmDisplaycurrentgenerations";
            this.Load += new System.EventHandler(this.frmDisplaycurrentgenerations_Load);
            this.ResumeLayout(false);

        }

        private void frmDisplaycurrentgenerations_Load(object sender, EventArgs e)
        {

        }
    }
}
