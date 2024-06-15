
namespace XYZ_Institute
{
    partial class Edit_Student
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit_Student));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRegID = new System.Windows.Forms.TextBox();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.dataGridViewDelete = new System.Windows.Forms.DataGridView();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(57, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(336, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Delete Students Records";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(319, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Registration ID ";
            // 
            // txtRegID
            // 
            this.txtRegID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegID.Location = new System.Drawing.Point(453, 69);
            this.txtRegID.Name = "txtRegID";
            this.txtRegID.Size = new System.Drawing.Size(127, 30);
            this.txtRegID.TabIndex = 3;
            // 
            // btnDelete
            // 
            this.btnDelete.CheckedState.Parent = this.btnDelete;
            this.btnDelete.CustomImages.Parent = this.btnDelete;
            this.btnDelete.FillColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.HoverState.Parent = this.btnDelete;
            this.btnDelete.Location = new System.Drawing.Point(386, 130);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.PressedColor = System.Drawing.Color.Gray;
            this.btnDelete.ShadowDecoration.Parent = this.btnDelete;
            this.btnDelete.Size = new System.Drawing.Size(141, 37);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dataGridViewDelete
            // 
            this.dataGridViewDelete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDelete.Location = new System.Drawing.Point(12, 199);
            this.dataGridViewDelete.Name = "dataGridViewDelete";
            this.dataGridViewDelete.RowHeadersWidth = 51;
            this.dataGridViewDelete.RowTemplate.Height = 24;
            this.dataGridViewDelete.Size = new System.Drawing.Size(877, 308);
            this.dataGridViewDelete.TabIndex = 5;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(681, 14);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(190, 153);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 37;
            this.pictureBox5.TabStop = false;
            // 
            // Edit_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(901, 519);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.dataGridViewDelete);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtRegID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Edit_Student";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit_Student";
            this.Load += new System.EventHandler(this.Edit_Student_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRegID;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridViewDelete;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}