using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1380__Rectangle
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/Arectanglewithcurvedcorners.htm
    public partial  class frmArectanglewithcurvedcorners:Form
    {
        public frmArectanglewithcurvedcorners()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmArectanglewithcurvedcorners
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmArectanglewithcurvedcorners";
            this.Text = "frmArectanglewithcurvedcorners";
            this.Load += new System.EventHandler(this.frmArectanglewithcurvedcorners_Load);
            this.ResumeLayout(false);

        }

        private void frmArectanglewithcurvedcorners_Load(object sender, EventArgs e)
        {

        }
    }
}
