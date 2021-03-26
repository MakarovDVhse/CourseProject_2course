
namespace ProjectCourse_2
{
    partial class ChangeObjCon
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.StreetFilter = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.NumBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CancelAddObj = new System.Windows.Forms.Button();
            this.ToDraswingObj = new System.Windows.Forms.Button();
            this.UFilter = new System.Windows.Forms.ComboBox();
            this.ExtraInfo = new System.Windows.Forms.RichTextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(12, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(655, 22);
            this.label6.TabIndex = 35;
            this.label6.Text = "Для завершения изменения необходимо заново отрисовать объект на карте.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.StreetFilter);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.NumBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(452, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 167);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Адрес";
            // 
            // StreetFilter
            // 
            this.StreetFilter.FormattingEnabled = true;
            this.StreetFilter.Location = new System.Drawing.Point(151, 56);
            this.StreetFilter.Name = "StreetFilter";
            this.StreetFilter.Size = new System.Drawing.Size(234, 24);
            this.StreetFilter.TabIndex = 23;
            this.StreetFilter.SelectedIndexChanged += new System.EventHandler(this.StreetFilter_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(25, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 22);
            this.label5.TabIndex = 20;
            this.label5.Text = "Улица:\r\n";
            // 
            // NumBox
            // 
            this.NumBox.Location = new System.Drawing.Point(151, 115);
            this.NumBox.Name = "NumBox";
            this.NumBox.Size = new System.Drawing.Size(234, 22);
            this.NumBox.TabIndex = 22;
            this.NumBox.TextChanged += new System.EventHandler(this.NumBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(25, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 22);
            this.label4.TabIndex = 21;
            this.label4.Text = "Номер:\r\n";
            // 
            // CancelAddObj
            // 
            this.CancelAddObj.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelAddObj.Location = new System.Drawing.Point(702, 385);
            this.CancelAddObj.Name = "CancelAddObj";
            this.CancelAddObj.Size = new System.Drawing.Size(190, 62);
            this.CancelAddObj.TabIndex = 33;
            this.CancelAddObj.Text = "Отменить";
            this.CancelAddObj.UseVisualStyleBackColor = true;
            this.CancelAddObj.Click += new System.EventHandler(this.CancelAddObj_Click);
            // 
            // ToDraswingObj
            // 
            this.ToDraswingObj.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToDraswingObj.Location = new System.Drawing.Point(477, 385);
            this.ToDraswingObj.Name = "ToDraswingObj";
            this.ToDraswingObj.Size = new System.Drawing.Size(190, 62);
            this.ToDraswingObj.TabIndex = 32;
            this.ToDraswingObj.Text = "Продолжить";
            this.ToDraswingObj.UseVisualStyleBackColor = true;
            this.ToDraswingObj.Click += new System.EventHandler(this.ToDraswingObj_Click);
            // 
            // UFilter
            // 
            this.UFilter.FormattingEnabled = true;
            this.UFilter.Location = new System.Drawing.Point(200, 164);
            this.UFilter.Name = "UFilter";
            this.UFilter.Size = new System.Drawing.Size(234, 24);
            this.UFilter.TabIndex = 31;
            this.UFilter.SelectedIndexChanged += new System.EventHandler(this.UFilter_SelectedIndexChanged);
            // 
            // ExtraInfo
            // 
            this.ExtraInfo.Location = new System.Drawing.Point(12, 246);
            this.ExtraInfo.Name = "ExtraInfo";
            this.ExtraInfo.Size = new System.Drawing.Size(880, 114);
            this.ExtraInfo.TabIndex = 30;
            this.ExtraInfo.Text = "";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(200, 105);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(234, 22);
            this.NameBox.TabIndex = 29;
            this.NameBox.TextChanged += new System.EventHandler(this.NameBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 22);
            this.label3.TabIndex = 28;
            this.label3.Text = "Доп. информация:\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 22);
            this.label1.TabIndex = 27;
            this.label1.Text = "Тип:\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 22);
            this.label2.TabIndex = 26;
            this.label2.Text = "Наименование:\r\n";
            // 
            // ChangeObjCon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 459);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CancelAddObj);
            this.Controls.Add(this.ToDraswingObj);
            this.Controls.Add(this.UFilter);
            this.Controls.Add(this.ExtraInfo);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "ChangeObjCon";
            this.Text = "Изменить элемент";
            this.Load += new System.EventHandler(this.ChangeObjCon_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox StreetFilter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NumBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CancelAddObj;
        private System.Windows.Forms.Button ToDraswingObj;
        private System.Windows.Forms.ComboBox UFilter;
        private System.Windows.Forms.RichTextBox ExtraInfo;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}