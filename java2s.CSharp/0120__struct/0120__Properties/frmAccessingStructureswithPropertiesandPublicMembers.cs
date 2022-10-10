using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0120__struct.C0120__Properties
{
    //http://www.java2s.com/Tutorial/CSharp/0120__struct/AccessingStructureswithPropertiesandPublicMembers.htm
    public partial  class frmAccessingStructureswithPropertiesandPublicMembers:Form
    {
        public frmAccessingStructureswithPropertiesandPublicMembers()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAccessingStructureswithPropertiesandPublicMembers
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAccessingStructureswithPropertiesandPublicMembers";
            this.Text = "frmAccessingStructureswithPropertiesandPublicMembers";
            this.Load += new System.EventHandler(this.frmAccessingStructureswithPropertiesandPublicMembers_Load);
            this.ResumeLayout(false);

        }

        private void frmAccessingStructureswithPropertiesandPublicMembers_Load(object sender, EventArgs e)
        {

        }
    }
}
