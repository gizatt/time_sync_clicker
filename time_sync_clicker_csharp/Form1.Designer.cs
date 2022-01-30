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
            this.label8.Location = new System.Drawing.Point(20, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Clicking in:";
            // 
            // label_time_to_click
            // 
            this.label_time_to_click.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_time_to_click.Location = new System.Drawing.Point(84, 76);
            this.label_time_to_click.Name = "label_time_to_click";
            this.label_time_to_click.Size = new System.Drawing.Size(83, 13);
            this.label_time_to_click.TabIndex = 9;
            this.label_time_to_click.Text = "<>";
            // 
            // label_time
            // 
            this.label_time.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_time.Location = new System.Drawing.Point(51, 61);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(190, 111);
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
    }
}

