namespace StopWatch
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_Start = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lab_Time = new System.Windows.Forms.Label();
            this.lab_All = new System.Windows.Forms.Label();
            this.btn_Record = new System.Windows.Forms.Button();
            this.box_Record = new System.Windows.Forms.GroupBox();
            this.lab_Record3 = new System.Windows.Forms.Label();
            this.lab_Record2 = new System.Windows.Forms.Label();
            this.lab_Record1 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.box_Record.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Start
            // 
            this.btn_Start.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Start.Location = new System.Drawing.Point(131, 156);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(109, 37);
            this.btn_Start.TabIndex = 0;
            this.btn_Start.Text = "시작/정지";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Reset.Location = new System.Drawing.Point(246, 156);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(86, 37);
            this.btn_Reset.TabIndex = 2;
            this.btn_Reset.Text = "초기화";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lab_Time
            // 
            this.lab_Time.BackColor = System.Drawing.Color.Black;
            this.lab_Time.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lab_Time.ForeColor = System.Drawing.Color.Yellow;
            this.lab_Time.Location = new System.Drawing.Point(12, 9);
            this.lab_Time.Name = "lab_Time";
            this.lab_Time.Size = new System.Drawing.Size(359, 56);
            this.lab_Time.TabIndex = 8;
            this.lab_Time.Text = "장근 스톱워치";
            this.lab_Time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lab_All
            // 
            this.lab_All.AutoSize = true;
            this.lab_All.Font = new System.Drawing.Font("굴림", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lab_All.Location = new System.Drawing.Point(64, 87);
            this.lab_All.Name = "lab_All";
            this.lab_All.Size = new System.Drawing.Size(245, 54);
            this.lab_All.TabIndex = 9;
            this.lab_All.Text = "00:00:00";
            // 
            // btn_Record
            // 
            this.btn_Record.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Record.Location = new System.Drawing.Point(39, 156);
            this.btn_Record.Name = "btn_Record";
            this.btn_Record.Size = new System.Drawing.Size(86, 37);
            this.btn_Record.TabIndex = 10;
            this.btn_Record.Text = "기록";
            this.btn_Record.UseVisualStyleBackColor = true;
            this.btn_Record.Click += new System.EventHandler(this.btn_Record_Click);
            // 
            // box_Record
            // 
            this.box_Record.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.box_Record.Controls.Add(this.lab_Record3);
            this.box_Record.Controls.Add(this.lab_Record2);
            this.box_Record.Controls.Add(this.lab_Record1);
            this.box_Record.Location = new System.Drawing.Point(17, 211);
            this.box_Record.Name = "box_Record";
            this.box_Record.Size = new System.Drawing.Size(354, 161);
            this.box_Record.TabIndex = 11;
            this.box_Record.TabStop = false;
            this.box_Record.Text = "기록";
            // 
            // lab_Record3
            // 
            this.lab_Record3.Location = new System.Drawing.Point(246, 24);
            this.lab_Record3.Name = "lab_Record3";
            this.lab_Record3.Size = new System.Drawing.Size(92, 120);
            this.lab_Record3.TabIndex = 2;
            // 
            // lab_Record2
            // 
            this.lab_Record2.Location = new System.Drawing.Point(131, 24);
            this.lab_Record2.Name = "lab_Record2";
            this.lab_Record2.Size = new System.Drawing.Size(92, 120);
            this.lab_Record2.TabIndex = 1;
            // 
            // lab_Record1
            // 
            this.lab_Record1.Location = new System.Drawing.Point(16, 24);
            this.lab_Record1.Name = "lab_Record1";
            this.lab_Record1.Size = new System.Drawing.Size(92, 120);
            this.lab_Record1.TabIndex = 0;
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(383, 384);
            this.Controls.Add(this.box_Record);
            this.Controls.Add(this.btn_Record);
            this.Controls.Add(this.lab_All);
            this.Controls.Add(this.lab_Time);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_Start);
            this.Name = "Form1";
            this.Text = "장근_스톱워치";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.box_Record.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lab_Time;
        private System.Windows.Forms.Label lab_All;
        private System.Windows.Forms.Button btn_Record;
        private System.Windows.Forms.GroupBox box_Record;
        private System.Windows.Forms.Label lab_Record1;
        private System.Windows.Forms.Label lab_Record3;
        private System.Windows.Forms.Label lab_Record2;
        private System.Windows.Forms.Timer timer2;
    }
}

