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
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/Readonlyproperty.htm
    public partial  class frmReadonlyproperty:Form
    {
        public frmReadonlyproperty()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmReadonlyproperty
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmReadonlyproperty";
            this.Text = "frmReadonlyproperty";
            this.Load += new System.EventHandler(this.frmReadonlyproperty_Load);
            this.ResumeLayout(false);

        }

        private void frmReadonlyproperty_Load(object sender, EventArgs e)
        {

        }
    }
}
