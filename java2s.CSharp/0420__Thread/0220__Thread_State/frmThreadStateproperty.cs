using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0420__Thread.C0220__Thread_State
{
    //http://www.java2s.com/Tutorial/CSharp/0420__Thread/ThreadStateproperty.htm
    public partial  class frmThreadStateproperty:Form
    {
        public frmThreadStateproperty()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmThreadStateproperty
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmThreadStateproperty";
            this.Text = "frmThreadStateproperty";
            this.Load += new System.EventHandler(this.frmThreadStateproperty_Load);
            this.ResumeLayout(false);

        }

        private void frmThreadStateproperty_Load(object sender, EventArgs e)
        {

        }
    }
}
