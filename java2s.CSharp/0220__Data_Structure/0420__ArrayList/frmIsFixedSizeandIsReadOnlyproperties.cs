using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0220__Data_Structure.C0420__ArrayList
{
    //http://www.java2s.com/Tutorial/CSharp/0220__Data-Structure/IsFixedSizeandIsReadOnlyproperties.htm
    public partial  class frmIsFixedSizeandIsReadOnlyproperties:Form
    {
        public frmIsFixedSizeandIsReadOnlyproperties()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmIsFixedSizeandIsReadOnlyproperties
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmIsFixedSizeandIsReadOnlyproperties";
            this.Text = "frmIsFixedSizeandIsReadOnlyproperties";
            this.Load += new System.EventHandler(this.frmIsFixedSizeandIsReadOnlyproperties_Load);
            this.ResumeLayout(false);

        }

        private void frmIsFixedSizeandIsReadOnlyproperties_Load(object sender, EventArgs e)
        {

        }
    }
}
