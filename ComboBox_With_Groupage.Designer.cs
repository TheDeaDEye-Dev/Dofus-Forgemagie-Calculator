namespace Dofus_Fm
{
    partial class ComboBox_With_Groupage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComboBox_With_Groupage));
            this.txt_box = new MaterialSkin.Controls.MaterialTextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // txt_box
            // 
            this.txt_box.AnimateReadOnly = false;
            this.txt_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_box.Depth = 0;
            this.txt_box.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_box.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_box.Hint = "Sélectionnez la rune qui a sauté";
            this.txt_box.LeadingIcon = null;
            this.txt_box.Location = new System.Drawing.Point(0, 0);
            this.txt_box.MaximumSize = new System.Drawing.Size(275, 50);
            this.txt_box.MaxLength = 50;
            this.txt_box.MinimumSize = new System.Drawing.Size(275, 50);
            this.txt_box.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_box.Multiline = false;
            this.txt_box.Name = "txt_box";
            this.txt_box.Size = new System.Drawing.Size(275, 50);
            this.txt_box.TabIndex = 0;
            this.txt_box.Text = "";
            this.txt_box.TrailingIcon = null;
            this.txt_box.TextChanged += new System.EventHandler(this.txt_box_TextChanged);
            this.txt_box.Enter += new System.EventHandler(this.txt_box_Enter);
            this.txt_box.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_box_KeyDown);
            this.txt_box.Leave += new System.EventHandler(this.txt_box_Leave);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.White;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.listView1.FullRowSelect = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 50);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(275, 362);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 155;
            // 
            // columnHeader2
            // 
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader2.Width = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 399);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
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
            // ComboBox_With_Groupage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.txt_box);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(275, 50);
            this.Name = "ComboBox_With_Groupage";
            this.Size = new System.Drawing.Size(275, 412);
            this.Load += new System.EventHandler(this.ComboBox_With_Groupage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

#pragma warning disable CS0618 // Type or member is obsolete
        private MaterialSkin.Controls.MaterialTextBox txt_box;
#pragma warning restore CS0618 // Type or member is obsolete
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ImageList imageList1;
    }
}
