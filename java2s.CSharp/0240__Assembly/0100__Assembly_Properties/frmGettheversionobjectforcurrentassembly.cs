using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0240__Assembly.C0100__Assembly_Properties
{
    //http://www.java2s.com/Tutorial/CSharp/0240__Assembly/Gettheversionobjectforcurrentassembly.htm
    public partial  class frmGettheversionobjectforcurrentassembly:Form
    {
        public frmGettheversionobjectforcurrentassembly()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGettheversionobjectforcurrentassembly
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGettheversionobjectforcurrentassembly";
            this.Text = "frmGettheversionobjectforcurrentassembly";
            this.Load += new System.EventHandler(this.frmGettheversionobjectforcurrentassembly_Load);
            this.ResumeLayout(false);

        }

        private void frmGettheversionobjectforcurrentassembly_Load(object sender, EventArgs e)
        {

        }
    }
}
