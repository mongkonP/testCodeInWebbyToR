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
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/Callbaseconstructortoinitmembervariables.htm
    public partial  class frmCallbaseconstructortoinitmembervariables:Form
    {
        public frmCallbaseconstructortoinitmembervariables()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCallbaseconstructortoinitmembervariables
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCallbaseconstructortoinitmembervariables";
            this.Text = "frmCallbaseconstructortoinitmembervariables";
            this.Load += new System.EventHandler(this.frmCallbaseconstructortoinitmembervariables_Load);
            this.ResumeLayout(false);

        }

        private void frmCallbaseconstructortoinitmembervariables_Load(object sender, EventArgs e)
        {

        }
    }
}
