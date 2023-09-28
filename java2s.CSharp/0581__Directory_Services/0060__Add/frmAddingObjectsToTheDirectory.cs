using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0581__Directory_Services.C0060__Add
{
    //http://www.java2s.com/Tutorial/CSharp/0581__Directory-Services/AddingObjectsToTheDirectory.htm
    public partial  class frmAddingObjectsToTheDirectory:Form
    {
        public frmAddingObjectsToTheDirectory()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAddingObjectsToTheDirectory
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAddingObjectsToTheDirectory";
            this.Text = "frmAddingObjectsToTheDirectory";
            this.Load += new System.EventHandler(this.frmAddingObjectsToTheDirectory_Load);
            this.ResumeLayout(false);

        }

        private void frmAddingObjectsToTheDirectory_Load(object sender, EventArgs e)
        {

        }
    }
}
