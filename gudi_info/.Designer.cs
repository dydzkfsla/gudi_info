namespace gudi_info
{
    partial class Form5
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.res_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.res_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trv_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trv_info_start_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.내정보ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.정보수정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ㄴ9ㅇToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.결제내역ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.상품정보ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.상품리스트ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.대표여행지ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.모든여행지ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(159, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "예약내역";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.res_ID,
            this.res_date,
            this.trv_name,
            this.trv_info_start_date});
            this.dataGridView1.Location = new System.Drawing.Point(0, 80);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(511, 454);
            this.dataGridView1.TabIndex = 4;
            // 
            // res_ID
            // 
            this.res_ID.HeaderText = "예약번호";
            this.res_ID.Name = "res_ID";
            this.res_ID.ReadOnly = true;
            this.res_ID.Width = 120;
            // 
            // res_date
            // 
            this.res_date.HeaderText = "주문일자";
            this.res_date.Name = "res_date";
            this.res_date.Width = 120;
            // 
            // trv_name
            // 
            this.trv_name.HeaderText = "상품명";
            this.trv_name.Name = "trv_name";
            this.trv_name.ReadOnly = true;
            // 
            // trv_info_start_date
            // 
            this.trv_info_start_date.HeaderText = "출발일";
            this.trv_info_start_date.Name = "trv_info_start_date";
            this.trv_info_start_date.ReadOnly = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SkyBlue;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.내정보ToolStripMenuItem,
            this.상품정보ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(511, 27);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 내정보ToolStripMenuItem
            // 
            this.내정보ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.정보수정ToolStripMenuItem,
            this.ㄴ9ㅇToolStripMenuItem,
            this.결제내역ToolStripMenuItem});
            this.내정보ToolStripMenuItem.Name = "내정보ToolStripMenuItem";
            this.내정보ToolStripMenuItem.Size = new System.Drawing.Size(59, 19);
            this.내정보ToolStripMenuItem.Text = "내 정보";
            // 
            // 정보수정ToolStripMenuItem
            // 
            this.정보수정ToolStripMenuItem.Name = "정보수정ToolStripMenuItem";
            this.정보수정ToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.정보수정ToolStripMenuItem.Text = "정보 수정";
            // 
            // ㄴ9ㅇToolStripMenuItem
            // 
            this.ㄴ9ㅇToolStripMenuItem.Name = "ㄴ9ㅇToolStripMenuItem";
            this.ㄴ9ㅇToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.ㄴ9ㅇToolStripMenuItem.Text = "예약 정보";
            // 
            // 결제내역ToolStripMenuItem
            // 
            this.결제내역ToolStripMenuItem.Name = "결제내역ToolStripMenuItem";
            this.결제내역ToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.결제내역ToolStripMenuItem.Text = "결제 내역";
            // 
            // 상품정보ToolStripMenuItem
            // 
            this.상품정보ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.상품리스트ToolStripMenuItem,
            this.대표여행지ToolStripMenuItem1,
            this.모든여행지ToolStripMenuItem1});
            this.상품정보ToolStripMenuItem.Name = "상품정보ToolStripMenuItem";
            this.상품정보ToolStripMenuItem.Size = new System.Drawing.Size(75, 19);
            this.상품정보ToolStripMenuItem.Text = "상품 정보 ";
            // 
            // 상품리스트ToolStripMenuItem
            // 
            this.상품리스트ToolStripMenuItem.Name = "상품리스트ToolStripMenuItem";
            this.상품리스트ToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.상품리스트ToolStripMenuItem.Text = "상품 리스트";
            // 
            // 대표여행지ToolStripMenuItem1
            // 
            this.대표여행지ToolStripMenuItem1.Name = "대표여행지ToolStripMenuItem1";
            this.대표여행지ToolStripMenuItem1.Size = new System.Drawing.Size(138, 22);
            this.대표여행지ToolStripMenuItem1.Text = "대표 여행지";
            // 
            // 모든여행지ToolStripMenuItem1
            // 
            this.모든여행지ToolStripMenuItem1.Name = "모든여행지ToolStripMenuItem1";
            this.모든여행지ToolStripMenuItem1.Size = new System.Drawing.Size(138, 22);
            this.모든여행지ToolStripMenuItem1.Text = "모든 여행지";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(511, 533);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form5";
            this.Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn res_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn res_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn trv_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn trv_info_start_date;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 내정보ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 정보수정ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ㄴ9ㅇToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 결제내역ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 상품정보ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 상품리스트ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 대표여행지ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 모든여행지ToolStripMenuItem1;
    }
}