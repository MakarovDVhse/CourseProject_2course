
namespace ProjectCourse_2
{
    partial class AddRToMap
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
            this.Cancel = new System.Windows.Forms.Button();
            this.MapMain = new System.Windows.Forms.PictureBox();
            this.Close = new System.Windows.Forms.Button();
            this.Make = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MapMain)).BeginInit();
            this.SuspendLayout();
            // 
            // Cancel
            // 
            this.Cancel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cancel.Location = new System.Drawing.Point(907, 719);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(190, 62);
            this.Cancel.TabIndex = 30;
            this.Cancel.Text = "Отменить действия";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // MapMain
            // 
            this.MapMain.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.MapMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MapMain.Location = new System.Drawing.Point(12, 12);
            this.MapMain.Name = "MapMain";
            this.MapMain.Size = new System.Drawing.Size(1312, 701);
            this.MapMain.TabIndex = 29;
            this.MapMain.TabStop = false;
            this.MapMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MapMain_MouseDown);
            this.MapMain.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MapMain_MouseUp);
            // 
            // Close
            // 
            this.Close.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Close.Location = new System.Drawing.Point(1134, 719);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(190, 62);
            this.Close.TabIndex = 28;
            this.Close.Text = "Вернуться назад";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Make
            // 
            this.Make.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Make.Location = new System.Drawing.Point(671, 719);
            this.Make.Name = "Make";
            this.Make.Size = new System.Drawing.Size(190, 62);
            this.Make.TabIndex = 27;
            this.Make.Text = "Подтвердить";
            this.Make.UseVisualStyleBackColor = true;
            this.Make.Click += new System.EventHandler(this.Make_Click);
            // 
            // AddRToMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1336, 793);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.MapMain);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Make);
            this.Name = "AddRToMap";
            this.Text = "Дорожная система";
            this.Load += new System.EventHandler(this.AddRToMap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MapMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.PictureBox MapMain;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button Make;
    }
}