using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0120__struct.C0020__struct
{
    //http://www.java2s.com/Tutorial/CSharp/0120__struct/classvsstruct.htm
    public partial  class frmclassvsstruct:Form
    {
        public frmclassvsstruct()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmclassvsstruct
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmclassvsstruct";
            this.Text = "frmclassvsstruct";
            this.Load += new System.EventHandler(this.frmclassvsstruct_Load);
            this.ResumeLayout(false);

        }

        private void frmclassvsstruct_Load(object sender, EventArgs e)
        {

        }
    }
}
