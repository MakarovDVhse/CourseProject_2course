
namespace ProjectCourse_2
{
    partial class AddLS
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.ExtraInfoBox = new System.Windows.Forms.RichTextBox();
            this.LSFilter = new System.Windows.Forms.ComboBox();
            this.ToDraswingLS = new System.Windows.Forms.Button();
            this.CancelAddLS = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Наименование:\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Тип:\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Доп. информация:\r\n";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(200, 95);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(234, 22);
            this.NameBox.TabIndex = 5;
            this.NameBox.TextChanged += new System.EventHandler(this.NameBox_TextChanged);
            // 
            // ExtraInfoBox
            // 
            this.ExtraInfoBox.Location = new System.Drawing.Point(12, 236);
            this.ExtraInfoBox.Name = "ExtraInfoBox";
            this.ExtraInfoBox.Size = new System.Drawing.Size(776, 114);
            this.ExtraInfoBox.TabIndex = 6;
            this.ExtraInfoBox.Text = "";
            this.ExtraInfoBox.TextChanged += new System.EventHandler(this.ExtraInfoBox_TextChanged);
            // 
            // LSFilter
            // 
            this.LSFilter.FormattingEnabled = true;
            this.LSFilter.Location = new System.Drawing.Point(200, 154);
            this.LSFilter.Name = "LSFilter";
            this.LSFilter.Size = new System.Drawing.Size(234, 24);
            this.LSFilter.TabIndex = 7;
            this.LSFilter.SelectedIndexChanged += new System.EventHandler(this.LSFilter_SelectedIndexChanged);
            // 
            // ToDraswingLS
            // 
            this.ToDraswingLS.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToDraswingLS.Location = new System.Drawing.Point(374, 376);
            this.ToDraswingLS.Name = "ToDraswingLS";
            this.ToDraswingLS.Size = new System.Drawing.Size(190, 62);
            this.ToDraswingLS.TabIndex = 10;
            this.ToDraswingLS.Text = "Продолжить";
            this.ToDraswingLS.UseVisualStyleBackColor = true;
            this.ToDraswingLS.Click += new System.EventHandler(this.ToDraswingLS_Click);
            // 
            // CancelAddLS
            // 
            this.CancelAddLS.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelAddLS.Location = new System.Drawing.Point(598, 376);
            this.CancelAddLS.Name = "CancelAddLS";
            this.CancelAddLS.Size = new System.Drawing.Size(190, 62);
            this.CancelAddLS.TabIndex = 11;
            this.CancelAddLS.Text = "Отменить";
            this.CancelAddLS.UseVisualStyleBackColor = true;
            this.CancelAddLS.Click += new System.EventHandler(this.CancelAddLS_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(16, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(629, 66);
            this.label4.TabIndex = 12;
            this.label4.Text = "Вы сможете продолжить только после заполнения обязательных полей: \r\nНаименование," +
    " Тип. \r\nПоле Доп. информация не ялвяется обязательным.";
            // 
            // AddLS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CancelAddLS);
            this.Controls.Add(this.ToDraswingLS);
            this.Controls.Add(this.LSFilter);
            this.Controls.Add(this.ExtraInfoBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "AddLS";
            this.Text = "Ландшафт";
            this.Load += new System.EventHandler(this.AddLS_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.RichTextBox ExtraInfoBox;
        private System.Windows.Forms.ComboBox LSFilter;
        private System.Windows.Forms.Button ToDraswingLS;
        private System.Windows.Forms.Button CancelAddLS;
        private System.Windows.Forms.Label label4;
    }
}