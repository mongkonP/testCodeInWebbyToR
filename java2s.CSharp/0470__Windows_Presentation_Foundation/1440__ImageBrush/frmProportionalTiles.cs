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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/ProportionalTiles.htm
    public partial  class frmProportionalTiles:Form
    {
        public frmProportionalTiles()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmProportionalTiles
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmProportionalTiles";
            this.Text = "frmProportionalTiles";
            this.Load += new System.EventHandler(this.frmProportionalTiles_Load);
            this.ResumeLayout(false);

        }

        private void frmProportionalTiles_Load(object sender, EventArgs e)
        {

        }
    }
}
