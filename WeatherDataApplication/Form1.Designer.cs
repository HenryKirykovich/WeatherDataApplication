namespace WeatherDataApplication
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.buttonGetWeather = new System.Windows.Forms.Button();
            this.labelTemp = new System.Windows.Forms.Label();
            this.labelTempValue = new System.Windows.Forms.Label();
            this.labelHumidity = new System.Windows.Forms.Label();
            this.labelHumidityValue = new System.Windows.Forms.Label();
            this.labelWindSpeed = new System.Windows.Forms.Label();
            this.labelWindSpeedValue = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelDescriptionValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(12, 12);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(200, 23);
            this.textBoxCity.TabIndex = 0;
            // 
            // buttonGetWeather
            // 
            this.buttonGetWeather.Location = new System.Drawing.Point(222, 10);
            this.buttonGetWeather.Name = "buttonGetWeather";
            this.buttonGetWeather.Size = new System.Drawing.Size(100, 27);
            this.buttonGetWeather.TabIndex = 1;
            this.buttonGetWeather.Text = "Get Weather";
            this.buttonGetWeather.UseVisualStyleBackColor = true;
            this.buttonGetWeather.Click += new System.EventHandler(this.buttonGetWeather_Click);
            // 
            // labelTemp
            // 
            this.labelTemp.AutoSize = true;
            this.labelTemp.Location = new System.Drawing.Point(12, 55);
            this.labelTemp.Name = "labelTemp";
            this.labelTemp.TabIndex = 2;
            this.labelTemp.Text = "Temperature:";
            // 
            // labelTempValue
            // 
            this.labelTempValue.AutoSize = true;
            this.labelTempValue.Location = new System.Drawing.Point(120, 55);
            this.labelTempValue.Name = "labelTempValue";
            this.labelTempValue.TabIndex = 3;
            // 
            // labelHumidity
            // 
            this.labelHumidity.AutoSize = true;
            this.labelHumidity.Location = new System.Drawing.Point(12, 85);
            this.labelHumidity.Name = "labelHumidity";
            this.labelHumidity.TabIndex = 4;
            this.labelHumidity.Text = "Humidity:";
            // 
            // labelHumidityValue
            // 
            this.labelHumidityValue.AutoSize = true;
            this.labelHumidityValue.Location = new System.Drawing.Point(120, 85);
            this.labelHumidityValue.Name = "labelHumidityValue";
            this.labelHumidityValue.TabIndex = 5;
            // 
            // labelWindSpeed
            // 
            this.labelWindSpeed.AutoSize = true;
            this.labelWindSpeed.Location = new System.Drawing.Point(12, 115);
            this.labelWindSpeed.Name = "labelWindSpeed";
            this.labelWindSpeed.TabIndex = 6;
            this.labelWindSpeed.Text = "Wind Speed:";
            // 
            // labelWindSpeedValue
            // 
            this.labelWindSpeedValue.AutoSize = true;
            this.labelWindSpeedValue.Location = new System.Drawing.Point(120, 115);
            this.labelWindSpeedValue.Name = "labelWindSpeedValue";
            this.labelWindSpeedValue.TabIndex = 7;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(12, 145);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.TabIndex = 8;
            this.labelDescription.Text = "Description:";
            // 
            // labelDescriptionValue
            // 
            this.labelDescriptionValue.AutoSize = true;
            this.labelDescriptionValue.Location = new System.Drawing.Point(120, 145);
            this.labelDescriptionValue.Name = "labelDescriptionValue";
            this.labelDescriptionValue.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 185);
            this.Controls.Add(this.labelDescriptionValue);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelWindSpeedValue);
            this.Controls.Add(this.labelWindSpeed);
            this.Controls.Add(this.labelHumidityValue);
            this.Controls.Add(this.labelHumidity);
            this.Controls.Add(this.labelTempValue);
            this.Controls.Add(this.labelTemp);
            this.Controls.Add(this.buttonGetWeather);
            this.Controls.Add(this.textBoxCity);
            this.Name = "Form1";
            this.Text = "Weather App";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.Button buttonGetWeather;
        private System.Windows.Forms.Label labelTemp;
        private System.Windows.Forms.Label labelTempValue;
        private System.Windows.Forms.Label labelHumidity;
        private System.Windows.Forms.Label labelHumidityValue;
        private System.Windows.Forms.Label labelWindSpeed;
        private System.Windows.Forms.Label labelWindSpeedValue;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelDescriptionValue;
    }
}

