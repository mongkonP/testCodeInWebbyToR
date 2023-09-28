using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C2400__Xaml
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/UseLinqtogetcontrolfromacontainer.htm
    public partial  class frmUseLinqtogetcontrolfromacontainer:Form
    {
        public frmUseLinqtogetcontrolfromacontainer()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseLinqtogetcontrolfromacontainer
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseLinqtogetcontrolfromacontainer";
            this.Text = "frmUseLinqtogetcontrolfromacontainer";
            this.Load += new System.EventHandler(this.frmUseLinqtogetcontrolfromacontainer_Load);
            this.ResumeLayout(false);

        }

        private void frmUseLinqtogetcontrolfromacontainer_Load(object sender, EventArgs e)
        {

        }
    }
}
