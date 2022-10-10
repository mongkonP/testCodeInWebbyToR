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
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/Illustrateshowtoassigndefaultvaluestofieldsusinginitializers.htm
    public partial  class frmIllustrateshowtoassigndefaultvaluestofieldsusinginitializers:Form
    {
        public frmIllustrateshowtoassigndefaultvaluestofieldsusinginitializers()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmIllustrateshowtoassigndefaultvaluestofieldsusinginitializers
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmIllustrateshowtoassigndefaultvaluestofieldsusinginitializers";
            this.Text = "frmIllustrateshowtoassigndefaultvaluestofieldsusinginitializers";
            this.Load += new System.EventHandler(this.frmIllustrateshowtoassigndefaultvaluestofieldsusinginitializers_Load);
            this.ResumeLayout(false);

        }

        private void frmIllustrateshowtoassigndefaultvaluestofieldsusinginitializers_Load(object sender, EventArgs e)
        {

        }
    }
}
