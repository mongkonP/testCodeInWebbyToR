using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0581__Directory_Services.C0080__Delete
{
    //http://www.java2s.com/Tutorial/CSharp/0581__Directory-Services/DeleteObject.htm
    public partial  class frmDeleteObject:Form
    {
        public frmDeleteObject()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDeleteObject
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDeleteObject";
            this.Text = "frmDeleteObject";
            this.Load += new System.EventHandler(this.frmDeleteObject_Load);
            this.ResumeLayout(false);

        }

        private void frmDeleteObject_Load(object sender, EventArgs e)
        {

        }
    }
}
