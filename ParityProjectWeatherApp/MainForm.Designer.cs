namespace ParityProjectWeatherApp
{
    partial class MainForm
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
            this.btnFetchWeatherData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFetchWeatherData
            // 
            this.btnFetchWeatherData.Location = new System.Drawing.Point(116, 78);
            this.btnFetchWeatherData.Name = "btnFetchWeatherData";
            this.btnFetchWeatherData.Size = new System.Drawing.Size(133, 37);
            this.btnFetchWeatherData.TabIndex = 0;
            this.btnFetchWeatherData.Text = "Fetch Weather Data";
            this.btnFetchWeatherData.UseVisualStyleBackColor = true;
            this.btnFetchWeatherData.Click += new System.EventHandler(this.btnFetchWeatherData_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 204);
            this.Controls.Add(this.btnFetchWeatherData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Greg\'s Fetch Weather Application";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFetchWeatherData;
    }
}

