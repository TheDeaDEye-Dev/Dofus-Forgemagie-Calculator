using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dofus_Fm
{
    public partial class Historique : UserControl
    {
        public Historique()
        {
            InitializeComponent();
        }
        public Historique(Image imgrune1 , Image imgrune2 ,string time , string action , string total)
        {
            InitializeComponent();
            if(imgrune1!=null)
                picRune1.Image= imgrune1;
            else
                picRune1.Size = new Size(0,0);

            if(imgrune2!=null)
                picRune2.Image = imgrune2;
            else
                picRune2.Size = new Size(0,0);

            lblTotal.Text = total;
            lblAction.Text = action;
            lblTemps.Text = time;
        }

    }
}
