using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0020__Class_Definition
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/Implementmultipleinterfaces.htm
    public partial  class frmImplementmultipleinterfaces:Form
    {
        public frmImplementmultipleinterfaces()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmImplementmultipleinterfaces
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmImplementmultipleinterfaces";
            this.Text = "frmImplementmultipleinterfaces";
            this.Load += new System.EventHandler(this.frmImplementmultipleinterfaces_Load);
            this.ResumeLayout(false);

        }

        private void frmImplementmultipleinterfaces_Load(object sender, EventArgs e)
        {

        }
    }
}
