using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C2000__Binding
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/Bindtoenumtypes.htm
    public partial  class frmBindtoenumtypes:Form
    {
        public frmBindtoenumtypes()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmBindtoenumtypes
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmBindtoenumtypes";
            this.Text = "frmBindtoenumtypes";
            this.Load += new System.EventHandler(this.frmBindtoenumtypes_Load);
            this.ResumeLayout(false);

        }

        private void frmBindtoenumtypes_Load(object sender, EventArgs e)
        {

        }
    }
}
