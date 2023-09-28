using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0340__public
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/ReusingBaseClassIdentifiers.htm
    public partial  class frmReusingBaseClassIdentifiers:Form
    {
        public frmReusingBaseClassIdentifiers()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmReusingBaseClassIdentifiers
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmReusingBaseClassIdentifiers";
            this.Text = "frmReusingBaseClassIdentifiers";
            this.Load += new System.EventHandler(this.frmReusingBaseClassIdentifiers_Load);
            this.ResumeLayout(false);

        }

        private void frmReusingBaseClassIdentifiers_Load(object sender, EventArgs e)
        {

        }
    }
}
