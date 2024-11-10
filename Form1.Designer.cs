namespace Detection_YOLOv11
{
    partial class ComputerVision
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
            this.Btn_OpenFolder = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.Btn_Webcam = new System.Windows.Forms.Button();
            this.Btn_Activate = new System.Windows.Forms.Button();
            this.Btn_Export = new System.Windows.Forms.Button();
            this.groupBox_Model = new System.Windows.Forms.GroupBox();
            this.Model = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Btn_AddModel = new System.Windows.Forms.Button();
            this.Btn_RemoveModel = new System.Windows.Forms.Button();
            this.groupBox_Feature = new System.Windows.Forms.GroupBox();
            this.Label_Picture = new System.Windows.Forms.Label();
            this.Btn_Next = new System.Windows.Forms.Button();
            this.Btn_Previous = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.groupBox_Model.SuspendLayout();
            this.groupBox_Feature.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_OpenFolder
            // 
            this.Btn_OpenFolder.Location = new System.Drawing.Point(6, 25);
            this.Btn_OpenFolder.Name = "Btn_OpenFolder";
            this.Btn_OpenFolder.Size = new System.Drawing.Size(124, 34);
            this.Btn_OpenFolder.TabIndex = 0;
            this.Btn_OpenFolder.Text = "Open Folder";
            this.Btn_OpenFolder.UseVisualStyleBackColor = true;
            this.Btn_OpenFolder.Click += new System.EventHandler(this.Btn_OpenFolder_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 427);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(999, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(12, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(626, 363);
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            // 
            // Btn_Webcam
            // 
            this.Btn_Webcam.Location = new System.Drawing.Point(6, 65);
            this.Btn_Webcam.Name = "Btn_Webcam";
            this.Btn_Webcam.Size = new System.Drawing.Size(124, 34);
            this.Btn_Webcam.TabIndex = 0;
            this.Btn_Webcam.Text = "Webcam";
            this.Btn_Webcam.UseVisualStyleBackColor = true;
            this.Btn_Webcam.Click += new System.EventHandler(this.Btn_Webcam_Click);
            // 
            // Btn_Activate
            // 
            this.Btn_Activate.Location = new System.Drawing.Point(17, 113);
            this.Btn_Activate.Name = "Btn_Activate";
            this.Btn_Activate.Size = new System.Drawing.Size(152, 34);
            this.Btn_Activate.TabIndex = 0;
            this.Btn_Activate.Text = "Start Detection";
            this.Btn_Activate.UseVisualStyleBackColor = true;
            this.Btn_Activate.Click += new System.EventHandler(this.Btn_Activate_Click);
            // 
            // Btn_Export
            // 
            this.Btn_Export.Location = new System.Drawing.Point(6, 105);
            this.Btn_Export.Name = "Btn_Export";
            this.Btn_Export.Size = new System.Drawing.Size(124, 34);
            this.Btn_Export.TabIndex = 0;
            this.Btn_Export.Text = "Export";
            this.Btn_Export.UseVisualStyleBackColor = true;
            this.Btn_Export.Click += new System.EventHandler(this.Btn_Export_Click);
            // 
            // groupBox_Model
            // 
            this.groupBox_Model.Controls.Add(this.Model);
            this.groupBox_Model.Controls.Add(this.comboBox1);
            this.groupBox_Model.Controls.Add(this.Btn_AddModel);
            this.groupBox_Model.Controls.Add(this.Btn_RemoveModel);
            this.groupBox_Model.Controls.Add(this.Btn_Activate);
            this.groupBox_Model.Location = new System.Drawing.Point(644, 12);
            this.groupBox_Model.Name = "groupBox_Model";
            this.groupBox_Model.Size = new System.Drawing.Size(367, 162);
            this.groupBox_Model.TabIndex = 4;
            this.groupBox_Model.TabStop = false;
            this.groupBox_Model.Text = "Model";
            // 
            // Model
            // 
            this.Model.AutoSize = true;
            this.Model.Location = new System.Drawing.Point(34, 28);
            this.Model.Name = "Model";
            this.Model.Size = new System.Drawing.Size(52, 20);
            this.Model.TabIndex = 2;
            this.Model.Text = "Model";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Yolov11-m",
            "Yolov11-s",
            "Yolov10-m",
            "Yolov10-s"});
            this.comboBox1.Location = new System.Drawing.Point(116, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(161, 28);
            this.comboBox1.TabIndex = 1;
            // 
            // Btn_AddModel
            // 
            this.Btn_AddModel.Location = new System.Drawing.Point(17, 73);
            this.Btn_AddModel.Name = "Btn_AddModel";
            this.Btn_AddModel.Size = new System.Drawing.Size(152, 34);
            this.Btn_AddModel.TabIndex = 0;
            this.Btn_AddModel.Text = "Add model";
            this.Btn_AddModel.UseVisualStyleBackColor = true;
            this.Btn_AddModel.Click += new System.EventHandler(this.Btn_AddModel_Click);
            // 
            // Btn_RemoveModel
            // 
            this.Btn_RemoveModel.Location = new System.Drawing.Point(175, 73);
            this.Btn_RemoveModel.Name = "Btn_RemoveModel";
            this.Btn_RemoveModel.Size = new System.Drawing.Size(152, 34);
            this.Btn_RemoveModel.TabIndex = 0;
            this.Btn_RemoveModel.Text = "Remove Model";
            this.Btn_RemoveModel.UseVisualStyleBackColor = true;
            this.Btn_RemoveModel.Click += new System.EventHandler(this.Btn_RemoveModel_Click);
            // 
            // groupBox_Feature
            // 
            this.groupBox_Feature.Controls.Add(this.Btn_Export);
            this.groupBox_Feature.Controls.Add(this.Btn_Webcam);
            this.groupBox_Feature.Controls.Add(this.Btn_OpenFolder);
            this.groupBox_Feature.Location = new System.Drawing.Point(644, 180);
            this.groupBox_Feature.Name = "groupBox_Feature";
            this.groupBox_Feature.Size = new System.Drawing.Size(367, 241);
            this.groupBox_Feature.TabIndex = 5;
            this.groupBox_Feature.TabStop = false;
            this.groupBox_Feature.Text = "Features";
            // 
            // Label_Picture
            // 
            this.Label_Picture.AutoSize = true;
            this.Label_Picture.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Picture.Location = new System.Drawing.Point(245, 381);
            this.Label_Picture.Name = "Label_Picture";
            this.Label_Picture.Size = new System.Drawing.Size(176, 40);
            this.Label_Picture.TabIndex = 6;
            this.Label_Picture.Text = "Image 0/0";
            // 
            // Btn_Next
            // 
            this.Btn_Next.Location = new System.Drawing.Point(470, 381);
            this.Btn_Next.Name = "Btn_Next";
            this.Btn_Next.Size = new System.Drawing.Size(124, 34);
            this.Btn_Next.TabIndex = 0;
            this.Btn_Next.Text = "Next";
            this.Btn_Next.UseVisualStyleBackColor = true;
            this.Btn_Next.Click += new System.EventHandler(this.Btn_Next_Click);
            // 
            // Btn_Previous
            // 
            this.Btn_Previous.Location = new System.Drawing.Point(58, 381);
            this.Btn_Previous.Name = "Btn_Previous";
            this.Btn_Previous.Size = new System.Drawing.Size(124, 34);
            this.Btn_Previous.TabIndex = 0;
            this.Btn_Previous.Text = "Previous";
            this.Btn_Previous.UseVisualStyleBackColor = true;
            this.Btn_Previous.Click += new System.EventHandler(this.Btn_Previous_Click);
            // 
            // ComputerVision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 589);
            this.Controls.Add(this.Label_Picture);
            this.Controls.Add(this.groupBox_Feature);
            this.Controls.Add(this.Btn_Previous);
            this.Controls.Add(this.Btn_Next);
            this.Controls.Add(this.groupBox_Model);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ComputerVision";
            this.Text = "C# For Computer Vision";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ComputerVision_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.groupBox_Model.ResumeLayout(false);
            this.groupBox_Model.PerformLayout();
            this.groupBox_Feature.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_OpenFolder;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button Btn_Webcam;
        private System.Windows.Forms.Button Btn_Activate;
        private System.Windows.Forms.Button Btn_Export;
        private System.Windows.Forms.GroupBox groupBox_Model;
        private System.Windows.Forms.Label Model;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button Btn_AddModel;
        private System.Windows.Forms.Button Btn_RemoveModel;
        private System.Windows.Forms.GroupBox groupBox_Feature;
        private System.Windows.Forms.Label Label_Picture;
        private System.Windows.Forms.Button Btn_Next;
        private System.Windows.Forms.Button Btn_Previous;
    }
}

