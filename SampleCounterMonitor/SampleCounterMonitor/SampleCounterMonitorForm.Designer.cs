namespace SampleCounterMonitor {
    partial class SampleCounterMonitorForm {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SampleCounterMonitorForm));
            this.LogicalStationNumberLabel = new System.Windows.Forms.Label();
            this.LogicalStationNumberText = new System.Windows.Forms.TextBox();
            this.LoggingLabel = new System.Windows.Forms.Label();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.MessageText = new System.Windows.Forms.TextBox();
            this.Y3Text = new System.Windows.Forms.TextBox();
            this.ResetButton = new System.Windows.Forms.Button();
            this.CountUpButton = new System.Windows.Forms.Button();
            this.Y3Label = new System.Windows.Forms.Label();
            this.WriteC0Button = new System.Windows.Forms.Button();
            this.C0Label = new System.Windows.Forms.Label();
            this.C0Text = new System.Windows.Forms.TextBox();
            this.LoggingList = new System.Windows.Forms.ListBox();
            this.EndButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.CPUTypeText = new System.Windows.Forms.TextBox();
            this.CPUTypeLabel = new System.Windows.Forms.Label();
            this.ActSupportMsg = new AxActSupportMsgLib.AxActSupportMsg();
            this.ActUtlType = new AxActUtlTypeLib.AxActUtlType();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ActSupportMsg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActUtlType)).BeginInit();
            this.SuspendLayout();
            // 
            // LogicalStationNumberLabel
            // 
            this.LogicalStationNumberLabel.AutoSize = true;
            this.LogicalStationNumberLabel.Location = new System.Drawing.Point(3, 10);
            this.LogicalStationNumberLabel.Name = "LogicalStationNumberLabel";
            this.LogicalStationNumberLabel.Size = new System.Drawing.Size(59, 12);
            this.LogicalStationNumberLabel.TabIndex = 99;
            this.LogicalStationNumberLabel.Text = "論理局番：";
            // 
            // LogicalStationNumberText
            // 
            this.LogicalStationNumberText.Location = new System.Drawing.Point(84, 7);
            this.LogicalStationNumberText.Name = "LogicalStationNumberText";
            this.LogicalStationNumberText.Size = new System.Drawing.Size(52, 19);
            this.LogicalStationNumberText.TabIndex = 98;
            // 
            // LoggingLabel
            // 
            this.LoggingLabel.AutoSize = true;
            this.LoggingLabel.Location = new System.Drawing.Point(3, 301);
            this.LoggingLabel.Name = "LoggingLabel";
            this.LoggingLabel.Size = new System.Drawing.Size(53, 12);
            this.LoggingLabel.TabIndex = 97;
            this.LoggingLabel.Text = "監視ログ：";
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.Location = new System.Drawing.Point(3, 147);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(56, 12);
            this.MessageLabel.TabIndex = 96;
            this.MessageLabel.Text = "メッセージ：";
            // 
            // MessageText
            // 
            this.MessageText.Location = new System.Drawing.Point(84, 147);
            this.MessageText.Multiline = true;
            this.MessageText.Name = "MessageText";
            this.MessageText.ReadOnly = true;
            this.MessageText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MessageText.Size = new System.Drawing.Size(382, 151);
            this.MessageText.TabIndex = 95;
            this.MessageText.TabStop = false;
            // 
            // Y3Text
            // 
            this.Y3Text.Location = new System.Drawing.Point(84, 124);
            this.Y3Text.Name = "Y3Text";
            this.Y3Text.ReadOnly = true;
            this.Y3Text.Size = new System.Drawing.Size(52, 19);
            this.Y3Text.TabIndex = 94;
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(205, 32);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(94, 32);
            this.ResetButton.TabIndex = 93;
            this.ResetButton.Text = "RESET";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // CountUpButton
            // 
            this.CountUpButton.Location = new System.Drawing.Point(105, 32);
            this.CountUpButton.Name = "CountUpButton";
            this.CountUpButton.Size = new System.Drawing.Size(94, 32);
            this.CountUpButton.TabIndex = 92;
            this.CountUpButton.Text = "COUNT UP";
            this.CountUpButton.UseVisualStyleBackColor = true;
            this.CountUpButton.Click += new System.EventHandler(this.CountUpButton_Click);
            // 
            // Y3Label
            // 
            this.Y3Label.AutoSize = true;
            this.Y3Label.Location = new System.Drawing.Point(3, 127);
            this.Y3Label.Name = "Y3Label";
            this.Y3Label.Size = new System.Drawing.Size(74, 12);
            this.Y3Label.TabIndex = 91;
            this.Y3Label.Text = "Y3デバイス値：";
            // 
            // WriteC0Button
            // 
            this.WriteC0Button.Location = new System.Drawing.Point(142, 102);
            this.WriteC0Button.Name = "WriteC0Button";
            this.WriteC0Button.Size = new System.Drawing.Size(101, 19);
            this.WriteC0Button.TabIndex = 90;
            this.WriteC0Button.Text = "カウンタ値変更";
            this.WriteC0Button.UseVisualStyleBackColor = true;
            this.WriteC0Button.Click += new System.EventHandler(this.WriteC0Button_Click);
            // 
            // C0Label
            // 
            this.C0Label.AutoSize = true;
            this.C0Label.Location = new System.Drawing.Point(3, 105);
            this.C0Label.Name = "C0Label";
            this.C0Label.Size = new System.Drawing.Size(75, 12);
            this.C0Label.TabIndex = 89;
            this.C0Label.Text = "C0デバイス値：";
            // 
            // C0Text
            // 
            this.C0Text.Location = new System.Drawing.Point(84, 102);
            this.C0Text.Name = "C0Text";
            this.C0Text.Size = new System.Drawing.Size(52, 19);
            this.C0Text.TabIndex = 88;
            // 
            // LoggingList
            // 
            this.LoggingList.FormattingEnabled = true;
            this.LoggingList.ItemHeight = 12;
            this.LoggingList.Location = new System.Drawing.Point(5, 316);
            this.LoggingList.Name = "LoggingList";
            this.LoggingList.Size = new System.Drawing.Size(461, 208);
            this.LoggingList.TabIndex = 87;
            // 
            // EndButton
            // 
            this.EndButton.Location = new System.Drawing.Point(305, 32);
            this.EndButton.Name = "EndButton";
            this.EndButton.Size = new System.Drawing.Size(94, 32);
            this.EndButton.TabIndex = 86;
            this.EndButton.Text = "モニタ終了";
            this.EndButton.UseVisualStyleBackColor = true;
            this.EndButton.Click += new System.EventHandler(this.EndButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(4, 32);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(94, 32);
            this.StartButton.TabIndex = 85;
            this.StartButton.Text = "モニタ開始";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // CPUTypeText
            // 
            this.CPUTypeText.Location = new System.Drawing.Point(84, 81);
            this.CPUTypeText.Name = "CPUTypeText";
            this.CPUTypeText.ReadOnly = true;
            this.CPUTypeText.Size = new System.Drawing.Size(215, 19);
            this.CPUTypeText.TabIndex = 101;
            // 
            // CPUTypeLabel
            // 
            this.CPUTypeLabel.AutoSize = true;
            this.CPUTypeLabel.Location = new System.Drawing.Point(3, 85);
            this.CPUTypeLabel.Name = "CPUTypeLabel";
            this.CPUTypeLabel.Size = new System.Drawing.Size(63, 12);
            this.CPUTypeLabel.TabIndex = 102;
            this.CPUTypeLabel.Text = "CPU Type：";
            // 
            // ActSupportMsg
            // 
            this.ActSupportMsg.Enabled = true;
            this.ActSupportMsg.Location = new System.Drawing.Point(419, 70);
            this.ActSupportMsg.Name = "ActSupportMsg";
            this.ActSupportMsg.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("ActSupportMsg.OcxState")));
            this.ActSupportMsg.Size = new System.Drawing.Size(32, 32);
            this.ActSupportMsg.TabIndex = 100;
            // 
            // ActUtlType
            // 
            this.ActUtlType.Enabled = true;
            this.ActUtlType.Location = new System.Drawing.Point(419, 32);
            this.ActUtlType.Name = "ActUtlType";
            this.ActUtlType.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("ActUtlType.OcxState")));
            this.ActUtlType.Size = new System.Drawing.Size(32, 32);
            this.ActUtlType.TabIndex = 0;
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // SampleCounterMonitorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 531);
            this.Controls.Add(this.CPUTypeLabel);
            this.Controls.Add(this.CPUTypeText);
            this.Controls.Add(this.ActSupportMsg);
            this.Controls.Add(this.LogicalStationNumberLabel);
            this.Controls.Add(this.LogicalStationNumberText);
            this.Controls.Add(this.LoggingLabel);
            this.Controls.Add(this.MessageLabel);
            this.Controls.Add(this.MessageText);
            this.Controls.Add(this.Y3Text);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.CountUpButton);
            this.Controls.Add(this.Y3Label);
            this.Controls.Add(this.WriteC0Button);
            this.Controls.Add(this.C0Label);
            this.Controls.Add(this.C0Text);
            this.Controls.Add(this.LoggingList);
            this.Controls.Add(this.EndButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.ActUtlType);
            this.Name = "SampleCounterMonitorForm";
            this.Text = "SampleCounterMonitor";
            ((System.ComponentModel.ISupportInitialize)(this.ActSupportMsg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActUtlType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxActUtlTypeLib.AxActUtlType ActUtlType;
        private System.Windows.Forms.Label LogicalStationNumberLabel;
        private System.Windows.Forms.TextBox LogicalStationNumberText;
        private System.Windows.Forms.Label LoggingLabel;
        private System.Windows.Forms.Label MessageLabel;
        internal System.Windows.Forms.TextBox MessageText;
        private System.Windows.Forms.TextBox Y3Text;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button CountUpButton;
        private System.Windows.Forms.Label Y3Label;
        private System.Windows.Forms.Button WriteC0Button;
        private System.Windows.Forms.Label C0Label;
        private System.Windows.Forms.TextBox C0Text;
        private System.Windows.Forms.ListBox LoggingList;
        private System.Windows.Forms.Button EndButton;
        private System.Windows.Forms.Button StartButton;
        private AxActSupportMsgLib.AxActSupportMsg ActSupportMsg;
        private System.Windows.Forms.TextBox CPUTypeText;
        private System.Windows.Forms.Label CPUTypeLabel;
        private System.Windows.Forms.Timer Timer;
    }
}

