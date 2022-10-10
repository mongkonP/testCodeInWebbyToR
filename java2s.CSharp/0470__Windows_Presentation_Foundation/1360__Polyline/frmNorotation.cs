using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1360__Polyline
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/Norotation.htm
    public partial  class frmNorotation:Form
    {
        public frmNorotation()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmNorotation
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmNorotation";
            this.Text = "frmNorotation";
            this.Load += new System.EventHandler(this.frmNorotation_Load);
            this.ResumeLayout(false);

        }

        private void frmNorotation_Load(object sender, EventArgs e)
        {

        }
    }
}
