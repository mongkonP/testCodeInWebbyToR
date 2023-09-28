using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C0900__Group
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/SelectfromaGroup.htm
    public partial  class frmSelectfromaGroup:Form
    {
        public frmSelectfromaGroup()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSelectfromaGroup
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSelectfromaGroup";
            this.Text = "frmSelectfromaGroup";
            this.Load += new System.EventHandler(this.frmSelectfromaGroup_Load);
            this.ResumeLayout(false);

        }

        private void frmSelectfromaGroup_Load(object sender, EventArgs e)
        {

        }
    }
}
