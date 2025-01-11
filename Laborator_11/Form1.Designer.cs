
namespace OpenTK3_StandardTemplate_WinForms
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
            this.showAxes = new System.Windows.Forms.CheckBox();
            this.changeBackground = new System.Windows.Forms.Button();
            this.lblOx = new System.Windows.Forms.Label();
            this.lblOy = new System.Windows.Forms.Label();
            this.lblOz = new System.Windows.Forms.Label();
            this.resetScene = new System.Windows.Forms.Button();
            this.enableRotation = new System.Windows.Forms.CheckBox();
            this.enableObjectRotation = new System.Windows.Forms.CheckBox();
            this.btnLights = new System.Windows.Forms.Button();
            this.btnSursa0 = new System.Windows.Forms.Button();
            this.btnTexture = new System.Windows.Forms.Button();
            this.rbFill = new System.Windows.Forms.RadioButton();
            this.rbLine = new System.Windows.Forms.RadioButton();
            this.rbPoint = new System.Windows.Forms.RadioButton();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // showAxes
            // 
            this.showAxes.AutoSize = true;
            this.showAxes.Checked = true;
            this.showAxes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showAxes.Location = new System.Drawing.Point(1116, 16);
            this.showAxes.Margin = new System.Windows.Forms.Padding(4);
            this.showAxes.Name = "showAxes";
            this.showAxes.Size = new System.Drawing.Size(98, 21);
            this.showAxes.TabIndex = 0;
            this.showAxes.Text = "Show Axes";
            this.showAxes.UseVisualStyleBackColor = true;
            this.showAxes.CheckedChanged += new System.EventHandler(this.showAxes_CheckedChanged);
            // 
            // changeBackground
            // 
            this.changeBackground.Location = new System.Drawing.Point(1116, 133);
            this.changeBackground.Margin = new System.Windows.Forms.Padding(4);
            this.changeBackground.Name = "changeBackground";
            this.changeBackground.Size = new System.Drawing.Size(267, 39);
            this.changeBackground.TabIndex = 1;
            this.changeBackground.Text = "Change background color";
            this.changeBackground.UseVisualStyleBackColor = true;
            this.changeBackground.Click += new System.EventHandler(this.changeBackground_Click);
            // 
            // lblOx
            // 
            this.lblOx.BackColor = System.Drawing.Color.Red;
            this.lblOx.Location = new System.Drawing.Point(1145, 43);
            this.lblOx.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOx.Name = "lblOx";
            this.lblOx.Size = new System.Drawing.Size(53, 25);
            this.lblOx.TabIndex = 2;
            this.lblOx.Text = "Ox";
            this.lblOx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOy
            // 
            this.lblOy.BackColor = System.Drawing.Color.Green;
            this.lblOy.Location = new System.Drawing.Point(1207, 43);
            this.lblOy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOy.Name = "lblOy";
            this.lblOy.Size = new System.Drawing.Size(53, 25);
            this.lblOy.TabIndex = 3;
            this.lblOy.Text = "Oy";
            this.lblOy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOz
            // 
            this.lblOz.BackColor = System.Drawing.Color.Blue;
            this.lblOz.Location = new System.Drawing.Point(1268, 43);
            this.lblOz.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOz.Name = "lblOz";
            this.lblOz.Size = new System.Drawing.Size(53, 25);
            this.lblOz.TabIndex = 4;
            this.lblOz.Text = "Oz";
            this.lblOz.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resetScene
            // 
            this.resetScene.Location = new System.Drawing.Point(1116, 180);
            this.resetScene.Margin = new System.Windows.Forms.Padding(4);
            this.resetScene.Name = "resetScene";
            this.resetScene.Size = new System.Drawing.Size(267, 39);
            this.resetScene.TabIndex = 5;
            this.resetScene.Text = "Reset scene";
            this.resetScene.UseVisualStyleBackColor = true;
            this.resetScene.Click += new System.EventHandler(this.resetScene_Click);
            // 
            // enableRotation
            // 
            this.enableRotation.AutoSize = true;
            this.enableRotation.Location = new System.Drawing.Point(1116, 71);
            this.enableRotation.Margin = new System.Windows.Forms.Padding(4);
            this.enableRotation.Name = "enableRotation";
            this.enableRotation.Size = new System.Drawing.Size(172, 21);
            this.enableRotation.TabIndex = 6;
            this.enableRotation.Text = "Enable mouse rotation";
            this.enableRotation.UseVisualStyleBackColor = true;
            // 
            // enableObjectRotation
            // 
            this.enableObjectRotation.AutoSize = true;
            this.enableObjectRotation.Location = new System.Drawing.Point(1116, 102);
            this.enableObjectRotation.Margin = new System.Windows.Forms.Padding(4);
            this.enableObjectRotation.Name = "enableObjectRotation";
            this.enableObjectRotation.Size = new System.Drawing.Size(168, 21);
            this.enableObjectRotation.TabIndex = 7;
            this.enableObjectRotation.Text = "Enable object rotation";
            this.enableObjectRotation.UseVisualStyleBackColor = true;
            // 
            // btnLights
            // 
            this.btnLights.Location = new System.Drawing.Point(1116, 226);
            this.btnLights.Name = "btnLights";
            this.btnLights.Size = new System.Drawing.Size(267, 39);
            this.btnLights.TabIndex = 8;
            this.btnLights.Text = "Iluminare On/Off";
            this.btnLights.UseVisualStyleBackColor = true;
            this.btnLights.Click += new System.EventHandler(this.buttonLights_Click);
            // 
            // btnSursa0
            // 
            this.btnSursa0.Location = new System.Drawing.Point(1116, 271);
            this.btnSursa0.Name = "btnSursa0";
            this.btnSursa0.Size = new System.Drawing.Size(267, 41);
            this.btnSursa0.TabIndex = 9;
            this.btnSursa0.Text = "Sursa 0 On/Off";
            this.btnSursa0.UseVisualStyleBackColor = true;
            this.btnSursa0.Click += new System.EventHandler(this.btnSursa0_Click);
            // 
            // btnTexture
            // 
            this.btnTexture.Location = new System.Drawing.Point(1116, 318);
            this.btnTexture.Name = "btnTexture";
            this.btnTexture.Size = new System.Drawing.Size(267, 39);
            this.btnTexture.TabIndex = 10;
            this.btnTexture.Text = "Textura ";
            this.btnTexture.UseVisualStyleBackColor = true;
            this.btnTexture.Click += new System.EventHandler(this.btnTexture_Click);
            // 
            // rbFill
            // 
            this.rbFill.AutoSize = true;
            this.rbFill.Location = new System.Drawing.Point(1117, 372);
            this.rbFill.Name = "rbFill";
            this.rbFill.Size = new System.Drawing.Size(46, 21);
            this.rbFill.TabIndex = 14;
            this.rbFill.TabStop = true;
            this.rbFill.Text = "Fill";
            this.rbFill.UseVisualStyleBackColor = true;
            // 
            // rbLine
            // 
            this.rbLine.AutoSize = true;
            this.rbLine.Location = new System.Drawing.Point(1183, 372);
            this.rbLine.Name = "rbLine";
            this.rbLine.Size = new System.Drawing.Size(56, 21);
            this.rbLine.TabIndex = 15;
            this.rbLine.TabStop = true;
            this.rbLine.Text = "Line";
            this.rbLine.UseVisualStyleBackColor = true;
            // 
            // rbPoint
            // 
            this.rbPoint.AutoSize = true;
            this.rbPoint.Location = new System.Drawing.Point(1260, 372);
            this.rbPoint.Name = "rbPoint";
            this.rbPoint.Size = new System.Drawing.Size(61, 21);
            this.rbPoint.TabIndex = 16;
            this.rbPoint.TabStop = true;
            this.rbPoint.Text = "Point";
            this.rbPoint.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(1119, 412);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 17;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1399, 768);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.rbPoint);
            this.Controls.Add(this.rbLine);
            this.Controls.Add(this.rbFill);
            this.Controls.Add(this.btnTexture);
            this.Controls.Add(this.btnSursa0);
            this.Controls.Add(this.btnLights);
            this.Controls.Add(this.enableObjectRotation);
            this.Controls.Add(this.enableRotation);
            this.Controls.Add(this.resetScene);
            this.Controls.Add(this.lblOz);
            this.Controls.Add(this.lblOy);
            this.Controls.Add(this.lblOx);
            this.Controls.Add(this.changeBackground);
            this.Controls.Add(this.showAxes);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "OpenTK 3";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox showAxes;
        private System.Windows.Forms.Button changeBackground;
        private System.Windows.Forms.Label lblOx;
        private System.Windows.Forms.Label lblOy;
        private System.Windows.Forms.Label lblOz;
        private System.Windows.Forms.Button resetScene;
        private System.Windows.Forms.CheckBox enableRotation;
        private System.Windows.Forms.CheckBox enableObjectRotation;
        private System.Windows.Forms.Button btnLights;
        private System.Windows.Forms.Button btnSursa0;
        private System.Windows.Forms.Button btnTexture;
        private System.Windows.Forms.RadioButton rbFill;
        private System.Windows.Forms.RadioButton rbLine;
        private System.Windows.Forms.RadioButton rbPoint;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

