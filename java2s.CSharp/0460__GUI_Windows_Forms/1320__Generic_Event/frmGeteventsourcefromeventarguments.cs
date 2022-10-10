using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C1320__Generic_Event
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/Geteventsourcefromeventarguments.htm
    public partial  class frmGeteventsourcefromeventarguments:Form
    {
        public frmGeteventsourcefromeventarguments()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGeteventsourcefromeventarguments
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGeteventsourcefromeventarguments";
            this.Text = "frmGeteventsourcefromeventarguments";
            this.Load += new System.EventHandler(this.frmGeteventsourcefromeventarguments_Load);
            this.ResumeLayout(false);

        }

        private void frmGeteventsourcefromeventarguments_Load(object sender, EventArgs e)
        {

        }
    }
}
