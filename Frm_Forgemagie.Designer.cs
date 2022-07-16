namespace Dofus_Fm
{
    partial class Frm_Forgemagie
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Forgemagie));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_history = new System.Windows.Forms.FlowLayoutPanel();
            this.runeAPasser1 = new Dofus_Fm.RuneAPasser();
            this.runeRetirer1 = new Dofus_Fm.RuneRetirer();
            this.lbl_puit = new MaterialSkin.Controls.MaterialLabel();
            this.comboBox_RuneAPasser = new Dofus_Fm.ComboBox_With_Groupage();
            this.comboBox_RuneRetirer = new Dofus_Fm.ComboBox_With_Groupage();
            this.comboBox_RuneSauterAvec = new Dofus_Fm.ComboBox_With_Groupage();
            this.comboBox_RuneSauter = new Dofus_Fm.ComboBox_With_Groupage();
            this.lbl_reste = new MaterialSkin.Controls.MaterialLabel();
            this.btn_cbRunes = new MaterialSkin.Controls.MaterialButton();
            this.btn_retirer = new MaterialSkin.Controls.MaterialButton();
            this.btn_plus5 = new MaterialSkin.Controls.MaterialButton();
            this.btn_plus3 = new MaterialSkin.Controls.MaterialButton();
            this.btn_plus2 = new MaterialSkin.Controls.MaterialButton();
            this.btn_plus1 = new MaterialSkin.Controls.MaterialButton();
            this.btn_moins5 = new MaterialSkin.Controls.MaterialButton();
            this.btn_moins3 = new MaterialSkin.Controls.MaterialButton();
            this.btn_moins2 = new MaterialSkin.Controls.MaterialButton();
            this.btn_moins1 = new MaterialSkin.Controls.MaterialButton();
            this.btn_calculPuit = new MaterialSkin.Controls.MaterialButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = global::Dofus_Fm.Properties.Resources.form;
            this.panel1.Controls.Add(this.panel_history);
            this.panel1.Controls.Add(this.runeAPasser1);
            this.panel1.Controls.Add(this.runeRetirer1);
            this.panel1.Controls.Add(this.lbl_puit);
            this.panel1.Controls.Add(this.comboBox_RuneAPasser);
            this.panel1.Controls.Add(this.comboBox_RuneRetirer);
            this.panel1.Controls.Add(this.comboBox_RuneSauterAvec);
            this.panel1.Controls.Add(this.comboBox_RuneSauter);
            this.panel1.Controls.Add(this.lbl_reste);
            this.panel1.Controls.Add(this.btn_cbRunes);
            this.panel1.Controls.Add(this.btn_retirer);
            this.panel1.Controls.Add(this.btn_plus5);
            this.panel1.Controls.Add(this.btn_plus3);
            this.panel1.Controls.Add(this.btn_plus2);
            this.panel1.Controls.Add(this.btn_plus1);
            this.panel1.Controls.Add(this.btn_moins5);
            this.panel1.Controls.Add(this.btn_moins3);
            this.panel1.Controls.Add(this.btn_moins2);
            this.panel1.Controls.Add(this.btn_moins1);
            this.panel1.Controls.Add(this.btn_calculPuit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1056, 644);
            this.panel1.TabIndex = 0;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // panel_history
            // 
            this.panel_history.AutoSize = true;
            this.panel_history.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_history.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.panel_history.Location = new System.Drawing.Point(736, 64);
            this.panel_history.MaximumSize = new System.Drawing.Size(304, 570);
            this.panel_history.MinimumSize = new System.Drawing.Size(304, 0);
            this.panel_history.Name = "panel_history";
            this.panel_history.Size = new System.Drawing.Size(304, 0);
            this.panel_history.TabIndex = 37;
            this.panel_history.WrapContents = false;
            this.panel_history.SizeChanged += new System.EventHandler(this.panel_history_SizeChanged);
            // 
            // runeAPasser1
            // 
            this.runeAPasser1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.runeAPasser1.BackColor = System.Drawing.Color.White;
            this.runeAPasser1.cbRunes = "";
            this.runeAPasser1.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runeAPasser1.Image = null;
            this.runeAPasser1.Location = new System.Drawing.Point(367, 524);
            this.runeAPasser1.MinimumSize = new System.Drawing.Size(205, 45);
            this.runeAPasser1.Name = "runeAPasser1";
            this.runeAPasser1.Size = new System.Drawing.Size(326, 46);
            this.runeAPasser1.TabIndex = 36;
            // 
            // runeRetirer1
            // 
            this.runeRetirer1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.runeRetirer1.BackColor = System.Drawing.Color.White;
            this.runeRetirer1.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runeRetirer1.Image = null;
            this.runeRetirer1.Location = new System.Drawing.Point(411, 341);
            this.runeRetirer1.MinimumSize = new System.Drawing.Size(205, 45);
            this.runeRetirer1.Name = "runeRetirer1";
            this.runeRetirer1.Size = new System.Drawing.Size(233, 46);
            this.runeRetirer1.TabIndex = 35;
            // 
            // lbl_puit
            // 
            this.lbl_puit.Depth = 0;
            this.lbl_puit.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_puit.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lbl_puit.Location = new System.Drawing.Point(368, 70);
            this.lbl_puit.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_puit.Name = "lbl_puit";
            this.lbl_puit.Size = new System.Drawing.Size(325, 24);
            this.lbl_puit.TabIndex = 34;
            this.lbl_puit.Text = "0";
            this.lbl_puit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox_RuneAPasser
            // 
            this.comboBox_RuneAPasser.DropToTop = true;
            this.comboBox_RuneAPasser.Location = new System.Drawing.Point(31, 520);
            this.comboBox_RuneAPasser.MaximumSize = new System.Drawing.Size(275, 547);
            this.comboBox_RuneAPasser.MinimumSize = new System.Drawing.Size(275, 50);
            this.comboBox_RuneAPasser.Name = "comboBox_RuneAPasser";
            this.comboBox_RuneAPasser.Size = new System.Drawing.Size(275, 50);
            this.comboBox_RuneAPasser.TabIndex = 33;
            // 
            // comboBox_RuneRetirer
            // 
            this.comboBox_RuneRetirer.DropToTop = false;
            this.comboBox_RuneRetirer.Location = new System.Drawing.Point(31, 337);
            this.comboBox_RuneRetirer.MaximumSize = new System.Drawing.Size(275, 304);
            this.comboBox_RuneRetirer.MinimumSize = new System.Drawing.Size(275, 50);
            this.comboBox_RuneRetirer.Name = "comboBox_RuneRetirer";
            this.comboBox_RuneRetirer.Size = new System.Drawing.Size(275, 50);
            this.comboBox_RuneRetirer.TabIndex = 32;
            // 
            // comboBox_RuneSauterAvec
            // 
            this.comboBox_RuneSauterAvec.DropToTop = false;
            this.comboBox_RuneSauterAvec.Location = new System.Drawing.Point(31, 126);
            this.comboBox_RuneSauterAvec.MaximumSize = new System.Drawing.Size(275, 501);
            this.comboBox_RuneSauterAvec.MinimumSize = new System.Drawing.Size(275, 50);
            this.comboBox_RuneSauterAvec.Name = "comboBox_RuneSauterAvec";
            this.comboBox_RuneSauterAvec.Size = new System.Drawing.Size(275, 50);
            this.comboBox_RuneSauterAvec.TabIndex = 31;
            // 
            // comboBox_RuneSauter
            // 
            this.comboBox_RuneSauter.DropToTop = false;
            this.comboBox_RuneSauter.Location = new System.Drawing.Point(31, 70);
            this.comboBox_RuneSauter.MaximumSize = new System.Drawing.Size(275, 577);
            this.comboBox_RuneSauter.MinimumSize = new System.Drawing.Size(275, 50);
            this.comboBox_RuneSauter.Name = "comboBox_RuneSauter";
            this.comboBox_RuneSauter.Size = new System.Drawing.Size(275, 50);
            this.comboBox_RuneSauter.TabIndex = 30;
            // 
            // lbl_reste
            // 
            this.lbl_reste.Depth = 0;
            this.lbl_reste.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_reste.Location = new System.Drawing.Point(372, 589);
            this.lbl_reste.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_reste.Name = "lbl_reste";
            this.lbl_reste.Size = new System.Drawing.Size(321, 19);
            this.lbl_reste.TabIndex = 28;
            this.lbl_reste.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_cbRunes
            // 
            this.btn_cbRunes.AutoSize = false;
            this.btn_cbRunes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_cbRunes.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_cbRunes.Depth = 0;
            this.btn_cbRunes.HighEmphasis = true;
            this.btn_cbRunes.Icon = null;
            this.btn_cbRunes.Location = new System.Drawing.Point(84, 579);
            this.btn_cbRunes.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_cbRunes.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_cbRunes.Name = "btn_cbRunes";
            this.btn_cbRunes.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_cbRunes.Size = new System.Drawing.Size(170, 36);
            this.btn_cbRunes.TabIndex = 26;
            this.btn_cbRunes.Text = "Combien de runes ?";
            this.btn_cbRunes.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_cbRunes.UseAccentColor = false;
            this.btn_cbRunes.UseVisualStyleBackColor = true;
            this.btn_cbRunes.Click += new System.EventHandler(this.btn_cbRunes_Click);
            // 
            // btn_retirer
            // 
            this.btn_retirer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_retirer.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_retirer.Depth = 0;
            this.btn_retirer.HighEmphasis = true;
            this.btn_retirer.Icon = null;
            this.btn_retirer.Location = new System.Drawing.Point(132, 392);
            this.btn_retirer.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_retirer.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_retirer.Name = "btn_retirer";
            this.btn_retirer.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_retirer.Size = new System.Drawing.Size(79, 36);
            this.btn_retirer.TabIndex = 24;
            this.btn_retirer.Text = "Retirer";
            this.btn_retirer.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_retirer.UseAccentColor = false;
            this.btn_retirer.UseVisualStyleBackColor = true;
            this.btn_retirer.Click += new System.EventHandler(this.btn_retirer_Click);
            // 
            // btn_plus5
            // 
            this.btn_plus5.AutoSize = false;
            this.btn_plus5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_plus5.BackColor = System.Drawing.Color.Azure;
            this.btn_plus5.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_plus5.Depth = 0;
            this.btn_plus5.HighEmphasis = true;
            this.btn_plus5.Icon = null;
            this.btn_plus5.Location = new System.Drawing.Point(600, 110);
            this.btn_plus5.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_plus5.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_plus5.Name = "btn_plus5";
            this.btn_plus5.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_plus5.Size = new System.Drawing.Size(44, 36);
            this.btn_plus5.TabIndex = 22;
            this.btn_plus5.Text = "+ 5";
            this.btn_plus5.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_plus5.UseAccentColor = false;
            this.btn_plus5.UseVisualStyleBackColor = false;
            this.btn_plus5.Click += new System.EventHandler(this.btnNums);
            // 
            // btn_plus3
            // 
            this.btn_plus3.AutoSize = false;
            this.btn_plus3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_plus3.BackColor = System.Drawing.Color.Azure;
            this.btn_plus3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_plus3.Depth = 0;
            this.btn_plus3.HighEmphasis = true;
            this.btn_plus3.Icon = null;
            this.btn_plus3.Location = new System.Drawing.Point(537, 110);
            this.btn_plus3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_plus3.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_plus3.Name = "btn_plus3";
            this.btn_plus3.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_plus3.Size = new System.Drawing.Size(44, 36);
            this.btn_plus3.TabIndex = 21;
            this.btn_plus3.Text = "+ 3";
            this.btn_plus3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_plus3.UseAccentColor = false;
            this.btn_plus3.UseVisualStyleBackColor = false;
            this.btn_plus3.Click += new System.EventHandler(this.btnNums);
            // 
            // btn_plus2
            // 
            this.btn_plus2.AutoSize = false;
            this.btn_plus2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_plus2.BackColor = System.Drawing.Color.Azure;
            this.btn_plus2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_plus2.Depth = 0;
            this.btn_plus2.HighEmphasis = true;
            this.btn_plus2.Icon = null;
            this.btn_plus2.Location = new System.Drawing.Point(474, 110);
            this.btn_plus2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_plus2.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_plus2.Name = "btn_plus2";
            this.btn_plus2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_plus2.Size = new System.Drawing.Size(44, 36);
            this.btn_plus2.TabIndex = 20;
            this.btn_plus2.Text = "+ 2";
            this.btn_plus2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_plus2.UseAccentColor = false;
            this.btn_plus2.UseVisualStyleBackColor = false;
            this.btn_plus2.Click += new System.EventHandler(this.btnNums);
            // 
            // btn_plus1
            // 
            this.btn_plus1.AutoSize = false;
            this.btn_plus1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_plus1.BackColor = System.Drawing.Color.Azure;
            this.btn_plus1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_plus1.Depth = 0;
            this.btn_plus1.HighEmphasis = true;
            this.btn_plus1.Icon = null;
            this.btn_plus1.Location = new System.Drawing.Point(411, 110);
            this.btn_plus1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_plus1.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_plus1.Name = "btn_plus1";
            this.btn_plus1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_plus1.Size = new System.Drawing.Size(44, 36);
            this.btn_plus1.TabIndex = 19;
            this.btn_plus1.Text = "+ 1";
            this.btn_plus1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_plus1.UseAccentColor = false;
            this.btn_plus1.UseVisualStyleBackColor = false;
            this.btn_plus1.Click += new System.EventHandler(this.btnNums);
            // 
            // btn_moins5
            // 
            this.btn_moins5.AutoSize = false;
            this.btn_moins5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_moins5.BackColor = System.Drawing.Color.Azure;
            this.btn_moins5.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_moins5.Depth = 0;
            this.btn_moins5.HighEmphasis = true;
            this.btn_moins5.Icon = null;
            this.btn_moins5.Location = new System.Drawing.Point(600, 180);
            this.btn_moins5.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_moins5.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_moins5.Name = "btn_moins5";
            this.btn_moins5.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_moins5.Size = new System.Drawing.Size(44, 36);
            this.btn_moins5.TabIndex = 18;
            this.btn_moins5.Text = "- 5";
            this.btn_moins5.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_moins5.UseAccentColor = true;
            this.btn_moins5.UseVisualStyleBackColor = false;
            this.btn_moins5.Click += new System.EventHandler(this.btnNums);
            // 
            // btn_moins3
            // 
            this.btn_moins3.AutoSize = false;
            this.btn_moins3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_moins3.BackColor = System.Drawing.Color.Azure;
            this.btn_moins3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_moins3.Depth = 0;
            this.btn_moins3.HighEmphasis = true;
            this.btn_moins3.Icon = null;
            this.btn_moins3.Location = new System.Drawing.Point(537, 180);
            this.btn_moins3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_moins3.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_moins3.Name = "btn_moins3";
            this.btn_moins3.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_moins3.Size = new System.Drawing.Size(44, 36);
            this.btn_moins3.TabIndex = 17;
            this.btn_moins3.Text = "- 3";
            this.btn_moins3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_moins3.UseAccentColor = true;
            this.btn_moins3.UseVisualStyleBackColor = false;
            this.btn_moins3.Click += new System.EventHandler(this.btnNums);
            // 
            // btn_moins2
            // 
            this.btn_moins2.AutoSize = false;
            this.btn_moins2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_moins2.BackColor = System.Drawing.Color.Azure;
            this.btn_moins2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_moins2.Depth = 0;
            this.btn_moins2.HighEmphasis = true;
            this.btn_moins2.Icon = null;
            this.btn_moins2.Location = new System.Drawing.Point(474, 180);
            this.btn_moins2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_moins2.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_moins2.Name = "btn_moins2";
            this.btn_moins2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_moins2.Size = new System.Drawing.Size(44, 36);
            this.btn_moins2.TabIndex = 16;
            this.btn_moins2.Text = "- 2";
            this.btn_moins2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_moins2.UseAccentColor = true;
            this.btn_moins2.UseVisualStyleBackColor = false;
            this.btn_moins2.Click += new System.EventHandler(this.btnNums);
            // 
            // btn_moins1
            // 
            this.btn_moins1.AutoSize = false;
            this.btn_moins1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_moins1.BackColor = System.Drawing.Color.Azure;
            this.btn_moins1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_moins1.Depth = 0;
            this.btn_moins1.HighEmphasis = true;
            this.btn_moins1.Icon = null;
            this.btn_moins1.Location = new System.Drawing.Point(411, 180);
            this.btn_moins1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_moins1.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_moins1.Name = "btn_moins1";
            this.btn_moins1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_moins1.Size = new System.Drawing.Size(44, 36);
            this.btn_moins1.TabIndex = 15;
            this.btn_moins1.Text = "- 1";
            this.btn_moins1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_moins1.UseAccentColor = true;
            this.btn_moins1.UseVisualStyleBackColor = false;
            this.btn_moins1.Click += new System.EventHandler(this.btnNums);
            // 
            // btn_calculPuit
            // 
            this.btn_calculPuit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_calculPuit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_calculPuit.Depth = 0;
            this.btn_calculPuit.HighEmphasis = true;
            this.btn_calculPuit.Icon = null;
            this.btn_calculPuit.Location = new System.Drawing.Point(104, 188);
            this.btn_calculPuit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_calculPuit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_calculPuit.Name = "btn_calculPuit";
            this.btn_calculPuit.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_calculPuit.Size = new System.Drawing.Size(129, 36);
            this.btn_calculPuit.TabIndex = 7;
            this.btn_calculPuit.Text = "Calculer Puit";
            this.btn_calculPuit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_calculPuit.UseAccentColor = false;
            this.btn_calculPuit.UseVisualStyleBackColor = true;
            this.btn_calculPuit.Click += new System.EventHandler(this.btn_calculPuit_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Rune Age (1).png");
            this.imageList1.Images.SetKeyName(1, "Rune Cha (1).png");
            this.imageList1.Images.SetKeyName(2, "Rune Cri (10).png");
            this.imageList1.Images.SetKeyName(3, "Rune de chasse (-1).png");
            this.imageList1.Images.SetKeyName(4, "Rune Do (20).png");
            this.imageList1.Images.SetKeyName(5, "Rune Do Air (5).png");
            this.imageList1.Images.SetKeyName(6, "Rune Do Cri (5).png");
            this.imageList1.Images.SetKeyName(7, "Rune Do Eau (5).png");
            this.imageList1.Images.SetKeyName(8, "Rune Do Feu (5).png");
            this.imageList1.Images.SetKeyName(9, "Rune Do Neutre (5).png");
            this.imageList1.Images.SetKeyName(10, "Rune Do Per Ar (15).png");
            this.imageList1.Images.SetKeyName(11, "Rune Do Per Di (15).png");
            this.imageList1.Images.SetKeyName(12, "Rune Do Per Mé (15).png");
            this.imageList1.Images.SetKeyName(13, "Rune Do Per So (15).png");
            this.imageList1.Images.SetKeyName(14, "Rune Do Pou (5).png");
            this.imageList1.Images.SetKeyName(15, "Rune Do Ren (10).png");
            this.imageList1.Images.SetKeyName(16, "Rune Do Terre (5).png");
            this.imageList1.Images.SetKeyName(17, "Rune Fo (1).png");
            this.imageList1.Images.SetKeyName(18, "Rune Fui (4).png");
            this.imageList1.Images.SetKeyName(19, "Rune Ga Pa (100).png");
            this.imageList1.Images.SetKeyName(20, "Rune Ga Pme (90).png");
            this.imageList1.Images.SetKeyName(21, "Rune Ine (1).png");
            this.imageList1.Images.SetKeyName(22, "Rune Ini (1).png");
            this.imageList1.Images.SetKeyName(23, "Rune Invo (30).png");
            this.imageList1.Images.SetKeyName(24, "Rune Pa Age (3).png");
            this.imageList1.Images.SetKeyName(25, "Rune Pa Cha (3).png");
            this.imageList1.Images.SetKeyName(26, "Rune Pa Do Air (15).png");
            this.imageList1.Images.SetKeyName(27, "Rune Pa Do Cri (15).png");
            this.imageList1.Images.SetKeyName(28, "Rune Pa Do Eau (15).png");
            this.imageList1.Images.SetKeyName(29, "Rune Pa Do Feu (15).png");
            this.imageList1.Images.SetKeyName(30, "Rune Pa Do Neutre (15).png");
            this.imageList1.Images.SetKeyName(31, "Rune Pa Do Pou (15).png");
            this.imageList1.Images.SetKeyName(32, "Rune Pa Do Terre (15).png");
            this.imageList1.Images.SetKeyName(33, "Rune Pa Fo (3).png");
            this.imageList1.Images.SetKeyName(34, "Rune Pa Fui (12).png");
            this.imageList1.Images.SetKeyName(35, "Rune Pa Ine (3).png");
            this.imageList1.Images.SetKeyName(36, "Rune Pa Ini (3).png");
            this.imageList1.Images.SetKeyName(37, "Rune Pa Pi (15).png");
            this.imageList1.Images.SetKeyName(38, "Rune Pa Pi Per (6).png");
            this.imageList1.Images.SetKeyName(39, "Rune Pa Pod (7.5).png");
            this.imageList1.Images.SetKeyName(40, "Rune Pa Prospe (9).png");
            this.imageList1.Images.SetKeyName(41, "Rune Pa Pui (6).png");
            this.imageList1.Images.SetKeyName(42, "Rune Pa Ré Air (6).png");
            this.imageList1.Images.SetKeyName(43, "Rune Pa Ré Cri (6).png");
            this.imageList1.Images.SetKeyName(44, "Rune Pa Ré Eau (6).png");
            this.imageList1.Images.SetKeyName(45, "Rune Pa Ré Feu (6).png");
            this.imageList1.Images.SetKeyName(46, "Rune Pa Ré Neutre (6).png");
            this.imageList1.Images.SetKeyName(47, "Rune Pa Ré Pa (21).png");
            this.imageList1.Images.SetKeyName(48, "Rune Pa Ré Pme (21).png");
            this.imageList1.Images.SetKeyName(49, "Rune Pa Ré Pou (6).png");
            this.imageList1.Images.SetKeyName(50, "Rune Pa Ré Terre (6).png");
            this.imageList1.Images.SetKeyName(51, "Rune Pa Ret Pa (21).png");
            this.imageList1.Images.SetKeyName(52, "Rune Pa Ret Pme (21).png");
            this.imageList1.Images.SetKeyName(53, "Rune Pa Sa (9).png");
            this.imageList1.Images.SetKeyName(54, "Rune Pa So (30).png");
            this.imageList1.Images.SetKeyName(55, "Rune Pa Tac (12).png");
            this.imageList1.Images.SetKeyName(56, "Rune Pa Vi (3).png");
            this.imageList1.Images.SetKeyName(57, "Rune Pi (5).png");
            this.imageList1.Images.SetKeyName(58, "Rune Pi Per (2).png");
            this.imageList1.Images.SetKeyName(59, "Rune Po (51).png");
            this.imageList1.Images.SetKeyName(60, "Rune Pod (2.5).png");
            this.imageList1.Images.SetKeyName(61, "Rune Prospe (3).png");
            this.imageList1.Images.SetKeyName(62, "Rune Pui (2).png");
            this.imageList1.Images.SetKeyName(63, "Rune Ra Age (10).png");
            this.imageList1.Images.SetKeyName(64, "Rune Ra Cha (10).png");
            this.imageList1.Images.SetKeyName(65, "Rune Ra Fo (10).png");
            this.imageList1.Images.SetKeyName(66, "Rune Ra Ine (10).png");
            this.imageList1.Images.SetKeyName(67, "Rune Ra Ini (10).png");
            this.imageList1.Images.SetKeyName(68, "Rune Ra Pi Per (20).png");
            this.imageList1.Images.SetKeyName(69, "Rune Ra Pod (25.0).png");
            this.imageList1.Images.SetKeyName(70, "Rune Ra Pui (20).png");
            this.imageList1.Images.SetKeyName(71, "Rune Ra Sa (30).png");
            this.imageList1.Images.SetKeyName(72, "Rune Ra Vi (10).png");
            this.imageList1.Images.SetKeyName(73, "Rune Ré Air (2).png");
            this.imageList1.Images.SetKeyName(74, "Rune Ré Cri (2).png");
            this.imageList1.Images.SetKeyName(75, "Rune Ré Eau (2).png");
            this.imageList1.Images.SetKeyName(76, "Rune Ré Feu (2).png");
            this.imageList1.Images.SetKeyName(77, "Rune Ré Neutre (2).png");
            this.imageList1.Images.SetKeyName(78, "Rune Ré Pa (7).png");
            this.imageList1.Images.SetKeyName(79, "Rune Ré Per Air (6).png");
            this.imageList1.Images.SetKeyName(80, "Rune Ré Per Di (15).png");
            this.imageList1.Images.SetKeyName(81, "Rune Ré Per Eau (6).png");
            this.imageList1.Images.SetKeyName(82, "Rune Ré Per Feu (6).png");
            this.imageList1.Images.SetKeyName(83, "Rune Ré Per Mé (15).png");
            this.imageList1.Images.SetKeyName(84, "Rune Ré Per Neutre (6).png");
            this.imageList1.Images.SetKeyName(85, "Rune Ré Per Terre (6).png");
            this.imageList1.Images.SetKeyName(86, "Rune Ré Pme (7).png");
            this.imageList1.Images.SetKeyName(87, "Rune Ré Pou (2).png");
            this.imageList1.Images.SetKeyName(88, "Rune Ré Terre (2).png");
            this.imageList1.Images.SetKeyName(89, "Rune Ret Pa (7).png");
            this.imageList1.Images.SetKeyName(90, "Rune Ret Pme (7).png");
            this.imageList1.Images.SetKeyName(91, "Rune Sa (3).png");
            this.imageList1.Images.SetKeyName(92, "Rune So (10).png");
            this.imageList1.Images.SetKeyName(93, "Rune Tac (4).png");
            this.imageList1.Images.SetKeyName(94, "Rune Vi (1).png");
            // 
            // Frm_Forgemagie
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1062, 711);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_Forgemagie";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dofus Forgemagie";
            this.Load += new System.EventHandler(this.Frm_Forgemagie_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialButton btn_calculPuit;
        private MaterialSkin.Controls.MaterialButton btn_plus5;
        private MaterialSkin.Controls.MaterialButton btn_plus3;
        private MaterialSkin.Controls.MaterialButton btn_plus2;
        private MaterialSkin.Controls.MaterialButton btn_plus1;
        private MaterialSkin.Controls.MaterialButton btn_moins5;
        private MaterialSkin.Controls.MaterialButton btn_moins3;
        private MaterialSkin.Controls.MaterialButton btn_moins2;
        private MaterialSkin.Controls.MaterialButton btn_moins1;
        private MaterialSkin.Controls.MaterialButton btn_retirer;
        private MaterialSkin.Controls.MaterialButton btn_cbRunes;
        private MaterialSkin.Controls.MaterialLabel lbl_reste;
        private ComboBox_With_Groupage comboBox_RuneSauter;
        private ComboBox_With_Groupage comboBox_RuneAPasser;
        private ComboBox_With_Groupage comboBox_RuneRetirer;
        private ComboBox_With_Groupage comboBox_RuneSauterAvec;
        private System.Windows.Forms.ImageList imageList1;
        private RuneRetirer runeRetirer1;
        private RuneAPasser runeAPasser1;
        private MaterialSkin.Controls.MaterialLabel lbl_puit;
        private System.Windows.Forms.FlowLayoutPanel panel_history;
    }
}