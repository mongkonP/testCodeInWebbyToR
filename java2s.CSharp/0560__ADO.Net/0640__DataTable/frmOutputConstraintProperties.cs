using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0560__ADO.Net.C0640__DataTable
{
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/OutputConstraintProperties.htm
    public partial  class frmOutputConstraintProperties:Form
    {
        public frmOutputConstraintProperties()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmOutputConstraintProperties
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmOutputConstraintProperties";
            this.Text = "frmOutputConstraintProperties";
            this.Load += new System.EventHandler(this.frmOutputConstraintProperties_Load);
            this.ResumeLayout(false);

        }

        private void frmOutputConstraintProperties_Load(object sender, EventArgs e)
        {

        }
    }
}
