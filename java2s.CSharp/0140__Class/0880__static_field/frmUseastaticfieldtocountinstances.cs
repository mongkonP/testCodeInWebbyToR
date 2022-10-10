using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0880__static_field
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/Useastaticfieldtocountinstances.htm
    public partial  class frmUseastaticfieldtocountinstances:Form
    {
        public frmUseastaticfieldtocountinstances()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseastaticfieldtocountinstances
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseastaticfieldtocountinstances";
            this.Text = "frmUseastaticfieldtocountinstances";
            this.Load += new System.EventHandler(this.frmUseastaticfieldtocountinstances_Load);
            this.ResumeLayout(false);

        }

        private void frmUseastaticfieldtocountinstances_Load(object sender, EventArgs e)
        {

        }
    }
}
