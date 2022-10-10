using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C2000__Binding
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/Asyncbinding.htm
    public partial  class frmAsyncbinding:Form
    {
        public frmAsyncbinding()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAsyncbinding
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAsyncbinding";
            this.Text = "frmAsyncbinding";
            this.Load += new System.EventHandler(this.frmAsyncbinding_Load);
            this.ResumeLayout(false);

        }

        private void frmAsyncbinding_Load(object sender, EventArgs e)
        {

        }
    }
}
