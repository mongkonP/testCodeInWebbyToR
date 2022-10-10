using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C0260__DomainUpDown
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/DomainUpDownselecteditemchangedevent.htm
    public partial  class frmDomainUpDownselecteditemchangedevent:Form
    {
        public frmDomainUpDownselecteditemchangedevent()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDomainUpDownselecteditemchangedevent
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDomainUpDownselecteditemchangedevent";
            this.Text = "frmDomainUpDownselecteditemchangedevent";
            this.Load += new System.EventHandler(this.frmDomainUpDownselecteditemchangedevent_Load);
            this.ResumeLayout(false);

        }

        private void frmDomainUpDownselecteditemchangedevent_Load(object sender, EventArgs e)
        {

        }
    }
}
