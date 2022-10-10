using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0040__Data_Type.C0080__int_array
{
    //http://www.java2s.com/Tutorial/CSharp/0040__Data-Type/intarraywithforloop.htm
    public partial  class frmintarraywithforloop:Form
    {
        public frmintarraywithforloop()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmintarraywithforloop
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmintarraywithforloop";
            this.Text = "frmintarraywithforloop";
            this.Load += new System.EventHandler(this.frmintarraywithforloop_Load);
            this.ResumeLayout(false);

        }

        private void frmintarraywithforloop_Load(object sender, EventArgs e)
        {

        }
    }
}
