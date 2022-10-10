using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0060__Object_Reference
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/OverriddenEquals.htm
    public partial  class frmOverriddenEquals:Form
    {
        public frmOverriddenEquals()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmOverriddenEquals
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmOverriddenEquals";
            this.Text = "frmOverriddenEquals";
            this.Load += new System.EventHandler(this.frmOverriddenEquals_Load);
            this.ResumeLayout(false);

        }

        private void frmOverriddenEquals_Load(object sender, EventArgs e)
        {

        }
    }
}
