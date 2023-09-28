using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0120__struct.C0300__Generic_struct
{
    //http://www.java2s.com/Tutorial/CSharp/0120__struct/GenericStruct.htm
    public partial  class frmGenericStruct:Form
    {
        public frmGenericStruct()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGenericStruct
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGenericStruct";
            this.Text = "frmGenericStruct";
            this.Load += new System.EventHandler(this.frmGenericStruct_Load);
            this.ResumeLayout(false);

        }

        private void frmGenericStruct_Load(object sender, EventArgs e)
        {

        }
    }
}
