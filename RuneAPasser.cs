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
    public partial class RuneAPasser : UserControl
    {
        public RuneAPasser()
        {
            InitializeComponent();
        }

        public override string Text { 
            get => lblRune.Text;
            set => lblRune.Text = value; }

        public Image Image
        {
            get => imgRune.Image;
            set => imgRune.Image = value;
        }
        public string cbRunes
        {
            get => lblCb.Text;
            set => lblCb.Text = value;
        }
        public void Clear()
        {
            Image = null;
            cbRunes = string.Empty;
            Text = string.Empty;
        }
    }
}
