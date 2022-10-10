using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1440__ImageBrush
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/FixedTiles.htm
    public partial  class frmFixedTiles:Form
    {
        public frmFixedTiles()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmFixedTiles
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmFixedTiles";
            this.Text = "frmFixedTiles";
            this.Load += new System.EventHandler(this.frmFixedTiles_Load);
            this.ResumeLayout(false);

        }

        private void frmFixedTiles_Load(object sender, EventArgs e)
        {

        }
    }
}
