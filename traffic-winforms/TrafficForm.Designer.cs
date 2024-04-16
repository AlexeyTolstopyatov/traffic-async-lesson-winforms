namespace traffic_winforms
{
    partial class TrafficForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.stopButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.redPanel = new System.Windows.Forms.Panel();
            this.yellowPanel = new System.Windows.Forms.Panel();
            this.redLabel = new System.Windows.Forms.Label();
            this.yellowLabel = new System.Windows.Forms.Label();
            this.greenLabel = new System.Windows.Forms.Label();
            this.greenPanel = new System.Windows.Forms.Panel();
            this.abortButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // stopButton
            // 
            this.stopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopButton.Location = new System.Drawing.Point(176, 12);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.TabIndex = 0;
            this.stopButton.Text = "Стоп";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // startButton
            // 
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Location = new System.Drawing.Point(176, 41);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Старт";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // redPanel
            // 
            this.redPanel.Location = new System.Drawing.Point(12, 12);
            this.redPanel.Name = "redPanel";
            this.redPanel.Size = new System.Drawing.Size(32, 32);
            this.redPanel.TabIndex = 2;
            // 
            // yellowPanel
            // 
            this.yellowPanel.Location = new System.Drawing.Point(12, 50);
            this.yellowPanel.Name = "yellowPanel";
            this.yellowPanel.Size = new System.Drawing.Size(32, 32);
            this.yellowPanel.TabIndex = 3;
            // 
            // redLabel
            // 
            this.redLabel.AutoSize = true;
            this.redLabel.Location = new System.Drawing.Point(50, 22);
            this.redLabel.Name = "redLabel";
            this.redLabel.Size = new System.Drawing.Size(31, 13);
            this.redLabel.TabIndex = 4;
            this.redLabel.Text = "Стой";
            // 
            // yellowLabel
            // 
            this.yellowLabel.AutoSize = true;
            this.yellowLabel.Location = new System.Drawing.Point(50, 60);
            this.yellowLabel.Name = "yellowLabel";
            this.yellowLabel.Size = new System.Drawing.Size(30, 13);
            this.yellowLabel.TabIndex = 5;
            this.yellowLabel.Text = "Жди";
            // 
            // greenLabel
            // 
            this.greenLabel.AutoSize = true;
            this.greenLabel.Location = new System.Drawing.Point(50, 96);
            this.greenLabel.Name = "greenLabel";
            this.greenLabel.Size = new System.Drawing.Size(27, 13);
            this.greenLabel.TabIndex = 7;
            this.greenLabel.Text = "Иди";
            // 
            // greenPanel
            // 
            this.greenPanel.Location = new System.Drawing.Point(12, 88);
            this.greenPanel.Name = "greenPanel";
            this.greenPanel.Size = new System.Drawing.Size(32, 32);
            this.greenPanel.TabIndex = 6;
            // 
            // abortButton
            // 
            this.abortButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.abortButton.Location = new System.Drawing.Point(176, 71);
            this.abortButton.Name = "abortButton";
            this.abortButton.Size = new System.Drawing.Size(75, 23);
            this.abortButton.TabIndex = 8;
            this.abortButton.Text = "Сброс";
            this.abortButton.UseVisualStyleBackColor = true;
            this.abortButton.Click += new System.EventHandler(this.abortButton_Click);
            // 
            // TrafficForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 130);
            this.Controls.Add(this.abortButton);
            this.Controls.Add(this.greenLabel);
            this.Controls.Add(this.yellowLabel);
            this.Controls.Add(this.greenPanel);
            this.Controls.Add(this.redLabel);
            this.Controls.Add(this.yellowPanel);
            this.Controls.Add(this.redPanel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.stopButton);
            this.MaximizeBox = false;
            this.Name = "TrafficForm";
            this.Text = "СВЕТОФОР";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Panel redPanel;
        private System.Windows.Forms.Panel yellowPanel;
        private System.Windows.Forms.Label redLabel;
        private System.Windows.Forms.Label yellowLabel;
        private System.Windows.Forms.Label greenLabel;
        private System.Windows.Forms.Panel greenPanel;
        private System.Windows.Forms.Button abortButton;
    }
}

