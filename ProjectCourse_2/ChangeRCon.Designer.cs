
namespace ProjectCourse_2
{
    partial class ChangeRCon
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
            this.label6 = new System.Windows.Forms.Label();
            this.CancelChangeR = new System.Windows.Forms.Button();
            this.ToDraswingR = new System.Windows.Forms.Button();
            this.RFilter = new System.Windows.Forms.ComboBox();
            this.ExtraInfo = new System.Windows.Forms.RichTextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(12, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(655, 22);
            this.label6.TabIndex = 45;
            this.label6.Text = "Для завершения изменения необходимо заново отрисовать объект на карте.";
            // 
            // CancelChangeR
            // 
            this.CancelChangeR.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelChangeR.Location = new System.Drawing.Point(598, 343);
            this.CancelChangeR.Name = "CancelChangeR";
            this.CancelChangeR.Size = new System.Drawing.Size(190, 62);
            this.CancelChangeR.TabIndex = 44;
            this.CancelChangeR.Text = "Отменить";
            this.CancelChangeR.UseVisualStyleBackColor = true;
            this.CancelChangeR.Click += new System.EventHandler(this.CancelChangeR_Click);
            // 
            // ToDraswingR
            // 
            this.ToDraswingR.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToDraswingR.Location = new System.Drawing.Point(374, 343);
            this.ToDraswingR.Name = "ToDraswingR";
            this.ToDraswingR.Size = new System.Drawing.Size(190, 62);
            this.ToDraswingR.TabIndex = 43;
            this.ToDraswingR.Text = "Продолжить";
            this.ToDraswingR.UseVisualStyleBackColor = true;
            this.ToDraswingR.Click += new System.EventHandler(this.ToDraswingR_Click);
            // 
            // RFilter
            // 
            this.RFilter.FormattingEnabled = true;
            this.RFilter.Location = new System.Drawing.Point(200, 121);
            this.RFilter.Name = "RFilter";
            this.RFilter.Size = new System.Drawing.Size(234, 24);
            this.RFilter.TabIndex = 42;
            this.RFilter.SelectedIndexChanged += new System.EventHandler(this.RFilter_SelectedIndexChanged);
            // 
            // ExtraInfo
            // 
            this.ExtraInfo.Location = new System.Drawing.Point(12, 203);
            this.ExtraInfo.Name = "ExtraInfo";
            this.ExtraInfo.Size = new System.Drawing.Size(776, 114);
            this.ExtraInfo.TabIndex = 41;
            this.ExtraInfo.Text = "";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(200, 62);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(234, 22);
            this.NameBox.TabIndex = 40;
            this.NameBox.TextChanged += new System.EventHandler(this.NameBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 22);
            this.label3.TabIndex = 39;
            this.label3.Text = "Доп. информация:\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 22);
            this.label1.TabIndex = 38;
            this.label1.Text = "Тип:\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 22);
            this.label2.TabIndex = 37;
            this.label2.Text = "Наименование:\r\n";
            // 
            // ChangeRCon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 417);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CancelChangeR);
            this.Controls.Add(this.ToDraswingR);
            this.Controls.Add(this.RFilter);
            this.Controls.Add(this.ExtraInfo);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "ChangeRCon";
            this.Text = "Изменить элемент";
            this.Load += new System.EventHandler(this.ChangeRCon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button CancelChangeR;
        private System.Windows.Forms.Button ToDraswingR;
        private System.Windows.Forms.ComboBox RFilter;
        private System.Windows.Forms.RichTextBox ExtraInfo;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}