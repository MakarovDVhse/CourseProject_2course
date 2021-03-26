
namespace ProjectCourse_2
{
    partial class CreateRoadSystem
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.базаДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьЗаписьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьЗаписьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьЗаписьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.картаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.посмотретьКартуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оТипахДорогToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CancelButtonR = new System.Windows.Forms.Button();
            this.ConButtonR = new System.Windows.Forms.Button();
            this.AddElem = new System.Windows.Forms.Button();
            this.ChangeElem = new System.Windows.Forms.Button();
            this.DeleteElem = new System.Windows.Forms.Button();
            this.RTable = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RTable)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.базаДанныхToolStripMenuItem,
            this.картаToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1138, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // базаДанныхToolStripMenuItem
            // 
            this.базаДанныхToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьЗаписьToolStripMenuItem,
            this.изменитьЗаписьToolStripMenuItem,
            this.удалитьЗаписьToolStripMenuItem});
            this.базаДанныхToolStripMenuItem.Name = "базаДанныхToolStripMenuItem";
            this.базаДанныхToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.базаДанныхToolStripMenuItem.Text = "Изменить";
            // 
            // добавитьЗаписьToolStripMenuItem
            // 
            this.добавитьЗаписьToolStripMenuItem.Name = "добавитьЗаписьToolStripMenuItem";
            this.добавитьЗаписьToolStripMenuItem.Size = new System.Drawing.Size(362, 26);
            this.добавитьЗаписьToolStripMenuItem.Text = "Добавить элемент дорожной системы";
            this.добавитьЗаписьToolStripMenuItem.Click += new System.EventHandler(this.добавитьЗаписьToolStripMenuItem_Click);
            // 
            // изменитьЗаписьToolStripMenuItem
            // 
            this.изменитьЗаписьToolStripMenuItem.Name = "изменитьЗаписьToolStripMenuItem";
            this.изменитьЗаписьToolStripMenuItem.Size = new System.Drawing.Size(362, 26);
            this.изменитьЗаписьToolStripMenuItem.Text = "Изменить элемент дорожной системы";
            this.изменитьЗаписьToolStripMenuItem.Click += new System.EventHandler(this.изменитьЗаписьToolStripMenuItem_Click);
            // 
            // удалитьЗаписьToolStripMenuItem
            // 
            this.удалитьЗаписьToolStripMenuItem.Name = "удалитьЗаписьToolStripMenuItem";
            this.удалитьЗаписьToolStripMenuItem.Size = new System.Drawing.Size(362, 26);
            this.удалитьЗаписьToolStripMenuItem.Text = "Удалить элемент дорожной системы";
            this.удалитьЗаписьToolStripMenuItem.Click += new System.EventHandler(this.удалитьЗаписьToolStripMenuItem_Click);
            // 
            // картаToolStripMenuItem
            // 
            this.картаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.посмотретьКартуToolStripMenuItem});
            this.картаToolStripMenuItem.Name = "картаToolStripMenuItem";
            this.картаToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.картаToolStripMenuItem.Text = "Карта";
            // 
            // посмотретьКартуToolStripMenuItem
            // 
            this.посмотретьКартуToolStripMenuItem.Name = "посмотретьКартуToolStripMenuItem";
            this.посмотретьКартуToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.посмотретьКартуToolStripMenuItem.Text = "Посмотреть карту";
            this.посмотретьКартуToolStripMenuItem.Click += new System.EventHandler(this.посмотретьКартуToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оТипахДорогToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // оТипахДорогToolStripMenuItem
            // 
            this.оТипахДорогToolStripMenuItem.Name = "оТипахДорогToolStripMenuItem";
            this.оТипахДорогToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.оТипахДорогToolStripMenuItem.Text = "О типах дорог";
            this.оТипахДорогToolStripMenuItem.Click += new System.EventHandler(this.оТипахДорогToolStripMenuItem_Click);
            // 
            // CancelButtonR
            // 
            this.CancelButtonR.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelButtonR.Location = new System.Drawing.Point(935, 500);
            this.CancelButtonR.Name = "CancelButtonR";
            this.CancelButtonR.Size = new System.Drawing.Size(190, 62);
            this.CancelButtonR.TabIndex = 12;
            this.CancelButtonR.Text = "Отмена";
            this.CancelButtonR.UseVisualStyleBackColor = true;
            this.CancelButtonR.Click += new System.EventHandler(this.CancelButtonR_Click);
            // 
            // ConButtonR
            // 
            this.ConButtonR.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConButtonR.Location = new System.Drawing.Point(14, 500);
            this.ConButtonR.Name = "ConButtonR";
            this.ConButtonR.Size = new System.Drawing.Size(190, 62);
            this.ConButtonR.TabIndex = 14;
            this.ConButtonR.Text = "Подтвердить изменения";
            this.ConButtonR.UseVisualStyleBackColor = true;
            this.ConButtonR.Click += new System.EventHandler(this.ConButtonR_Click);
            // 
            // AddElem
            // 
            this.AddElem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddElem.Location = new System.Drawing.Point(243, 500);
            this.AddElem.Name = "AddElem";
            this.AddElem.Size = new System.Drawing.Size(190, 62);
            this.AddElem.TabIndex = 15;
            this.AddElem.Text = "Добавить элемент";
            this.AddElem.UseVisualStyleBackColor = true;
            this.AddElem.Click += new System.EventHandler(this.AddElem_Click);
            // 
            // ChangeElem
            // 
            this.ChangeElem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeElem.Location = new System.Drawing.Point(473, 500);
            this.ChangeElem.Name = "ChangeElem";
            this.ChangeElem.Size = new System.Drawing.Size(190, 62);
            this.ChangeElem.TabIndex = 16;
            this.ChangeElem.Text = "Изменить элемент";
            this.ChangeElem.UseVisualStyleBackColor = true;
            this.ChangeElem.Click += new System.EventHandler(this.ChangeElem_Click);
            // 
            // DeleteElem
            // 
            this.DeleteElem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteElem.Location = new System.Drawing.Point(704, 500);
            this.DeleteElem.Name = "DeleteElem";
            this.DeleteElem.Size = new System.Drawing.Size(190, 62);
            this.DeleteElem.TabIndex = 17;
            this.DeleteElem.Text = "Удалить элемент";
            this.DeleteElem.UseVisualStyleBackColor = true;
            this.DeleteElem.Click += new System.EventHandler(this.DeleteElem_Click);
            // 
            // RTable
            // 
            this.RTable.AllowUserToAddRows = false;
            this.RTable.AllowUserToDeleteRows = false;
            this.RTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RTable.Location = new System.Drawing.Point(14, 65);
            this.RTable.Name = "RTable";
            this.RTable.ReadOnly = true;
            this.RTable.RowHeadersWidth = 51;
            this.RTable.RowTemplate.Height = 24;
            this.RTable.Size = new System.Drawing.Size(1112, 376);
            this.RTable.TabIndex = 27;
            // 
            // CreateRoadSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 574);
            this.Controls.Add(this.RTable);
            this.Controls.Add(this.DeleteElem);
            this.Controls.Add(this.ChangeElem);
            this.Controls.Add(this.AddElem);
            this.Controls.Add(this.ConButtonR);
            this.Controls.Add(this.CancelButtonR);
            this.Controls.Add(this.menuStrip1);
            this.Name = "CreateRoadSystem";
            this.Text = "Дорожная система";
            this.Load += new System.EventHandler(this.CreateRoadSystem_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem базаДанныхToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьЗаписьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьЗаписьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьЗаписьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem картаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem посмотретьКартуToolStripMenuItem;
        private System.Windows.Forms.Button CancelButtonR;
        private System.Windows.Forms.Button ConButtonR;
        private System.Windows.Forms.Button AddElem;
        private System.Windows.Forms.Button ChangeElem;
        private System.Windows.Forms.Button DeleteElem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оТипахДорогToolStripMenuItem;
        private System.Windows.Forms.DataGridView RTable;
    }
}