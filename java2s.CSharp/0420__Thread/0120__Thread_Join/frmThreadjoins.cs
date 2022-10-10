using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0420__Thread.C0120__Thread_Join
{
    //http://www.java2s.com/Tutorial/CSharp/0420__Thread/Threadjoins.htm
    public partial  class frmThreadjoins:Form
    {
        public frmThreadjoins()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmThreadjoins
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmThreadjoins";
            this.Text = "frmThreadjoins";
            this.Load += new System.EventHandler(this.frmThreadjoins_Load);
            this.ResumeLayout(false);

        }

        private void frmThreadjoins_Load(object sender, EventArgs e)
        {

        }
    }
}
