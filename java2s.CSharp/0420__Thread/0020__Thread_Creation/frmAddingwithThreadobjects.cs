using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0420__Thread.C0020__Thread_Creation
{
    //http://www.java2s.com/Tutorial/CSharp/0420__Thread/AddingwithThreadobjects.htm
    public partial  class frmAddingwithThreadobjects:Form
    {
        public frmAddingwithThreadobjects()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAddingwithThreadobjects
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAddingwithThreadobjects";
            this.Text = "frmAddingwithThreadobjects";
            this.Load += new System.EventHandler(this.frmAddingwithThreadobjects_Load);
            this.ResumeLayout(false);

        }

        private void frmAddingwithThreadobjects_Load(object sender, EventArgs e)
        {

        }
    }
}
