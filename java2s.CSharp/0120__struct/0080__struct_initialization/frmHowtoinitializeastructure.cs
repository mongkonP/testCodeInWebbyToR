using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0120__struct.C0080__struct_initialization
{
    //http://www.java2s.com/Tutorial/CSharp/0120__struct/Howtoinitializeastructure.htm
    public partial  class frmHowtoinitializeastructure:Form
    {
        public frmHowtoinitializeastructure()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmHowtoinitializeastructure
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmHowtoinitializeastructure";
            this.Text = "frmHowtoinitializeastructure";
            this.Load += new System.EventHandler(this.frmHowtoinitializeastructure_Load);
            this.ResumeLayout(false);

        }

        private void frmHowtoinitializeastructure_Load(object sender, EventArgs e)
        {

        }
    }
}
