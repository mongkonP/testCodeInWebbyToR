using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C1140__Anchoring
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/Anchoranddock.htm
    public partial  class frmAnchoranddock:Form
    {
        public frmAnchoranddock()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAnchoranddock
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAnchoranddock";
            this.Text = "frmAnchoranddock";
            this.Load += new System.EventHandler(this.frmAnchoranddock_Load);
            this.ResumeLayout(false);

        }

        private void frmAnchoranddock_Load(object sender, EventArgs e)
        {

        }
    }
}
