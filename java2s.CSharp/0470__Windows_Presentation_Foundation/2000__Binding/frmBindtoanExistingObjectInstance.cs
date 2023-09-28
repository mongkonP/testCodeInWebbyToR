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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/BindtoanExistingObjectInstance.htm
    public partial  class frmBindtoanExistingObjectInstance:Form
    {
        public frmBindtoanExistingObjectInstance()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmBindtoanExistingObjectInstance
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmBindtoanExistingObjectInstance";
            this.Text = "frmBindtoanExistingObjectInstance";
            this.Load += new System.EventHandler(this.frmBindtoanExistingObjectInstance_Load);
            this.ResumeLayout(false);

        }

        private void frmBindtoanExistingObjectInstance_Load(object sender, EventArgs e)
        {

        }
    }
}
