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
    //http://www.java2s.com/Tutorial/CSharp/0120__struct/Definingstruct.htm
    public partial  class frmDefiningstruct:Form
    {
        public frmDefiningstruct()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDefiningstruct
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDefiningstruct";
            this.Text = "frmDefiningstruct";
            this.Load += new System.EventHandler(this.frmDefiningstruct_Load);
            this.ResumeLayout(false);

        }

        private void frmDefiningstruct_Load(object sender, EventArgs e)
        {

        }
    }
}
