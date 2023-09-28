using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0520__Windows.C0360__Management
{
    //http://www.java2s.com/Tutorial/CSharp/0520__Windows/GetManagementObjectCollection.htm
    public partial  class frmGetManagementObjectCollection:Form
    {
        public frmGetManagementObjectCollection()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGetManagementObjectCollection
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGetManagementObjectCollection";
            this.Text = "frmGetManagementObjectCollection";
            this.Load += new System.EventHandler(this.frmGetManagementObjectCollection_Load);
            this.ResumeLayout(false);

        }

        private void frmGetManagementObjectCollection_Load(object sender, EventArgs e)
        {

        }
    }
}
