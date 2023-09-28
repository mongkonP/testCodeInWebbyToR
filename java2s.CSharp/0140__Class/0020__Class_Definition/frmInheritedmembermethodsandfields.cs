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
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/Inheritedmembermethodsandfields.htm
    public partial  class frmInheritedmembermethodsandfields:Form
    {
        public frmInheritedmembermethodsandfields()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmInheritedmembermethodsandfields
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmInheritedmembermethodsandfields";
            this.Text = "frmInheritedmembermethodsandfields";
            this.Load += new System.EventHandler(this.frmInheritedmembermethodsandfields_Load);
            this.ResumeLayout(false);

        }

        private void frmInheritedmembermethodsandfields_Load(object sender, EventArgs e)
        {

        }
    }
}
