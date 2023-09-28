using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0880__TabControl
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/TabItemHeader.htm
    public partial  class frmTabItemHeader:Form
    {
        public frmTabItemHeader()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmTabItemHeader
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmTabItemHeader";
            this.Text = "frmTabItemHeader";
            this.Load += new System.EventHandler(this.frmTabItemHeader_Load);
            this.ResumeLayout(false);

        }

        private void frmTabItemHeader_Load(object sender, EventArgs e)
        {

        }
    }
}
