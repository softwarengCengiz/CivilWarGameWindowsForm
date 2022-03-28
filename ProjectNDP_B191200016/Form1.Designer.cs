
namespace ProjectNDP_B191200016
{
    partial class Form1
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
            this.bilgiPanel = new System.Windows.Forms.Panel();
            this.zorlukDereceLabel = new System.Windows.Forms.Label();
            this.anlıkZorlukLabel = new System.Windows.Forms.Label();
            this.skorLabel = new System.Windows.Forms.Label();
            this.skorYazıLabel = new System.Windows.Forms.Label();
            this.zamanLabel = new System.Windows.Forms.Label();
            this.bilgiLabel = new System.Windows.Forms.Label();
            this.savunmaPanel = new System.Windows.Forms.Panel();
            this.meydanPanel = new System.Windows.Forms.Panel();
            this.bilgiPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bilgiPanel
            // 
            this.bilgiPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bilgiPanel.Controls.Add(this.zorlukDereceLabel);
            this.bilgiPanel.Controls.Add(this.anlıkZorlukLabel);
            this.bilgiPanel.Controls.Add(this.skorLabel);
            this.bilgiPanel.Controls.Add(this.skorYazıLabel);
            this.bilgiPanel.Controls.Add(this.zamanLabel);
            this.bilgiPanel.Controls.Add(this.bilgiLabel);
            this.bilgiPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.bilgiPanel.Location = new System.Drawing.Point(0, 0);
            this.bilgiPanel.Name = "bilgiPanel";
            this.bilgiPanel.Size = new System.Drawing.Size(1443, 78);
            this.bilgiPanel.TabIndex = 0;
            // 
            // zorlukDereceLabel
            // 
            this.zorlukDereceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.zorlukDereceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.zorlukDereceLabel.Location = new System.Drawing.Point(1014, 37);
            this.zorlukDereceLabel.Name = "zorlukDereceLabel";
            this.zorlukDereceLabel.Size = new System.Drawing.Size(138, 39);
            this.zorlukDereceLabel.TabIndex = 5;
            this.zorlukDereceLabel.Text = "Basit";
            this.zorlukDereceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // anlıkZorlukLabel
            // 
            this.anlıkZorlukLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.anlıkZorlukLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.anlıkZorlukLabel.Location = new System.Drawing.Point(1014, 0);
            this.anlıkZorlukLabel.Name = "anlıkZorlukLabel";
            this.anlıkZorlukLabel.Size = new System.Drawing.Size(138, 39);
            this.anlıkZorlukLabel.TabIndex = 4;
            this.anlıkZorlukLabel.Text = "Anlık Zorluk :";
            this.anlıkZorlukLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // skorLabel
            // 
            this.skorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.skorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.skorLabel.Location = new System.Drawing.Point(612, 39);
            this.skorLabel.Name = "skorLabel";
            this.skorLabel.Size = new System.Drawing.Size(185, 39);
            this.skorLabel.TabIndex = 3;
            this.skorLabel.Text = "0";
            this.skorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.skorLabel.Visible = false;
            // 
            // skorYazıLabel
            // 
            this.skorYazıLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.skorYazıLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.skorYazıLabel.Location = new System.Drawing.Point(564, 0);
            this.skorYazıLabel.Name = "skorYazıLabel";
            this.skorYazıLabel.Size = new System.Drawing.Size(286, 39);
            this.skorYazıLabel.TabIndex = 2;
            this.skorYazıLabel.Text = "SKOR :";
            this.skorYazıLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.skorYazıLabel.Visible = false;
            // 
            // zamanLabel
            // 
            this.zamanLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.zamanLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.zamanLabel.Location = new System.Drawing.Point(1238, 9);
            this.zamanLabel.Name = "zamanLabel";
            this.zamanLabel.Size = new System.Drawing.Size(196, 54);
            this.zamanLabel.TabIndex = 1;
            this.zamanLabel.Text = "00:00";
            this.zamanLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bilgiLabel
            // 
            this.bilgiLabel.AutoSize = true;
            this.bilgiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bilgiLabel.Location = new System.Drawing.Point(3, 0);
            this.bilgiLabel.Name = "bilgiLabel";
            this.bilgiLabel.Size = new System.Drawing.Size(503, 72);
            this.bilgiLabel.TabIndex = 0;
            this.bilgiLabel.Text = "Oyunu başlatmak için ENTER tuşuna basın.\r\nHareket için sağ/sol YÖN tuşlarını kull" +
    "anın.\r\nAteş etmek için BOŞLUK tuşuna basın.\r\nOyunu durdurmak için \"P\", devam ett" +
    "irmek için \"R\" tuşuna basınız.\r\n";
            // 
            // savunmaPanel
            // 
            this.savunmaPanel.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.savunmaPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.savunmaPanel.Location = new System.Drawing.Point(0, 703);
            this.savunmaPanel.Name = "savunmaPanel";
            this.savunmaPanel.Size = new System.Drawing.Size(1443, 100);
            this.savunmaPanel.TabIndex = 1;
            // 
            // meydanPanel
            // 
            this.meydanPanel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.meydanPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.meydanPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.meydanPanel.Location = new System.Drawing.Point(0, 78);
            this.meydanPanel.Name = "meydanPanel";
            this.meydanPanel.Size = new System.Drawing.Size(1443, 625);
            this.meydanPanel.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1443, 803);
            this.Controls.Add(this.meydanPanel);
            this.Controls.Add(this.savunmaPanel);
            this.Controls.Add(this.bilgiPanel);
            this.Name = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.bilgiPanel.ResumeLayout(false);
            this.bilgiPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel bilgiPanel;
        private System.Windows.Forms.Label zamanLabel;
        private System.Windows.Forms.Label bilgiLabel;
        private System.Windows.Forms.Panel savunmaPanel;
        private System.Windows.Forms.Panel meydanPanel;
        private System.Windows.Forms.Label skorYazıLabel;
        public System.Windows.Forms.Label skorLabel;
        private System.Windows.Forms.Label zorlukDereceLabel;
        private System.Windows.Forms.Label anlıkZorlukLabel;
    }
}

