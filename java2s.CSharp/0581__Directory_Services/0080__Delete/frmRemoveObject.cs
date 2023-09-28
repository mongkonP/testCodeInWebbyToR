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
    //http://www.java2s.com/Tutorial/CSharp/0581__Directory-Services/RemoveObject.htm
    public partial  class frmRemoveObject:Form
    {
        public frmRemoveObject()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmRemoveObject
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmRemoveObject";
            this.Text = "frmRemoveObject";
            this.Load += new System.EventHandler(this.frmRemoveObject_Load);
            this.ResumeLayout(false);

        }

        private void frmRemoveObject_Load(object sender, EventArgs e)
        {

        }
    }
}
