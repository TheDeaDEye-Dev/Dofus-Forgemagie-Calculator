using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using MaterialSkin.Controls; 

namespace Dofus_Fm
{
    public partial class Frm_Forgemagie : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        private double puit;
        public Frm_Forgemagie()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = false;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Green800, MaterialSkin.Primary.Green900, MaterialSkin.Primary.Green500, MaterialSkin.Accent.Red700, MaterialSkin.TextShade.WHITE);
        }
        private void Frm_Forgemagie_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;  //this = form
        }
        private void btnNums(object sender, EventArgs e)
        {
                switch (sender)
                {
                // plus
                case var a when a == btn_plus1:
                    puit += 1;
                    addHistory("Ajouté 1 puit ");
                    break;
                case var a when a == btn_plus2:
                    puit += 2;
                    addHistory("Ajouté 2 puit ");
                    break;
                case var a when a == btn_plus3:
                    puit += 3;
                    addHistory("Ajouté 3 puit ");
                    break;
                case var a when a == btn_plus5:
                    puit += 5;
                    addHistory("Ajouté 5 puit ");
                    break;
                    // moins
                case var a when a == btn_moins1:
                    if (puit >= 1)
                        puit -= 1;
                    addHistory("Retiré 1 puit ");
                    break;
                case var a when a == btn_moins2:
                    if (puit >= 2)
                        puit -= 2;
                    addHistory("Retiré 2 puit ");
                    break;
                case var a when a == btn_moins3:
                    if (puit >= 3)
                        puit -= 3;
                    addHistory("Retiré 3 puit ");
                    break;
                case var a when a == btn_moins5:
                    if (puit >= 5)
                        puit -= 5;
                    addHistory("Retiré 5 puit ");
                    break;
                default:
                        break;
                }
            lbl_puit.Text = puit + "";
        }

        private void panel_history_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;  //this = form
        }

        private void btn_calculPuit_Click(object sender, EventArgs e)
        {
            double puitSauter = double.Parse(Regex.Match(comboBox_RuneSauter.rune.weight, @"\d+").Value);
            double puitSauterAvec = double.Parse(Regex.Match(comboBox_RuneSauterAvec.rune.weight, @"\d+").Value);
            if (puitSauter > puitSauterAvec)
            {
                puit = puitSauter - puitSauterAvec;
            }
            lbl_puit.Text = puit +"";
            Historique historique = new Historique(imageList1.Images[int.Parse(comboBox_RuneSauter.rune.icon)], imageList1.Images[int.Parse(comboBox_RuneSauterAvec.rune.icon)], $"à {DateTime.Now.ToShortTimeString()}", $"{puit} puit généré ", $" Total : {puit}");
            panel_history.Controls.Add(historique);    
        }

        private void btn_retirer_Click(object sender, EventArgs e)
        {
            double oldpuit = puit;
            double puitRetirer = double.Parse(Regex.Match(comboBox_RuneRetirer.rune.weight, @"\d+").Value);
            if (puit >= puitRetirer)
                puit -= puitRetirer;
           runeRetirer1.Image = imageList1.Images[int.Parse(comboBox_RuneRetirer.rune.icon)];
           runeRetirer1.Text = comboBox_RuneRetirer.rune.label +$"  ({puitRetirer})";
            lbl_puit.Text = $"{oldpuit} - {puitRetirer} = {puit}";
            Historique historique = new Historique(imageList1.Images[int.Parse(comboBox_RuneRetirer.rune.icon)], null, $"à {DateTime.Now.ToShortTimeString()} ({comboBox_RuneRetirer.rune.label})", $"{puitRetirer} puit retiré ", $" Total : {puit}");
            panel_history.Controls.Add(historique);
        }

        private void btn_cbRunes_Click(object sender, EventArgs e)
        {
            int cbRunes = (int)(puit / Double.Parse(Regex.Match(comboBox_RuneAPasser.rune.weight, @"\d+").Value));
            double reste = puit % Double.Parse(Regex.Match(comboBox_RuneAPasser.rune.weight, @"\d+").Value);
            runeAPasser1.Image = imageList1.Images[int.Parse(comboBox_RuneAPasser.rune.icon)];
            runeAPasser1.Text = comboBox_RuneAPasser.rune.label;
            runeAPasser1.cbRunes = cbRunes + "x ";
            lbl_reste.Text = $"Il restera {reste} de puit.";
        }
        private void addHistory(string action)
        {
            Historique historique = new Historique(null, null, $"à {DateTime.Now.ToShortTimeString()} ", action, $" Total : {puit}");
            panel_history.Controls.Add(historique);
        }

        private void panel_history_SizeChanged(object sender, EventArgs e)
        {
            int count = panel_history.Controls.Count;
            if (count > 10 )
            {
             panel_history.AutoScroll = true;
            }
        }
    }
}
