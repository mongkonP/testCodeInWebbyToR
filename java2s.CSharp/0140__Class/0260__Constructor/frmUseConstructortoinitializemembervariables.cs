using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0260__Constructor
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/UseConstructortoinitializemembervariables.htm
    public partial  class frmUseConstructortoinitializemembervariables:Form
    {
        public frmUseConstructortoinitializemembervariables()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseConstructortoinitializemembervariables
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseConstructortoinitializemembervariables";
            this.Text = "frmUseConstructortoinitializemembervariables";
            this.Load += new System.EventHandler(this.frmUseConstructortoinitializemembervariables_Load);
            this.ResumeLayout(false);

        }

        private void frmUseConstructortoinitializemembervariables_Load(object sender, EventArgs e)
        {

        }
    }
}
