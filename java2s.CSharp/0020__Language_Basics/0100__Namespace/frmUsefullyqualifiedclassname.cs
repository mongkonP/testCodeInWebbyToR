using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0020__Language_Basics.C0100__Namespace
{
    //http://www.java2s.com/Tutorial/CSharp/0020__Language-Basics/Usefullyqualifiedclassname.htm
    public partial  class frmUsefullyqualifiedclassname:Form
    {
        public frmUsefullyqualifiedclassname()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsefullyqualifiedclassname
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsefullyqualifiedclassname";
            this.Text = "frmUsefullyqualifiedclassname";
            this.Load += new System.EventHandler(this.frmUsefullyqualifiedclassname_Load);
            this.ResumeLayout(false);

        }

        private void frmUsefullyqualifiedclassname_Load(object sender, EventArgs e)
        {

        }
    }
}
