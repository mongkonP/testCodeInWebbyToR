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
    //http://www.java2s.com/Tutorial/CSharp/0120__struct/Copyastructinstancebyassignment.htm
    public partial  class frmCopyastructinstancebyassignment:Form
    {
        public frmCopyastructinstancebyassignment()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCopyastructinstancebyassignment
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCopyastructinstancebyassignment";
            this.Text = "frmCopyastructinstancebyassignment";
            this.Load += new System.EventHandler(this.frmCopyastructinstancebyassignment_Load);
            this.ResumeLayout(false);

        }

        private void frmCopyastructinstancebyassignment_Load(object sender, EventArgs e)
        {

        }
    }
}
