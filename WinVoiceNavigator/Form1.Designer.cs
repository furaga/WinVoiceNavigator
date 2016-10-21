namespace WinVoiceNavigator
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.volume = new System.Windows.Forms.NumericUpDown();
            this.speed = new System.Windows.Forms.NumericUpDown();
            this.pitch = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.focusWindowNameLabel = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.enableCBox = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.volume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pitch)).BeginInit();
            this.SuspendLayout();
            // 
            // volume
            // 
            this.volume.Location = new System.Drawing.Point(160, 103);
            this.volume.Margin = new System.Windows.Forms.Padding(4);
            this.volume.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.volume.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.volume.Name = "volume";
            this.volume.Size = new System.Drawing.Size(180, 23);
            this.volume.TabIndex = 2;
            this.volume.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // speed
            // 
            this.speed.Location = new System.Drawing.Point(160, 136);
            this.speed.Margin = new System.Windows.Forms.Padding(4);
            this.speed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.speed.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.speed.Name = "speed";
            this.speed.Size = new System.Drawing.Size(180, 23);
            this.speed.TabIndex = 3;
            this.speed.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // pitch
            // 
            this.pitch.Location = new System.Drawing.Point(160, 173);
            this.pitch.Margin = new System.Windows.Forms.Padding(4);
            this.pitch.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.pitch.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.pitch.Name = "pitch";
            this.pitch.Size = new System.Drawing.Size(180, 23);
            this.pitch.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 103);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Volume (0 - 100)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Speed (-10 - 10)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 176);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Pitch (-10 - 10)";
            // 
            // focusWindowNameLabel
            // 
            this.focusWindowNameLabel.AutoSize = true;
            this.focusWindowNameLabel.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.focusWindowNameLabel.Location = new System.Drawing.Point(157, 56);
            this.focusWindowNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.focusWindowNameLabel.Name = "focusWindowNameLabel";
            this.focusWindowNameLabel.Size = new System.Drawing.Size(108, 16);
            this.focusWindowNameLabel.TabIndex = 9;
            this.focusWindowNameLabel.Text = "Visual Studio";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // enableCBox
            // 
            this.enableCBox.AutoSize = true;
            this.enableCBox.Checked = true;
            this.enableCBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.enableCBox.Location = new System.Drawing.Point(21, 16);
            this.enableCBox.Margin = new System.Windows.Forms.Padding(4);
            this.enableCBox.Name = "enableCBox";
            this.enableCBox.Size = new System.Drawing.Size(339, 20);
            this.enableCBox.TabIndex = 11;
            this.enableCBox.Text = "フォーカス移動検知＋音声読み上げを有効にする";
            this.enableCBox.UseVisualStyleBackColor = true;
            this.enableCBox.CheckedChanged += new System.EventHandler(this.enableCBox_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 56);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "現在のフォーカス";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 222);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.enableCBox);
            this.Controls.Add(this.focusWindowNameLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pitch);
            this.Controls.Add(this.speed);
            this.Controls.Add(this.volume);
            this.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.volume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pitch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown volume;
        private System.Windows.Forms.NumericUpDown speed;
        private System.Windows.Forms.NumericUpDown pitch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label focusWindowNameLabel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.CheckBox enableCBox;
        private System.Windows.Forms.Label label5;
    }
}

