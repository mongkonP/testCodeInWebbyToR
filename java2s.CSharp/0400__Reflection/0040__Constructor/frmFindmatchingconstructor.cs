using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0400__Reflection.C0040__Constructor
{
    //http://www.java2s.com/Tutorial/CSharp/0400__Reflection/Findmatchingconstructor.htm
    public partial  class frmFindmatchingconstructor:Form
    {
        public frmFindmatchingconstructor()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmFindmatchingconstructor
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmFindmatchingconstructor";
            this.Text = "frmFindmatchingconstructor";
            this.Load += new System.EventHandler(this.frmFindmatchingconstructor_Load);
            this.ResumeLayout(false);

        }

        private void frmFindmatchingconstructor_Load(object sender, EventArgs e)
        {

        }
    }
}
