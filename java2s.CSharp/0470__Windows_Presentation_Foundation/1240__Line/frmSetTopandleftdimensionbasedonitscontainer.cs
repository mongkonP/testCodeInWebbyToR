using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1240__Line
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/SetTopandleftdimensionbasedonitscontainer.htm
    public partial  class frmSetTopandleftdimensionbasedonitscontainer:Form
    {
        public frmSetTopandleftdimensionbasedonitscontainer()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSetTopandleftdimensionbasedonitscontainer
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSetTopandleftdimensionbasedonitscontainer";
            this.Text = "frmSetTopandleftdimensionbasedonitscontainer";
            this.Load += new System.EventHandler(this.frmSetTopandleftdimensionbasedonitscontainer_Load);
            this.ResumeLayout(false);

        }

        private void frmSetTopandleftdimensionbasedonitscontainer_Load(object sender, EventArgs e)
        {

        }
    }
}
