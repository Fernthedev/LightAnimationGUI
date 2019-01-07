namespace LightAnimationGUICsharp
{
    partial class LightAnimator4Pi
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LightAnimator4Pi));
            this.selectedpin = new System.Windows.Forms.NumericUpDown();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.frame = new System.Windows.Forms.NumericUpDown();
            this.fps = new System.Windows.Forms.NumericUpDown();
            this.whichpi = new System.Windows.Forms.ComboBox();
            this.onPin = new System.Windows.Forms.Button();
            this.fpsLabel = new System.Windows.Forms.Label();
            this.selectedFrameLabel = new System.Windows.Forms.Label();
            this.pinLabel = new System.Windows.Forms.Label();
            this.piLabel = new System.Windows.Forms.Label();
            this.offPin = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.logBox = new System.Windows.Forms.ListView();
            this.saveButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.savePath = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.selectedpin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fps)).BeginInit();
            this.SuspendLayout();
            // 
            // selectedpin
            // 
            this.selectedpin.AccessibleName = "Pin";
            this.selectedpin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectedpin.Location = new System.Drawing.Point(668, 40);
            this.selectedpin.Name = "selectedpin";
            this.selectedpin.Size = new System.Drawing.Size(120, 20);
            this.selectedpin.TabIndex = 0;
            this.selectedpin.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // frame
            // 
            this.frame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.frame.Location = new System.Drawing.Point(668, 94);
            this.frame.Name = "frame";
            this.frame.Size = new System.Drawing.Size(120, 20);
            this.frame.TabIndex = 2;
            this.frame.Tag = "frame";
            this.frame.ValueChanged += new System.EventHandler(this.frame_ValueChanged);
            // 
            // fps
            // 
            this.fps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fps.Location = new System.Drawing.Point(668, 143);
            this.fps.Name = "fps";
            this.fps.Size = new System.Drawing.Size(120, 20);
            this.fps.TabIndex = 3;
            this.fps.Tag = "fps";
            this.fps.ValueChanged += new System.EventHandler(this.fps_ValueChanged);
            // 
            // whichpi
            // 
            this.whichpi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.whichpi.FormattingEnabled = true;
            this.whichpi.Location = new System.Drawing.Point(607, 196);
            this.whichpi.Name = "whichpi";
            this.whichpi.Size = new System.Drawing.Size(182, 21);
            this.whichpi.TabIndex = 5;
            this.whichpi.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // onPin
            // 
            this.onPin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.onPin.Location = new System.Drawing.Point(12, 415);
            this.onPin.Name = "onPin";
            this.onPin.Size = new System.Drawing.Size(75, 23);
            this.onPin.TabIndex = 6;
            this.onPin.Text = "On";
            this.onPin.UseVisualStyleBackColor = true;
            this.onPin.Click += new System.EventHandler(this.onPin_Click);
            // 
            // fpsLabel
            // 
            this.fpsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fpsLabel.AutoSize = true;
            this.fpsLabel.Location = new System.Drawing.Point(665, 127);
            this.fpsLabel.Name = "fpsLabel";
            this.fpsLabel.Size = new System.Drawing.Size(27, 13);
            this.fpsLabel.TabIndex = 7;
            this.fpsLabel.Text = "FPS";
            // 
            // selectedFrameLabel
            // 
            this.selectedFrameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectedFrameLabel.AutoSize = true;
            this.selectedFrameLabel.Location = new System.Drawing.Point(665, 78);
            this.selectedFrameLabel.Name = "selectedFrameLabel";
            this.selectedFrameLabel.Size = new System.Drawing.Size(81, 13);
            this.selectedFrameLabel.TabIndex = 8;
            this.selectedFrameLabel.Text = "Selected Frame";
            // 
            // pinLabel
            // 
            this.pinLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pinLabel.AutoSize = true;
            this.pinLabel.Location = new System.Drawing.Point(665, 20);
            this.pinLabel.Name = "pinLabel";
            this.pinLabel.Size = new System.Drawing.Size(67, 13);
            this.pinLabel.TabIndex = 9;
            this.pinLabel.Text = "Selected Pin";
            // 
            // piLabel
            // 
            this.piLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.piLabel.AutoSize = true;
            this.piLabel.Location = new System.Drawing.Point(668, 177);
            this.piLabel.Name = "piLabel";
            this.piLabel.Size = new System.Drawing.Size(49, 13);
            this.piLabel.TabIndex = 10;
            this.piLabel.Text = "Pi Preset";
            // 
            // offPin
            // 
            this.offPin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.offPin.Location = new System.Drawing.Point(93, 415);
            this.offPin.Name = "offPin";
            this.offPin.Size = new System.Drawing.Size(75, 23);
            this.offPin.TabIndex = 11;
            this.offPin.Text = "Off";
            this.offPin.UseVisualStyleBackColor = true;
            this.offPin.Click += new System.EventHandler(this.offPin_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(22, 399);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(103, 13);
            this.statusLabel.TabIndex = 12;
            this.statusLabel.Text = "The current status is";
            // 
            // logBox
            // 
            this.logBox.Location = new System.Drawing.Point(13, 13);
            this.logBox.Name = "logBox";
            this.logBox.Size = new System.Drawing.Size(155, 360);
            this.logBox.TabIndex = 13;
            this.logBox.UseCompatibleStateImageBehavior = false;
            this.logBox.View = System.Windows.Forms.View.List;
            this.logBox.SelectedIndexChanged += new System.EventHandler(this.logBox_SelectedIndexChanged);
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Location = new System.Drawing.Point(668, 223);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 14;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // savePath
            // 
            this.savePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.savePath.Location = new System.Drawing.Point(668, 253);
            this.savePath.Name = "savePath";
            this.savePath.Size = new System.Drawing.Size(100, 20);
            this.savePath.TabIndex = 15;
            // 
            // LightAnimator4Pi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.savePath);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.offPin);
            this.Controls.Add(this.piLabel);
            this.Controls.Add(this.pinLabel);
            this.Controls.Add(this.selectedFrameLabel);
            this.Controls.Add(this.fpsLabel);
            this.Controls.Add(this.onPin);
            this.Controls.Add(this.whichpi);
            this.Controls.Add(this.fps);
            this.Controls.Add(this.frame);
            this.Controls.Add(this.selectedpin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LightAnimator4Pi";
            this.Text = "LightAnimator4Pi";
            ((System.ComponentModel.ISupportInitialize)(this.selectedpin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fps)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown selectedpin;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.NumericUpDown frame;
        private System.Windows.Forms.NumericUpDown fps;
        private System.Windows.Forms.ComboBox whichpi;
        private System.Windows.Forms.Button onPin;
        private System.Windows.Forms.Label fpsLabel;
        private System.Windows.Forms.Label selectedFrameLabel;
        private System.Windows.Forms.Label pinLabel;
        private System.Windows.Forms.Label piLabel;
        private System.Windows.Forms.Button offPin;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.ListView logBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox savePath;
    }
}

