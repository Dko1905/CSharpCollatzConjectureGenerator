namespace numberGenerator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.startButton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.choseFileButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numberBox = new System.Windows.Forms.NumericUpDown();
            this.stRadio = new System.Windows.Forms.RadioButton();
            this.mtRadio = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.numberBox)).BeginInit();
            this.SuspendLayout();
            // 
            // startButton
            // 
            resources.ApplyResources(this.startButton, "startButton");
            this.startButton.Name = "startButton";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // progressBar1
            // 
            resources.ApplyResources(this.progressBar1, "progressBar1");
            this.progressBar1.Name = "progressBar1";
            // 
            // saveFileDialog1
            // 
            resources.ApplyResources(this.saveFileDialog1, "saveFileDialog1");
            // 
            // choseFileButton
            // 
            resources.ApplyResources(this.choseFileButton, "choseFileButton");
            this.choseFileButton.Name = "choseFileButton";
            this.choseFileButton.UseVisualStyleBackColor = true;
            this.choseFileButton.Click += new System.EventHandler(this.ChoseFileButton_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // numberBox
            // 
            this.numberBox.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            resources.ApplyResources(this.numberBox, "numberBox");
            this.numberBox.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numberBox.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numberBox.Name = "numberBox";
            this.numberBox.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // stRadio
            // 
            resources.ApplyResources(this.stRadio, "stRadio");
            this.stRadio.Checked = true;
            this.stRadio.Name = "stRadio";
            this.stRadio.TabStop = true;
            this.stRadio.UseVisualStyleBackColor = true;
            // 
            // mtRadio
            // 
            resources.ApplyResources(this.mtRadio, "mtRadio");
            this.mtRadio.Name = "mtRadio";
            this.mtRadio.TabStop = true;
            this.mtRadio.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mtRadio);
            this.Controls.Add(this.stRadio);
            this.Controls.Add(this.numberBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.choseFileButton);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.startButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numberBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button choseFileButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numberBox;
        private System.Windows.Forms.RadioButton stRadio;
        private System.Windows.Forms.RadioButton mtRadio;
    }
}

