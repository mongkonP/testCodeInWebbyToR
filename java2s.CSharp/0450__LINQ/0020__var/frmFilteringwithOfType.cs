using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C0020__var
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/FilteringwithOfType.htm
    public partial  class frmFilteringwithOfType:Form
    {
        public frmFilteringwithOfType()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmFilteringwithOfType
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmFilteringwithOfType";
            this.Text = "frmFilteringwithOfType";
            this.Load += new System.EventHandler(this.frmFilteringwithOfType_Load);
            this.ResumeLayout(false);

        }

        private void frmFilteringwithOfType_Load(object sender, EventArgs e)
        {

        }
    }
}
