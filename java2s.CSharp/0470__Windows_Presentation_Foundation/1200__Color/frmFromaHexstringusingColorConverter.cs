using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1200__Color
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/FromaHexstringusingColorConverter.htm
    public partial  class frmFromaHexstringusingColorConverter:Form
    {
        public frmFromaHexstringusingColorConverter()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmFromaHexstringusingColorConverter
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmFromaHexstringusingColorConverter";
            this.Text = "frmFromaHexstringusingColorConverter";
            this.Load += new System.EventHandler(this.frmFromaHexstringusingColorConverter_Load);
            this.ResumeLayout(false);

        }

        private void frmFromaHexstringusingColorConverter_Load(object sender, EventArgs e)
        {

        }
    }
}
