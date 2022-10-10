using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C0060__Form_Event
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/Paintoneformswithtwopainteventhandler.htm
    public partial  class frmPaintoneformswithtwopainteventhandler:Form
    {
        public frmPaintoneformswithtwopainteventhandler()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmPaintoneformswithtwopainteventhandler
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmPaintoneformswithtwopainteventhandler";
            this.Text = "frmPaintoneformswithtwopainteventhandler";
            this.Load += new System.EventHandler(this.frmPaintoneformswithtwopainteventhandler_Load);
            this.ResumeLayout(false);

        }

        private void frmPaintoneformswithtwopainteventhandler_Load(object sender, EventArgs e)
        {

        }
    }
}
