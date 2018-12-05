namespace Lotto
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
            this.lottoView = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.메인ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.통계ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.번호별통계ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.홀짝통계ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.구간별출현횟수통계ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.기간별미출현ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.연속번호출현통계ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbGames = new System.Windows.Forms.ComboBox();
            this.lbl_LuckNum = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lottoView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lottoView
            // 
            this.lottoView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lottoView.Location = new System.Drawing.Point(12, 238);
            this.lottoView.MultiSelect = false;
            this.lottoView.Name = "lottoView";
            this.lottoView.RowTemplate.Height = 23;
            this.lottoView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lottoView.Size = new System.Drawing.Size(981, 361);
            this.lottoView.TabIndex = 0;
            this.lottoView.Click += new System.EventHandler(this.lottoView_Click);
            this.lottoView.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lottoView_KeyUp);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.메인ToolStripMenuItem,
            this.통계ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1005, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 메인ToolStripMenuItem
            // 
            this.메인ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.종료ToolStripMenuItem});
            this.메인ToolStripMenuItem.Name = "메인ToolStripMenuItem";
            this.메인ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.메인ToolStripMenuItem.Text = "메인";
            // 
            // 종료ToolStripMenuItem
            // 
            this.종료ToolStripMenuItem.Name = "종료ToolStripMenuItem";
            this.종료ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.종료ToolStripMenuItem.Text = "종료";
            this.종료ToolStripMenuItem.Click += new System.EventHandler(this.종료ToolStripMenuItem_Click);
            // 
            // 통계ToolStripMenuItem
            // 
            this.통계ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.번호별통계ToolStripMenuItem,
            this.홀짝통계ToolStripMenuItem,
            this.구간별출현횟수통계ToolStripMenuItem,
            this.기간별미출현ToolStripMenuItem,
            this.연속번호출현통계ToolStripMenuItem});
            this.통계ToolStripMenuItem.Name = "통계ToolStripMenuItem";
            this.통계ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.통계ToolStripMenuItem.Text = "통계";
            // 
            // 번호별통계ToolStripMenuItem
            // 
            this.번호별통계ToolStripMenuItem.Name = "번호별통계ToolStripMenuItem";
            this.번호별통계ToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.번호별통계ToolStripMenuItem.Text = "번호별 통계";
            this.번호별통계ToolStripMenuItem.Click += new System.EventHandler(this.번호별통계ToolStripMenuItem_Click);
            // 
            // 홀짝통계ToolStripMenuItem
            // 
            this.홀짝통계ToolStripMenuItem.Name = "홀짝통계ToolStripMenuItem";
            this.홀짝통계ToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.홀짝통계ToolStripMenuItem.Text = "홀짝 통계";
            this.홀짝통계ToolStripMenuItem.Click += new System.EventHandler(this.홀짝통계ToolStripMenuItem_Click);
            // 
            // 구간별출현횟수통계ToolStripMenuItem
            // 
            this.구간별출현횟수통계ToolStripMenuItem.Name = "구간별출현횟수통계ToolStripMenuItem";
            this.구간별출현횟수통계ToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.구간별출현횟수통계ToolStripMenuItem.Text = "구간별 출현횟수 통계";
            this.구간별출현횟수통계ToolStripMenuItem.Click += new System.EventHandler(this.구간별출현횟수통계ToolStripMenuItem_Click);
            // 
            // 기간별미출현ToolStripMenuItem
            // 
            this.기간별미출현ToolStripMenuItem.Name = "기간별미출현ToolStripMenuItem";
            this.기간별미출현ToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.기간별미출현ToolStripMenuItem.Text = "기간별 미출현번호 통계";
            this.기간별미출현ToolStripMenuItem.Click += new System.EventHandler(this.기간별미출현ToolStripMenuItem_Click);
            // 
            // 연속번호출현통계ToolStripMenuItem
            // 
            this.연속번호출현통계ToolStripMenuItem.Name = "연속번호출현통계ToolStripMenuItem";
            this.연속번호출현통계ToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.연속번호출현통계ToolStripMenuItem.Text = "연속번호 출현 통계";
            this.연속번호출현통계ToolStripMenuItem.Click += new System.EventHandler(this.연속번호출현통계ToolStripMenuItem_Click);
            // 
            // cbGames
            // 
            this.cbGames.FormattingEnabled = true;
            this.cbGames.Location = new System.Drawing.Point(839, 212);
            this.cbGames.Name = "cbGames";
            this.cbGames.Size = new System.Drawing.Size(121, 20);
            this.cbGames.TabIndex = 2;
            this.cbGames.SelectedIndexChanged += new System.EventHandler(this.cbGames_SelectedIndexChanged);
            this.cbGames.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbGames_KeyDown);
            // 
            // lbl_LuckNum
            // 
            this.lbl_LuckNum.AutoSize = true;
            this.lbl_LuckNum.Font = new System.Drawing.Font("굴림", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_LuckNum.Location = new System.Drawing.Point(263, 51);
            this.lbl_LuckNum.Name = "lbl_LuckNum";
            this.lbl_LuckNum.Size = new System.Drawing.Size(169, 53);
            this.lbl_LuckNum.TabIndex = 4;
            this.lbl_LuckNum.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(171, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 53);
            this.label1.TabIndex = 5;
            this.label1.Text = "10";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(260, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 53);
            this.label2.TabIndex = 6;
            this.label2.Text = "20";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(349, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 53);
            this.label3.TabIndex = 7;
            this.label3.Text = "30";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(438, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 53);
            this.label4.TabIndex = 8;
            this.label4.Text = "40";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(527, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 53);
            this.label5.TabIndex = 9;
            this.label5.Text = "50";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(616, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 53);
            this.label6.TabIndex = 10;
            this.label6.Text = "60";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(767, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 53);
            this.label7.TabIndex = 11;
            this.label7.Text = "70";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("굴림", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(705, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 53);
            this.label8.TabIndex = 12;
            this.label8.Text = "+";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 611);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_LuckNum);
            this.Controls.Add(this.cbGames);
            this.Controls.Add(this.lottoView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "로또 프로그램";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lottoView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView lottoView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 메인ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 종료ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 통계ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 번호별통계ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 홀짝통계ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 구간별출현횟수통계ToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbGames;
        private System.Windows.Forms.ToolStripMenuItem 기간별미출현ToolStripMenuItem;
        private System.Windows.Forms.Label lbl_LuckNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;

        private System.Windows.Forms.ToolStripMenuItem 연속번호출현통계ToolStripMenuItem;

    }
}

