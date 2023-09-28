using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0581__Directory_Services.C0100__Rename
{
    //http://www.java2s.com/Tutorial/CSharp/0581__Directory-Services/RenameObject.htm
    public partial  class frmRenameObject:Form
    {
        public frmRenameObject()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmRenameObject
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmRenameObject";
            this.Text = "frmRenameObject";
            this.Load += new System.EventHandler(this.frmRenameObject_Load);
            this.ResumeLayout(false);

        }

        private void frmRenameObject_Load(object sender, EventArgs e)
        {

        }
    }
}
