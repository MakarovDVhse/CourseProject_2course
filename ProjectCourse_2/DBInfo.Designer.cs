
namespace ProjectCourse_2
{
    partial class DBInfo
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
            this.CancelButton = new System.Windows.Forms.Button();
            this.CrButton = new System.Windows.Forms.Button();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.RegionBox = new System.Windows.Forms.TextBox();
            this.CountryBox = new System.Windows.Forms.TextBox();
            this.ExtraInfoBox = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelButton.Location = new System.Drawing.Point(598, 321);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(190, 62);
            this.CancelButton.TabIndex = 20;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // CrButton
            // 
            this.CrButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CrButton.Location = new System.Drawing.Point(373, 321);
            this.CrButton.Name = "CrButton";
            this.CrButton.Size = new System.Drawing.Size(190, 62);
            this.CrButton.TabIndex = 19;
            this.CrButton.Text = "Изменить";
            this.CrButton.UseVisualStyleBackColor = true;
            this.CrButton.Click += new System.EventHandler(this.CrButton_Click);
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(172, 130);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(299, 22);
            this.NameBox.TabIndex = 18;
            this.NameBox.TextChanged += new System.EventHandler(this.NameBox_TextChanged);
            // 
            // RegionBox
            // 
            this.RegionBox.Location = new System.Drawing.Point(172, 80);
            this.RegionBox.Name = "RegionBox";
            this.RegionBox.Size = new System.Drawing.Size(299, 22);
            this.RegionBox.TabIndex = 17;
            this.RegionBox.TextChanged += new System.EventHandler(this.RegionBox_TextChanged);
            // 
            // CountryBox
            // 
            this.CountryBox.Location = new System.Drawing.Point(172, 32);
            this.CountryBox.Name = "CountryBox";
            this.CountryBox.Size = new System.Drawing.Size(299, 22);
            this.CountryBox.TabIndex = 16;
            this.CountryBox.TextChanged += new System.EventHandler(this.CountryBox_TextChanged);
            // 
            // ExtraInfoBox
            // 
            this.ExtraInfoBox.Location = new System.Drawing.Point(16, 198);
            this.ExtraInfoBox.Name = "ExtraInfoBox";
            this.ExtraInfoBox.Size = new System.Drawing.Size(772, 107);
            this.ExtraInfoBox.TabIndex = 15;
            this.ExtraInfoBox.Text = "";
            this.ExtraInfoBox.TextChanged += new System.EventHandler(this.ExtraInfoBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label5.Location = new System.Drawing.Point(12, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(272, 22);
            this.label5.TabIndex = 14;
            this.label5.Text = "Дополнительная информация:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label4.Location = new System.Drawing.Point(12, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 22);
            this.label4.TabIndex = 13;
            this.label4.Text = "Наименование:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label3.Location = new System.Drawing.Point(12, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 22);
            this.label3.TabIndex = 12;
            this.label3.Text = "Регион:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 22);
            this.label2.TabIndex = 11;
            this.label2.Text = "Страна:\r\n";
            // 
            // DBInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 395);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.CrButton);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.RegionBox);
            this.Controls.Add(this.CountryBox);
            this.Controls.Add(this.ExtraInfoBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "DBInfo";
            this.Text = "Доп. информация";
            this.Load += new System.EventHandler(this.DBInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button CrButton;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox RegionBox;
        private System.Windows.Forms.TextBox CountryBox;
        private System.Windows.Forms.RichTextBox ExtraInfoBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}