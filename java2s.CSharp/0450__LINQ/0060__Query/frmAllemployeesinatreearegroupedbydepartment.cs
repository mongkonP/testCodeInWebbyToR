using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C0060__Query
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/Allemployeesinatreearegroupedbydepartment.htm
    public partial  class frmAllemployeesinatreearegroupedbydepartment:Form
    {
        public frmAllemployeesinatreearegroupedbydepartment()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAllemployeesinatreearegroupedbydepartment
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAllemployeesinatreearegroupedbydepartment";
            this.Text = "frmAllemployeesinatreearegroupedbydepartment";
            this.Load += new System.EventHandler(this.frmAllemployeesinatreearegroupedbydepartment_Load);
            this.ResumeLayout(false);

        }

        private void frmAllemployeesinatreearegroupedbydepartment_Load(object sender, EventArgs e)
        {

        }
    }
}
