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
            this.메인홈으로ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.통계ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.번호별통계ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.홀짝통계ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.구간별출현횟수통계ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.lottoView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lottoView
            // 
            this.lottoView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lottoView.Location = new System.Drawing.Point(12, 249);
            this.lottoView.Name = "lottoView";
            this.lottoView.RowTemplate.Height = 23;
            this.lottoView.Size = new System.Drawing.Size(860, 350);
            this.lottoView.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.메인ToolStripMenuItem,
            this.통계ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1184, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 메인ToolStripMenuItem
            // 
            this.메인ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.메인홈으로ToolStripMenuItem,
            this.종료ToolStripMenuItem});
            this.메인ToolStripMenuItem.Name = "메인ToolStripMenuItem";
            this.메인ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.메인ToolStripMenuItem.Text = "메인";
            // 
            // 메인홈으로ToolStripMenuItem
            // 
            this.메인홈으로ToolStripMenuItem.Name = "메인홈으로ToolStripMenuItem";
            this.메인홈으로ToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.메인홈으로ToolStripMenuItem.Text = "메인홈으로";
            // 
            // 종료ToolStripMenuItem
            // 
            this.종료ToolStripMenuItem.Name = "종료ToolStripMenuItem";
            this.종료ToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.종료ToolStripMenuItem.Text = "종료";
            // 
            // 통계ToolStripMenuItem
            // 
            this.통계ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.번호별통계ToolStripMenuItem,
            this.홀짝통계ToolStripMenuItem,
            this.구간별출현횟수통계ToolStripMenuItem});
            this.통계ToolStripMenuItem.Name = "통계ToolStripMenuItem";
            this.통계ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.통계ToolStripMenuItem.Text = "통계";
            // 
            // 번호별통계ToolStripMenuItem
            // 
            this.번호별통계ToolStripMenuItem.Name = "번호별통계ToolStripMenuItem";
            this.번호별통계ToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.번호별통계ToolStripMenuItem.Text = "번호별 통계";
            // 
            // 홀짝통계ToolStripMenuItem
            // 
            this.홀짝통계ToolStripMenuItem.Name = "홀짝통계ToolStripMenuItem";
            this.홀짝통계ToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.홀짝통계ToolStripMenuItem.Text = "홀짝 통계";
            // 
            // 구간별출현횟수통계ToolStripMenuItem
            // 
            this.구간별출현횟수통계ToolStripMenuItem.Name = "구간별출현횟수통계ToolStripMenuItem";
            this.구간별출현횟수통계ToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.구간별출현횟수통계ToolStripMenuItem.Text = "구간별 출현횟수 통계";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 611);
            this.Controls.Add(this.lottoView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.ToolStripMenuItem 메인홈으로ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 종료ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 통계ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 번호별통계ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 홀짝통계ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 구간별출현횟수통계ToolStripMenuItem;
    }
}

