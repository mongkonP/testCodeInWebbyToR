using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0380__internal
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/UsingInternalonMembers.htm
    public partial  class frmUsingInternalonMembers:Form
    {
        public frmUsingInternalonMembers()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsingInternalonMembers
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsingInternalonMembers";
            this.Text = "frmUsingInternalonMembers";
            this.Load += new System.EventHandler(this.frmUsingInternalonMembers_Load);
            this.ResumeLayout(false);

        }

        private void frmUsingInternalonMembers_Load(object sender, EventArgs e)
        {

        }
    }
}
