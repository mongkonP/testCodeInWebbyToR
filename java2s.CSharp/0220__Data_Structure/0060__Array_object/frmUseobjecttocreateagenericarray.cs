using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0220__Data_Structure.C0060__Array_object
{
    //http://www.java2s.com/Tutorial/CSharp/0220__Data-Structure/Useobjecttocreateagenericarray.htm
    public partial  class frmUseobjecttocreateagenericarray:Form
    {
        public frmUseobjecttocreateagenericarray()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseobjecttocreateagenericarray
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseobjecttocreateagenericarray";
            this.Text = "frmUseobjecttocreateagenericarray";
            this.Load += new System.EventHandler(this.frmUseobjecttocreateagenericarray_Load);
            this.ResumeLayout(false);

        }

        private void frmUseobjecttocreateagenericarray_Load(object sender, EventArgs e)
        {

        }
    }
}
