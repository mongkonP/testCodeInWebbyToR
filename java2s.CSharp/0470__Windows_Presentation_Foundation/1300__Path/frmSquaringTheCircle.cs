using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1300__Path
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/SquaringTheCircle.htm
    public partial  class frmSquaringTheCircle:Form
    {
        public frmSquaringTheCircle()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSquaringTheCircle
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSquaringTheCircle";
            this.Text = "frmSquaringTheCircle";
            this.Load += new System.EventHandler(this.frmSquaringTheCircle_Load);
            this.ResumeLayout(false);

        }

        private void frmSquaringTheCircle_Load(object sender, EventArgs e)
        {

        }
    }
}
