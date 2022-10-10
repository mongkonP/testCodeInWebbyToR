using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0120__struct.C0040__struct_definition
{
    //http://www.java2s.com/Tutorial/CSharp/0120__struct/CompositeStruct.htm
    public partial  class frmCompositeStruct:Form
    {
        public frmCompositeStruct()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCompositeStruct
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCompositeStruct";
            this.Text = "frmCompositeStruct";
            this.Load += new System.EventHandler(this.frmCompositeStruct_Load);
            this.ResumeLayout(false);

        }

        private void frmCompositeStruct_Load(object sender, EventArgs e)
        {

        }
    }
}
