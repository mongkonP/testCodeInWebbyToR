using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0240__Assembly.C0060__Assembly_Attributes
{
    //http://www.java2s.com/Tutorial/CSharp/0240__Assembly/Setassemblyattributes.htm
    public partial  class frmSetassemblyattributes:Form
    {
        public frmSetassemblyattributes()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSetassemblyattributes
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSetassemblyattributes";
            this.Text = "frmSetassemblyattributes";
            this.Load += new System.EventHandler(this.frmSetassemblyattributes_Load);
            this.ResumeLayout(false);

        }

        private void frmSetassemblyattributes_Load(object sender, EventArgs e)
        {

        }
    }
}
