using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1220__Stroke
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/PenLineCapSquare.htm
    public partial  class frmPenLineCapSquare:Form
    {
        public frmPenLineCapSquare()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmPenLineCapSquare
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmPenLineCapSquare";
            this.Text = "frmPenLineCapSquare";
            this.Load += new System.EventHandler(this.frmPenLineCapSquare_Load);
            this.ResumeLayout(false);

        }

        private void frmPenLineCapSquare_Load(object sender, EventArgs e)
        {

        }
    }
}
