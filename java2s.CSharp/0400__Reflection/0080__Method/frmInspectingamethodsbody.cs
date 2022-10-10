using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0400__Reflection.C0080__Method
{
    //http://www.java2s.com/Tutorial/CSharp/0400__Reflection/Inspectingamethodsbody.htm
    public partial  class frmInspectingamethodsbody:Form
    {
        public frmInspectingamethodsbody()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmInspectingamethodsbody
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmInspectingamethodsbody";
            this.Text = "frmInspectingamethodsbody";
            this.Load += new System.EventHandler(this.frmInspectingamethodsbody_Load);
            this.ResumeLayout(false);

        }

        private void frmInspectingamethodsbody_Load(object sender, EventArgs e)
        {

        }
    }
}
