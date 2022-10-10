using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0100__Member_Variable
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/fieldinitialization.htm
    public partial  class frmfieldinitialization:Form
    {
        public frmfieldinitialization()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmfieldinitialization
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmfieldinitialization";
            this.Text = "frmfieldinitialization";
            this.Load += new System.EventHandler(this.frmfieldinitialization_Load);
            this.ResumeLayout(false);

        }

        private void frmfieldinitialization_Load(object sender, EventArgs e)
        {

        }
    }
}
