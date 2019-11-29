namespace ProjektPożary
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.DmcLabel = new System.Windows.Forms.Label();
            this.DcLabel = new System.Windows.Forms.Label();
            this.DmcBox = new System.Windows.Forms.TextBox();
            this.DcBox = new System.Windows.Forms.TextBox();
            this.ResultButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.MounthBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Miesiąc";
            // 
            // DmcLabel
            // 
            this.DmcLabel.AutoSize = true;
            this.DmcLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.DmcLabel.Location = new System.Drawing.Point(12, 52);
            this.DmcLabel.Name = "DmcLabel";
            this.DmcLabel.Size = new System.Drawing.Size(58, 25);
            this.DmcLabel.TabIndex = 1;
            this.DmcLabel.Text = "DMC";
            // 
            // DcLabel
            // 
            this.DcLabel.AutoSize = true;
            this.DcLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.DcLabel.Location = new System.Drawing.Point(12, 95);
            this.DcLabel.Name = "DcLabel";
            this.DcLabel.Size = new System.Drawing.Size(41, 25);
            this.DcLabel.TabIndex = 2;
            this.DcLabel.Text = "DC";
            // 
            // DmcBox
            // 
            this.DmcBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.DmcBox.Location = new System.Drawing.Point(97, 49);
            this.DmcBox.Name = "DmcBox";
            this.DmcBox.Size = new System.Drawing.Size(100, 30);
            this.DmcBox.TabIndex = 4;
            // 
            // DcBox
            // 
            this.DcBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.DcBox.Location = new System.Drawing.Point(97, 92);
            this.DcBox.Name = "DcBox";
            this.DcBox.Size = new System.Drawing.Size(100, 30);
            this.DcBox.TabIndex = 5;
            // 
            // ResultButton
            // 
            this.ResultButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ResultButton.Location = new System.Drawing.Point(49, 166);
            this.ResultButton.Name = "ResultButton";
            this.ResultButton.Size = new System.Drawing.Size(115, 37);
            this.ResultButton.TabIndex = 6;
            this.ResultButton.Text = "Sprawdź";
            this.ResultButton.UseVisualStyleBackColor = true;
            this.ResultButton.Click += new System.EventHandler(this.ResultButton_Click);
            // 
            // MounthBox
            // 
            this.MounthBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.MounthBox.FormattingEnabled = true;
            this.MounthBox.Items.AddRange(new object[] {
            "Styczeń",
            "Luty",
            "Marzec",
            "Kwiecień",
            "Maj",
            "Czerwiec",
            "Lipiec",
            "Sierpień",
            "Wrzesień",
            "Październik",
            "Listopad",
            "Grudzień"});
            this.MounthBox.Location = new System.Drawing.Point(97, 6);
            this.MounthBox.Name = "MounthBox";
            this.MounthBox.Size = new System.Drawing.Size(100, 33);
            this.MounthBox.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 215);
            this.Controls.Add(this.MounthBox);
            this.Controls.Add(this.ResultButton);
            this.Controls.Add(this.DcBox);
            this.Controls.Add(this.DmcBox);
            this.Controls.Add(this.DcLabel);
            this.Controls.Add(this.DmcLabel);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label DmcLabel;
        private System.Windows.Forms.Label DcLabel;
        private System.Windows.Forms.TextBox DmcBox;
        private System.Windows.Forms.TextBox DcBox;
        private System.Windows.Forms.Button ResultButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox MounthBox;
    }
}

