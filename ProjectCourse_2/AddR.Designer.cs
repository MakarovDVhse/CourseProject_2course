
namespace ProjectCourse_2
{
    partial class AddR
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
            this.CancelAddR = new System.Windows.Forms.Button();
            this.ToDraswingR = new System.Windows.Forms.Button();
            this.RFilter = new System.Windows.Forms.ComboBox();
            this.ExtraInfoBox = new System.Windows.Forms.RichTextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CancelAddR
            // 
            this.CancelAddR.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelAddR.Location = new System.Drawing.Point(598, 383);
            this.CancelAddR.Name = "CancelAddR";
            this.CancelAddR.Size = new System.Drawing.Size(190, 62);
            this.CancelAddR.TabIndex = 19;
            this.CancelAddR.Text = "Отменить";
            this.CancelAddR.UseVisualStyleBackColor = true;
            this.CancelAddR.Click += new System.EventHandler(this.CancelAddR_Click);
            // 
            // ToDraswingR
            // 
            this.ToDraswingR.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToDraswingR.Location = new System.Drawing.Point(374, 383);
            this.ToDraswingR.Name = "ToDraswingR";
            this.ToDraswingR.Size = new System.Drawing.Size(190, 62);
            this.ToDraswingR.TabIndex = 18;
            this.ToDraswingR.Text = "Продолжить";
            this.ToDraswingR.UseVisualStyleBackColor = true;
            this.ToDraswingR.Click += new System.EventHandler(this.ToDraswingR_Click);
            // 
            // RFilter
            // 
            this.RFilter.FormattingEnabled = true;
            this.RFilter.Location = new System.Drawing.Point(200, 157);
            this.RFilter.Name = "RFilter";
            this.RFilter.Size = new System.Drawing.Size(234, 24);
            this.RFilter.TabIndex = 17;
            this.RFilter.SelectedIndexChanged += new System.EventHandler(this.RFilter_SelectedIndexChanged);
            // 
            // ExtraInfoBox
            // 
            this.ExtraInfoBox.Location = new System.Drawing.Point(12, 239);
            this.ExtraInfoBox.Name = "ExtraInfoBox";
            this.ExtraInfoBox.Size = new System.Drawing.Size(776, 114);
            this.ExtraInfoBox.TabIndex = 16;
            this.ExtraInfoBox.Text = "";
            this.ExtraInfoBox.TextChanged += new System.EventHandler(this.ExtraInfoBox_TextChanged);
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(200, 98);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(234, 22);
            this.NameBox.TabIndex = 15;
            this.NameBox.TextChanged += new System.EventHandler(this.NameBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 22);
            this.label3.TabIndex = 14;
            this.label3.Text = "Доп. информация:\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 22);
            this.label1.TabIndex = 13;
            this.label1.Text = "Тип:\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 22);
            this.label2.TabIndex = 12;
            this.label2.Text = "Наименование:\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(629, 66);
            this.label4.TabIndex = 20;
            this.label4.Text = "Вы сможете продолжить только после заполнения обязательных полей: \r\nНаименование," +
    " Тип. \r\nПоле Доп. информация не ялвяется обязательным.";
            // 
            // AddR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 457);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CancelAddR);
            this.Controls.Add(this.ToDraswingR);
            this.Controls.Add(this.RFilter);
            this.Controls.Add(this.ExtraInfoBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "AddR";
            this.Text = "Дорожная система";
            this.Load += new System.EventHandler(this.AddR_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelAddR;
        private System.Windows.Forms.Button ToDraswingR;
        private System.Windows.Forms.ComboBox RFilter;
        private System.Windows.Forms.RichTextBox ExtraInfoBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}