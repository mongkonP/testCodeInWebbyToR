using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0720__readonly
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/ReadonlyFields.htm
    public partial  class frmReadonlyFields:Form
    {
        public frmReadonlyFields()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmReadonlyFields
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmReadonlyFields";
            this.Text = "frmReadonlyFields";
            this.Load += new System.EventHandler(this.frmReadonlyFields_Load);
            this.ResumeLayout(false);

        }

        private void frmReadonlyFields_Load(object sender, EventArgs e)
        {

        }
    }
}
