using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1420__Image
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/ReadbitmapfromUri.htm
    public partial  class frmReadbitmapfromUri:Form
    {
        public frmReadbitmapfromUri()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmReadbitmapfromUri
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmReadbitmapfromUri";
            this.Text = "frmReadbitmapfromUri";
            this.Load += new System.EventHandler(this.frmReadbitmapfromUri_Load);
            this.ResumeLayout(false);

        }

        private void frmReadbitmapfromUri_Load(object sender, EventArgs e)
        {

        }
    }
}
