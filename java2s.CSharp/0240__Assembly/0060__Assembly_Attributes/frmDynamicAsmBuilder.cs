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
    //http://www.java2s.com/Tutorial/CSharp/0240__Assembly/DynamicAsmBuilder.htm
    public partial  class frmDynamicAsmBuilder:Form
    {
        public frmDynamicAsmBuilder()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDynamicAsmBuilder
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDynamicAsmBuilder";
            this.Text = "frmDynamicAsmBuilder";
            this.Load += new System.EventHandler(this.frmDynamicAsmBuilder_Load);
            this.ResumeLayout(false);

        }

        private void frmDynamicAsmBuilder_Load(object sender, EventArgs e)
        {

        }
    }
}
