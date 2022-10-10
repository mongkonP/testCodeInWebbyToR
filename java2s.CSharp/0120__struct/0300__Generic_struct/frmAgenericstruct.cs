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
    //http://www.java2s.com/Tutorial/CSharp/0120__struct/Agenericstruct.htm
    public partial  class frmAgenericstruct:Form
    {
        public frmAgenericstruct()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAgenericstruct
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAgenericstruct";
            this.Text = "frmAgenericstruct";
            this.Load += new System.EventHandler(this.frmAgenericstruct_Load);
            this.ResumeLayout(false);

        }

        private void frmAgenericstruct_Load(object sender, EventArgs e)
        {

        }
    }
}
