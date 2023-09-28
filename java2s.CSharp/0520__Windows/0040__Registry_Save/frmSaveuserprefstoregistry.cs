using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0520__Windows.C0040__Registry_Save
{
    //http://www.java2s.com/Tutorial/CSharp/0520__Windows/Saveuserprefstoregistry.htm
    public partial  class frmSaveuserprefstoregistry:Form
    {
        public frmSaveuserprefstoregistry()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSaveuserprefstoregistry
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSaveuserprefstoregistry";
            this.Text = "frmSaveuserprefstoregistry";
            this.Load += new System.EventHandler(this.frmSaveuserprefstoregistry_Load);
            this.ResumeLayout(false);

        }

        private void frmSaveuserprefstoregistry_Load(object sender, EventArgs e)
        {

        }
    }
}
