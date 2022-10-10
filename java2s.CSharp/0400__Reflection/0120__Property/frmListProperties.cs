using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0400__Reflection.C0120__Property
{
    //http://www.java2s.com/Tutorial/CSharp/0400__Reflection/ListProperties.htm
    public partial  class frmListProperties:Form
    {
        public frmListProperties()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmListProperties
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmListProperties";
            this.Text = "frmListProperties";
            this.Load += new System.EventHandler(this.frmListProperties_Load);
            this.ResumeLayout(false);

        }

        private void frmListProperties_Load(object sender, EventArgs e)
        {

        }
    }
}
