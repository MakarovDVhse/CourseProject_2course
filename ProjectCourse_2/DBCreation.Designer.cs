
namespace ProjectCourse_2
{
    partial class DBCreation
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.ExtraInfoBox = new System.Windows.Forms.RichTextBox();
            this.CountryBox = new System.Windows.Forms.TextBox();
            this.RegionBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.CrButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(690, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "В полях ниже необходимо ввести информацию о населённом пункте, где\r\nведётся учёт " +
    "градостроительной деятельности.\r\nПоля помеченные звёздочкой являются обязательн" +
    "ыми для заполнения.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "*Страна:\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label3.Location = new System.Drawing.Point(12, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "*Регион:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label4.Location = new System.Drawing.Point(12, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "*Наименование:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label5.Location = new System.Drawing.Point(12, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(272, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Дополнительная информация:";
            // 
            // toolTip1
            // 
            this.toolTip1.Tag = "Страна, в которой находится населённый пункт";
            // 
            // toolTip2
            // 
            this.toolTip2.Tag = "Регион, в котором находится населённый пункт";
            // 
            // toolTip3
            // 
            this.toolTip3.Tag = "Имя населённого пункта";
            // 
            // toolTip4
            // 
            this.toolTip4.Tag = "Дополнительная информация о населённом пункте";
            // 
            // ExtraInfoBox
            // 
            this.ExtraInfoBox.Location = new System.Drawing.Point(16, 300);
            this.ExtraInfoBox.Name = "ExtraInfoBox";
            this.ExtraInfoBox.Size = new System.Drawing.Size(772, 107);
            this.ExtraInfoBox.TabIndex = 5;
            this.ExtraInfoBox.Text = "";
            this.ExtraInfoBox.TextChanged += new System.EventHandler(this.ExtraInfoBox_TextChanged);
            // 
            // CountryBox
            // 
            this.CountryBox.Location = new System.Drawing.Point(172, 134);
            this.CountryBox.Name = "CountryBox";
            this.CountryBox.Size = new System.Drawing.Size(299, 22);
            this.CountryBox.TabIndex = 6;
            this.CountryBox.TextChanged += new System.EventHandler(this.CountryBox_TextChanged);
            // 
            // RegionBox
            // 
            this.RegionBox.Location = new System.Drawing.Point(172, 182);
            this.RegionBox.Name = "RegionBox";
            this.RegionBox.Size = new System.Drawing.Size(299, 22);
            this.RegionBox.TabIndex = 7;
            this.RegionBox.TextChanged += new System.EventHandler(this.RegionBox_TextChanged);
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(172, 232);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(299, 22);
            this.NameBox.TabIndex = 8;
            this.NameBox.TextChanged += new System.EventHandler(this.NameBox_TextChanged);
            // 
            // CrButton
            // 
            this.CrButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CrButton.Location = new System.Drawing.Point(373, 423);
            this.CrButton.Name = "CrButton";
            this.CrButton.Size = new System.Drawing.Size(190, 62);
            this.CrButton.TabIndex = 9;
            this.CrButton.Text = "Создать";
            this.CrButton.UseVisualStyleBackColor = true;
            this.CrButton.Click += new System.EventHandler(this.CrButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelButton.Location = new System.Drawing.Point(598, 423);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(190, 62);
            this.CancelButton.TabIndex = 10;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // DBCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 507);
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
            this.Controls.Add(this.label1);
            this.Name = "DBCreation";
            this.Text = "Создание базы данных";
            this.Load += new System.EventHandler(this.DBCreation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.RichTextBox ExtraInfoBox;
        private System.Windows.Forms.TextBox CountryBox;
        private System.Windows.Forms.TextBox RegionBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Button CrButton;
        private System.Windows.Forms.Button CancelButton;
    }
}