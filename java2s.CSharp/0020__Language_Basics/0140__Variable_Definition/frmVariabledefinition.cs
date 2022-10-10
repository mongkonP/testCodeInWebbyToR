using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0020__Language_Basics.C0140__Variable_Definition
{
    //http://www.java2s.com/Tutorial/CSharp/0020__Language-Basics/Variabledefinition.htm
    public partial  class frmVariabledefinition:Form
    {
        public frmVariabledefinition()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmVariabledefinition
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmVariabledefinition";
            this.Text = "frmVariabledefinition";
            this.Load += new System.EventHandler(this.frmVariabledefinition_Load);
            this.ResumeLayout(false);

        }

        private void frmVariabledefinition_Load(object sender, EventArgs e)
        {

        }
    }
}
