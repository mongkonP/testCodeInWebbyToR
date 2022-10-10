using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0760__Properties
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/DocalculationwithProperty.htm
    public partial  class frmDocalculationwithProperty:Form
    {
        public frmDocalculationwithProperty()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDocalculationwithProperty
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDocalculationwithProperty";
            this.Text = "frmDocalculationwithProperty";
            this.Load += new System.EventHandler(this.frmDocalculationwithProperty_Load);
            this.ResumeLayout(false);

        }

        private void frmDocalculationwithProperty_Load(object sender, EventArgs e)
        {

        }
    }
}
