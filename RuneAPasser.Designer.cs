namespace Dofus_Fm
{
    partial class RuneAPasser
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblCb = new MaterialSkin.Controls.MaterialLabel();
            this.imgRune = new System.Windows.Forms.PictureBox();
            this.lblRune = new MaterialSkin.Controls.MaterialLabel();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgRune)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(205, 46);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.lblCb);
            this.flowLayoutPanel1.Controls.Add(this.imgRune);
            this.flowLayoutPanel1.Controls.Add(this.lblRune);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(72, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(60, 40);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // lblCb
            // 
            this.lblCb.AutoSize = true;
            this.lblCb.Depth = 0;
            this.lblCb.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblCb.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCb.Location = new System.Drawing.Point(3, 0);
            this.lblCb.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCb.Name = "lblCb";
            this.lblCb.Size = new System.Drawing.Size(1, 46);
            this.lblCb.TabIndex = 0;
            this.lblCb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imgRune
            // 
            this.imgRune.Location = new System.Drawing.Point(10, 3);
            this.imgRune.Name = "imgRune";
            this.imgRune.Size = new System.Drawing.Size(40, 40);
            this.imgRune.TabIndex = 2;
            this.imgRune.TabStop = false;
            // 
            // lblRune
            // 
            this.lblRune.AutoSize = true;
            this.lblRune.Depth = 0;
            this.lblRune.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblRune.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblRune.Location = new System.Drawing.Point(56, 0);
            this.lblRune.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblRune.Name = "lblRune";
            this.lblRune.Size = new System.Drawing.Size(1, 46);
            this.lblRune.TabIndex = 3;
            this.lblRune.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RuneAPasser
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(205, 45);
            this.Name = "RuneAPasser";
            this.Size = new System.Drawing.Size(205, 46);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgRune)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MaterialSkin.Controls.MaterialLabel lblCb;
        private System.Windows.Forms.PictureBox imgRune;
        private MaterialSkin.Controls.MaterialLabel lblRune;
    }
}
