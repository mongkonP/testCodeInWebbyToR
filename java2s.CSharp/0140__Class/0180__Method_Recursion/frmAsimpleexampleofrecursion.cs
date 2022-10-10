using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0180__Method_Recursion
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/Asimpleexampleofrecursion.htm
    public partial  class frmAsimpleexampleofrecursion:Form
    {
        public frmAsimpleexampleofrecursion()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAsimpleexampleofrecursion
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAsimpleexampleofrecursion";
            this.Text = "frmAsimpleexampleofrecursion";
            this.Load += new System.EventHandler(this.frmAsimpleexampleofrecursion_Load);
            this.ResumeLayout(false);

        }

        private void frmAsimpleexampleofrecursion_Load(object sender, EventArgs e)
        {

        }
    }
}
