using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0060__Operator.C0300__sizeof
{
    //http://www.java2s.com/Tutorial/CSharp/0060__Operator/sizeofoperations.htm
    public partial  class frmsizeofoperations:Form
    {
        public frmsizeofoperations()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmsizeofoperations
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmsizeofoperations";
            this.Text = "frmsizeofoperations";
            this.Load += new System.EventHandler(this.frmsizeofoperations_Load);
            this.ResumeLayout(false);

        }

        private void frmsizeofoperations_Load(object sender, EventArgs e)
        {

        }
    }
}
