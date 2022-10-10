using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0520__Windows.C0260__Memory
{
    //http://www.java2s.com/Tutorial/CSharp/0520__Windows/FreememoryMarshalFreeHGlobal.htm
    public partial  class frmFreememoryMarshalFreeHGlobal:Form
    {
        public frmFreememoryMarshalFreeHGlobal()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmFreememoryMarshalFreeHGlobal
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmFreememoryMarshalFreeHGlobal";
            this.Text = "frmFreememoryMarshalFreeHGlobal";
            this.Load += new System.EventHandler(this.frmFreememoryMarshalFreeHGlobal_Load);
            this.ResumeLayout(false);

        }

        private void frmFreememoryMarshalFreeHGlobal_Load(object sender, EventArgs e)
        {

        }
    }
}
