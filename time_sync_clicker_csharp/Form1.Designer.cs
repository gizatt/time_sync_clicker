namespace time_sync_clicker_csharp
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
            this.components = new System.ComponentModel.Container();
            this.btn_schedule_click = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label_time_to_click = new System.Windows.Forms.Label();
            this.label_time = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxBufferSecs = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_cancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label_offset = new System.Windows.Forms.Label();
            this.timer_timesync = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btn_schedule_click
            // 
            this.btn_schedule_click.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_schedule_click.Location = new System.Drawing.Point(6, 13);
            this.btn_schedule_click.Name = "btn_schedule_click";
            this.btn_schedule_click.Size = new System.Drawing.Size(177, 43);
            this.btn_schedule_click.TabIndex = 0;
            this.btn_schedule_click.Text = "Queue Synchro-click";
            this.btn_schedule_click.UseVisualStyleBackColor = true;
            this.btn_schedule_click.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Info;
            this.label8.Location = new System.Drawing.Point(22, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Clicking in:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label_time_to_click
            // 
            this.label_time_to_click.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_time_to_click.Location = new System.Drawing.Point(86, 143);
            this.label_time_to_click.Name = "label_time_to_click";
            this.label_time_to_click.Size = new System.Drawing.Size(83, 13);
            this.label_time_to_click.TabIndex = 9;
            this.label_time_to_click.Text = "<>";
            this.label_time_to_click.Click += new System.EventHandler(this.label_time_to_click_Click);
            // 
            // label_time
            // 
            this.label_time.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_time.Location = new System.Drawing.Point(86, 109);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(83, 13);
            this.label_time.TabIndex = 10;
            this.label_time.Text = "<>";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(47, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Now:";
            // 
            // textBoxBufferSecs
            // 
            this.textBoxBufferSecs.CausesValidation = false;
            this.textBoxBufferSecs.Location = new System.Drawing.Point(102, 85);
            this.textBoxBufferSecs.MaxLength = 2;
            this.textBoxBufferSecs.Name = "textBoxBufferSecs";
            this.textBoxBufferSecs.Size = new System.Drawing.Size(30, 20);
            this.textBoxBufferSecs.TabIndex = 12;
            this.textBoxBufferSecs.Text = "5";
            this.textBoxBufferSecs.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(22, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Buffer time (s):";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cancel.Location = new System.Drawing.Point(57, 58);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 14;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(41, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Offset:";
            // 
            // label_offset
            // 
            this.label_offset.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_offset.Location = new System.Drawing.Point(86, 126);
            this.label_offset.Name = "label_offset";
            this.label_offset.Size = new System.Drawing.Size(83, 13);
            this.label_offset.TabIndex = 15;
            this.label_offset.Text = "<>";
            // 
            // timer_timesync
            // 
            this.timer_timesync.Enabled = true;
            this.timer_timesync.Interval = 10000;
            this.timer_timesync.Tick += new System.EventHandler(this.timer_timesync_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(190, 165);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_offset);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxBufferSecs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_time);
            this.Controls.Add(this.label_time_to_click);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_schedule_click);
            this.Name = "Form1";
            this.Text = "Synchroclicker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_schedule_click;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label_time_to_click;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxBufferSecs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_offset;
        private System.Windows.Forms.Timer timer_timesync;
    }
}

