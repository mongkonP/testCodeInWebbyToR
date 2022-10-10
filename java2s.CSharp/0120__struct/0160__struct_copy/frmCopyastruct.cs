using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0120__struct.C0160__struct_copy
{
    //http://www.java2s.com/Tutorial/CSharp/0120__struct/Copyastruct.htm
    public partial  class frmCopyastruct:Form
    {
        public frmCopyastruct()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCopyastruct
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCopyastruct";
            this.Text = "frmCopyastruct";
            this.Load += new System.EventHandler(this.frmCopyastruct_Load);
            this.ResumeLayout(false);

        }

        private void frmCopyastruct_Load(object sender, EventArgs e)
        {

        }
    }
}
