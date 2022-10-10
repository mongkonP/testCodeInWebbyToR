using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C0160__where
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/FilterbyMakeandSpeed.htm
    public partial  class frmFilterbyMakeandSpeed:Form
    {
        public frmFilterbyMakeandSpeed()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmFilterbyMakeandSpeed
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmFilterbyMakeandSpeed";
            this.Text = "frmFilterbyMakeandSpeed";
            this.Load += new System.EventHandler(this.frmFilterbyMakeandSpeed_Load);
            this.ResumeLayout(false);

        }

        private void frmFilterbyMakeandSpeed_Load(object sender, EventArgs e)
        {

        }
    }
}
