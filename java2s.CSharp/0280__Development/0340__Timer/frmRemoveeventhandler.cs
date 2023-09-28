using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0280__Development.C0340__Timer
{
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/Removeeventhandler.htm
    public partial  class frmRemoveeventhandler:Form
    {
        public frmRemoveeventhandler()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmRemoveeventhandler
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmRemoveeventhandler";
            this.Text = "frmRemoveeventhandler";
            this.Load += new System.EventHandler(this.frmRemoveeventhandler_Load);
            this.ResumeLayout(false);

        }

        private void frmRemoveeventhandler_Load(object sender, EventArgs e)
        {

        }
    }
}
