
namespace ProjectCourse_2
{
    partial class ChangeLSCon
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
            this.CancelChange = new System.Windows.Forms.Button();
            this.ToDraswingLS = new System.Windows.Forms.Button();
            this.Type = new System.Windows.Forms.ComboBox();
            this.ExtraInfo = new System.Windows.Forms.RichTextBox();
            this.Name1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CancelChange
            // 
            this.CancelChange.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelChange.Location = new System.Drawing.Point(598, 343);
            this.CancelChange.Name = "CancelChange";
            this.CancelChange.Size = new System.Drawing.Size(190, 62);
            this.CancelChange.TabIndex = 20;
            this.CancelChange.Text = "Отменить";
            this.CancelChange.UseVisualStyleBackColor = true;
            this.CancelChange.Click += new System.EventHandler(this.CancelChange_Click);
            // 
            // ToDraswingLS
            // 
            this.ToDraswingLS.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToDraswingLS.Location = new System.Drawing.Point(374, 343);
            this.ToDraswingLS.Name = "ToDraswingLS";
            this.ToDraswingLS.Size = new System.Drawing.Size(190, 62);
            this.ToDraswingLS.TabIndex = 19;
            this.ToDraswingLS.Text = "Продолжить";
            this.ToDraswingLS.UseVisualStyleBackColor = true;
            this.ToDraswingLS.Click += new System.EventHandler(this.ToDraswingLS_Click);
            // 
            // Type
            // 
            this.Type.FormattingEnabled = true;
            this.Type.Location = new System.Drawing.Point(200, 121);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(234, 24);
            this.Type.TabIndex = 18;
            this.Type.SelectedIndexChanged += new System.EventHandler(this.Type_SelectedIndexChanged);
            // 
            // ExtraInfo
            // 
            this.ExtraInfo.Location = new System.Drawing.Point(12, 203);
            this.ExtraInfo.Name = "ExtraInfo";
            this.ExtraInfo.Size = new System.Drawing.Size(776, 114);
            this.ExtraInfo.TabIndex = 17;
            this.ExtraInfo.Text = "";
            // 
            // Name
            // 
            this.Name1.Location = new System.Drawing.Point(200, 62);
            this.Name1.Name = "Name";
            this.Name1.Size = new System.Drawing.Size(234, 22);
            this.Name1.TabIndex = 16;
            this.Name1.TextChanged += new System.EventHandler(this.Name_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 22);
            this.label3.TabIndex = 15;
            this.label3.Text = "Доп. информация:\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 22);
            this.label1.TabIndex = 14;
            this.label1.Text = "Тип:\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 22);
            this.label2.TabIndex = 13;
            this.label2.Text = "Наименование:\r\n";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(12, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(655, 22);
            this.label6.TabIndex = 36;
            this.label6.Text = "Для завершения изменения необходимо заново отрисовать объект на карте.";
            // 
            // ChangeLSCon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 417);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CancelChange);
            this.Controls.Add(this.ToDraswingLS);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.ExtraInfo);
            this.Controls.Add(this.Name1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "ChangeLSCon";
            this.Text = "Изменить элемент";
            this.Load += new System.EventHandler(this.ChangeLSCon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CancelChange;
        private System.Windows.Forms.Button ToDraswingLS;
        private System.Windows.Forms.ComboBox Type;
        private System.Windows.Forms.RichTextBox ExtraInfo;
        private System.Windows.Forms.TextBox Name1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
    }
}