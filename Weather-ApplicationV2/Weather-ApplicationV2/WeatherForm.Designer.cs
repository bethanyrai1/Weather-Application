namespace Weather_ApplicationV2
{
    partial class WeatherForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WeatherForm));
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.countryCodeTxtBox = new System.Windows.Forms.TextBox();
            this.FindWeatherBttn = new System.Windows.Forms.Button();
            this.mainPicBox = new System.Windows.Forms.PictureBox();
            this.secPicBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.clearBttn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mainPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(22, 107);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(118, 20);
            this.cityTextBox.TabIndex = 0;
            // 
            // countryCodeTxtBox
            // 
            this.countryCodeTxtBox.Location = new System.Drawing.Point(22, 160);
            this.countryCodeTxtBox.Name = "countryCodeTxtBox";
            this.countryCodeTxtBox.Size = new System.Drawing.Size(118, 20);
            this.countryCodeTxtBox.TabIndex = 1;
            // 
            // FindWeatherBttn
            // 
            this.FindWeatherBttn.Location = new System.Drawing.Point(42, 218);
            this.FindWeatherBttn.Name = "FindWeatherBttn";
            this.FindWeatherBttn.Size = new System.Drawing.Size(78, 37);
            this.FindWeatherBttn.TabIndex = 2;
            this.FindWeatherBttn.Text = "Check";
            this.FindWeatherBttn.UseVisualStyleBackColor = true;
            this.FindWeatherBttn.Click += new System.EventHandler(this.FindWeatherBttn_Click);
            // 
            // mainPicBox
            // 
            this.mainPicBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainPicBox.BackgroundImage")));
            this.mainPicBox.Location = new System.Drawing.Point(-10, 33);
            this.mainPicBox.Name = "mainPicBox";
            this.mainPicBox.Size = new System.Drawing.Size(524, 356);
            this.mainPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mainPicBox.TabIndex = 3;
            this.mainPicBox.TabStop = false;
            // 
            // secPicBox
            // 
            this.secPicBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(151)))), ((int)(((byte)(130)))));
            this.secPicBox.Location = new System.Drawing.Point(0, 0);
            this.secPicBox.Name = "secPicBox";
            this.secPicBox.Size = new System.Drawing.Size(514, 73);
            this.secPicBox.TabIndex = 4;
            this.secPicBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(151)))), ((int)(((byte)(130)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(27, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Welcome to Weather Finder!";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(151)))), ((int)(((byte)(130)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(19, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "City Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(151)))), ((int)(((byte)(130)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(19, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Country Code";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(182, 96);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(315, 260);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // clearBttn
            // 
            this.clearBttn.Location = new System.Drawing.Point(42, 270);
            this.clearBttn.Name = "clearBttn";
            this.clearBttn.Size = new System.Drawing.Size(78, 37);
            this.clearBttn.TabIndex = 10;
            this.clearBttn.Text = "Clear";
            this.clearBttn.UseVisualStyleBackColor = true;
            this.clearBttn.Click += new System.EventHandler(this.clearBttn_Click);
            // 
            // WeatherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 384);
            this.Controls.Add(this.clearBttn);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FindWeatherBttn);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.countryCodeTxtBox);
            this.Controls.Add(this.secPicBox);
            this.Controls.Add(this.mainPicBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "WeatherForm";
            this.Text = "WeatherForm";
            ((System.ComponentModel.ISupportInitialize)(this.mainPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox countryCodeTxtBox;
        private System.Windows.Forms.Button FindWeatherBttn;
        private System.Windows.Forms.PictureBox mainPicBox;
        private System.Windows.Forms.PictureBox secPicBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button clearBttn;
    }
}