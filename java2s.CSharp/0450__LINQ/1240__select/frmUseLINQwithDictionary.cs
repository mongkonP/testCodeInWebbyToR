using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C1240__select
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/UseLINQwithDictionary.htm
    public partial  class frmUseLINQwithDictionary:Form
    {
        public frmUseLINQwithDictionary()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseLINQwithDictionary
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseLINQwithDictionary";
            this.Text = "frmUseLINQwithDictionary";
            this.Load += new System.EventHandler(this.frmUseLINQwithDictionary_Load);
            this.ResumeLayout(false);

        }

        private void frmUseLINQwithDictionary_Load(object sender, EventArgs e)
        {

        }
    }
}
