using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0040__Data_Type.C0020__Data_Type
{
    //http://www.java2s.com/Tutorial/CSharp/0040__Data-Type/DataDeclarations.htm
    public partial  class frmDataDeclarations:Form
    {
        public frmDataDeclarations()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDataDeclarations
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDataDeclarations";
            this.Text = "frmDataDeclarations";
            this.Load += new System.EventHandler(this.frmDataDeclarations_Load);
            this.ResumeLayout(false);

        }

        private void frmDataDeclarations_Load(object sender, EventArgs e)
        {

        }
    }
}
