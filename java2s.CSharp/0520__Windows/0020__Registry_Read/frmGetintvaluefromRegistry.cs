using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0520__Windows.C0020__Registry_Read
{
    //http://www.java2s.com/Tutorial/CSharp/0520__Windows/GetintvaluefromRegistry.htm
    public partial  class frmGetintvaluefromRegistry:Form
    {
        public frmGetintvaluefromRegistry()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGetintvaluefromRegistry
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGetintvaluefromRegistry";
            this.Text = "frmGetintvaluefromRegistry";
            this.Load += new System.EventHandler(this.frmGetintvaluefromRegistry_Load);
            this.ResumeLayout(false);

        }

        private void frmGetintvaluefromRegistry_Load(object sender, EventArgs e)
        {

        }
    }
}
