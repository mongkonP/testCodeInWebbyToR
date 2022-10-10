using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0420__Thread.C0400__Monitor
{
    //http://www.java2s.com/Tutorial/CSharp/0420__Thread/CoordinatetwothreadsusingMonitor.htm
    public partial  class frmCoordinatetwothreadsusingMonitor:Form
    {
        public frmCoordinatetwothreadsusingMonitor()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCoordinatetwothreadsusingMonitor
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCoordinatetwothreadsusingMonitor";
            this.Text = "frmCoordinatetwothreadsusingMonitor";
            this.Load += new System.EventHandler(this.frmCoordinatetwothreadsusingMonitor_Load);
            this.ResumeLayout(false);

        }

        private void frmCoordinatetwothreadsusingMonitor_Load(object sender, EventArgs e)
        {

        }
    }
}
