using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0740__StackPanel
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/StretchNone.htm
    public partial  class frmStretchNone:Form
    {
        public frmStretchNone()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmStretchNone
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmStretchNone";
            this.Text = "frmStretchNone";
            this.Load += new System.EventHandler(this.frmStretchNone_Load);
            this.ResumeLayout(false);

        }

        private void frmStretchNone_Load(object sender, EventArgs e)
        {

        }
    }
}
