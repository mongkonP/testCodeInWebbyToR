using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0260__Date_Time.C0100__TimeSpan
{
    //http://www.java2s.com/Tutorial/CSharp/0260__Date-Time/DisplaythepropertiesformyTimeSpan.htm
    public partial  class frmDisplaythepropertiesformyTimeSpan:Form
    {
        public frmDisplaythepropertiesformyTimeSpan()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDisplaythepropertiesformyTimeSpan
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDisplaythepropertiesformyTimeSpan";
            this.Text = "frmDisplaythepropertiesformyTimeSpan";
            this.Load += new System.EventHandler(this.frmDisplaythepropertiesformyTimeSpan_Load);
            this.ResumeLayout(false);

        }

        private void frmDisplaythepropertiesformyTimeSpan_Load(object sender, EventArgs e)
        {

        }
    }
}
