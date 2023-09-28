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
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/Genericevents.htm
    public partial  class frmGenericevents:Form
    {
        public frmGenericevents()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGenericevents
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGenericevents";
            this.Text = "frmGenericevents";
            this.Load += new System.EventHandler(this.frmGenericevents_Load);
            this.ResumeLayout(false);

        }

        private void frmGenericevents_Load(object sender, EventArgs e)
        {

        }
    }
}
