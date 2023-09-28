using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0400__Reflection.C0080__Method
{
    //http://www.java2s.com/Tutorial/CSharp/0400__Reflection/FindingParticularMembers.htm
    public partial  class frmFindingParticularMembers:Form
    {
        public frmFindingParticularMembers()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmFindingParticularMembers
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmFindingParticularMembers";
            this.Text = "frmFindingParticularMembers";
            this.Load += new System.EventHandler(this.frmFindingParticularMembers_Load);
            this.ResumeLayout(false);

        }

        private void frmFindingParticularMembers_Load(object sender, EventArgs e)
        {

        }
    }
}
