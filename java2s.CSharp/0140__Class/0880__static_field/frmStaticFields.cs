using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0880__static_field
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/StaticFields.htm
    public partial  class frmStaticFields:Form
    {
        public frmStaticFields()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmStaticFields
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmStaticFields";
            this.Text = "frmStaticFields";
            this.Load += new System.EventHandler(this.frmStaticFields_Load);
            this.ResumeLayout(false);

        }

        private void frmStaticFields_Load(object sender, EventArgs e)
        {

        }
    }
}
