namespace WinFormsAppMacKadrosu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBoxDizilis = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            comboBoxKaleciler = new ComboBox();
            comboBoxDefanslar = new ComboBox();
            comboBoxOrtaSaha = new ComboBox();
            comboBoxForvetler = new ComboBox();
            buttonKadroyaEkle = new Button();
            buttonKadrodanCikar = new Button();
            buttonKadroyuTemizle = new Button();
            listBoxMacKadrosu = new ListBox();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // comboBoxDizilis
            // 
            comboBoxDizilis.FormattingEnabled = true;
            comboBoxDizilis.Location = new Point(130, 113);
            comboBoxDizilis.Name = "comboBoxDizilis";
            comboBoxDizilis.Size = new Size(138, 26);
            comboBoxDizilis.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Text", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(15, 111);
            label1.Name = "label1";
            label1.Size = new Size(89, 35);
            label1.TabIndex = 1;
            label1.Text = "diziliş";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Text", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.Green;
            label2.Location = new Point(15, 256);
            label2.Name = "label2";
            label2.Size = new Size(97, 35);
            label2.TabIndex = 2;
            label2.Text = "Defans";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Text", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.Green;
            label3.Location = new Point(15, 214);
            label3.Name = "label3";
            label3.Size = new Size(85, 35);
            label3.TabIndex = 3;
            label3.Text = "kaleci";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Text", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.Green;
            label4.Location = new Point(15, 299);
            label4.Name = "label4";
            label4.Size = new Size(132, 35);
            label4.TabIndex = 4;
            label4.Text = "Orta Saha";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Text", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.ForeColor = Color.Green;
            label5.Location = new Point(15, 348);
            label5.Name = "label5";
            label5.Size = new Size(92, 35);
            label5.TabIndex = 5;
            label5.Text = "Forvet";
            // 
            // comboBoxKaleciler
            // 
            comboBoxKaleciler.FormattingEnabled = true;
            comboBoxKaleciler.Location = new Point(159, 214);
            comboBoxKaleciler.Name = "comboBoxKaleciler";
            comboBoxKaleciler.Size = new Size(138, 26);
            comboBoxKaleciler.TabIndex = 6;
            // 
            // comboBoxDefanslar
            // 
            comboBoxDefanslar.FormattingEnabled = true;
            comboBoxDefanslar.Location = new Point(159, 256);
            comboBoxDefanslar.Name = "comboBoxDefanslar";
            comboBoxDefanslar.Size = new Size(138, 26);
            comboBoxDefanslar.TabIndex = 7;
            // 
            // comboBoxOrtaSaha
            // 
            comboBoxOrtaSaha.FormattingEnabled = true;
            comboBoxOrtaSaha.Location = new Point(159, 308);
            comboBoxOrtaSaha.Name = "comboBoxOrtaSaha";
            comboBoxOrtaSaha.Size = new Size(138, 26);
            comboBoxOrtaSaha.TabIndex = 8;
            // 
            // comboBoxForvetler
            // 
            comboBoxForvetler.FormattingEnabled = true;
            comboBoxForvetler.Location = new Point(159, 348);
            comboBoxForvetler.Name = "comboBoxForvetler";
            comboBoxForvetler.Size = new Size(138, 26);
            comboBoxForvetler.TabIndex = 9;
            // 
            // buttonKadroyaEkle
            // 
            buttonKadroyaEkle.Location = new Point(379, 223);
            buttonKadroyaEkle.Name = "buttonKadroyaEkle";
            buttonKadroyaEkle.Size = new Size(141, 28);
            buttonKadroyaEkle.TabIndex = 10;
            buttonKadroyaEkle.Text = "Kadroya Ekle";
            buttonKadroyaEkle.UseVisualStyleBackColor = true;
            buttonKadroyaEkle.Click += buttonKadroyaEkle_Click;
            // 
            // buttonKadrodanCikar
            // 
            buttonKadrodanCikar.Location = new Point(379, 281);
            buttonKadrodanCikar.Name = "buttonKadrodanCikar";
            buttonKadrodanCikar.Size = new Size(141, 28);
            buttonKadrodanCikar.TabIndex = 11;
            buttonKadrodanCikar.Text = "Kadrodan Çıkar";
            buttonKadrodanCikar.UseVisualStyleBackColor = true;
            // 
            // buttonKadroyuTemizle
            // 
            buttonKadroyuTemizle.Location = new Point(379, 336);
            buttonKadroyuTemizle.Name = "buttonKadroyuTemizle";
            buttonKadroyuTemizle.Size = new Size(141, 28);
            buttonKadroyuTemizle.TabIndex = 12;
            buttonKadroyuTemizle.Text = "Kadroyu Temizle";
            buttonKadroyuTemizle.UseVisualStyleBackColor = true;
            // 
            // listBoxMacKadrosu
            // 
            listBoxMacKadrosu.FormattingEnabled = true;
            listBoxMacKadrosu.ItemHeight = 18;
            listBoxMacKadrosu.Location = new Point(627, 143);
            listBoxMacKadrosu.Name = "listBoxMacKadrosu";
            listBoxMacKadrosu.Size = new Size(257, 382);
            listBoxMacKadrosu.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sitka Text", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.Location = new Point(644, 99);
            label6.Name = "label6";
            label6.Size = new Size(191, 39);
            label6.TabIndex = 14;
            label6.Text = "Maç Kadrosu";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Sitka Text", 26.2499962F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label7.Location = new Point(215, 9);
            label7.Name = "label7";
            label7.Size = new Size(461, 50);
            label7.TabIndex = 15;
            label7.Text = "FENERBAHÇE 2024-2025";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(905, 533);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(listBoxMacKadrosu);
            Controls.Add(buttonKadroyuTemizle);
            Controls.Add(buttonKadrodanCikar);
            Controls.Add(buttonKadroyaEkle);
            Controls.Add(comboBoxForvetler);
            Controls.Add(comboBoxOrtaSaha);
            Controls.Add(comboBoxDefanslar);
            Controls.Add(comboBoxKaleciler);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxDizilis);
            Font = new Font("Sitka Small", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxDizilis;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox comboBoxKaleciler;
        private ComboBox comboBoxDefanslar;
        private ComboBox comboBoxOrtaSaha;
        private ComboBox comboBoxForvetler;
        private Button buttonKadroyaEkle;
        private Button buttonKadrodanCikar;
        private Button buttonKadroyuTemizle;
        private ListBox listBoxMacKadrosu;
        private Label label6;
        private Label label7;
    }
}
