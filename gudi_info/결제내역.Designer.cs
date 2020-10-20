namespace gudi_info
{
    partial class 결제내역
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.내정보ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.정보수정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ㄴ9ㅇToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.결제내역ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.상품정보ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.상품리스트ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.res_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trv_info_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.res_prce = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trv_info_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.대표여행지ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.모든여행지ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(632, 27);
            this.menuStrip1.TabIndex = 4;
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
            this.상품리스트ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.상품리스트ToolStripMenuItem.Text = "상품 리스트";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(192, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 47);
            this.label1.TabIndex = 5;
            this.label1.Text = "결제 내역";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.res_date,
            this.trv_info_name,
            this.res_prce,
            this.trv_info_price});
            this.dataGridView1.Location = new System.Drawing.Point(5, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(626, 445);
            this.dataGridView1.TabIndex = 6;
            // 
            // res_date
            // 
            this.res_date.HeaderText = "주문일자";
            this.res_date.Name = "res_date";
            this.res_date.Width = 150;
            // 
            // trv_info_name
            // 
            this.trv_info_name.HeaderText = "상품명";
            this.trv_info_name.Name = "trv_info_name";
            this.trv_info_name.Width = 150;
            // 
            // res_prce
            // 
            this.res_prce.HeaderText = "예매 가격";
            this.res_prce.Name = "res_prce";
            this.res_prce.Width = 150;
            // 
            // trv_info_price
            // 
            this.trv_info_price.HeaderText = "가격";
            this.trv_info_price.Name = "trv_info_price";
            // 
            // 대표여행지ToolStripMenuItem1
            // 
            this.대표여행지ToolStripMenuItem1.Name = "대표여행지ToolStripMenuItem1";
            this.대표여행지ToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.대표여행지ToolStripMenuItem1.Text = "대표 여행지";
            // 
            // 모든여행지ToolStripMenuItem1
            // 
            this.모든여행지ToolStripMenuItem1.Name = "모든여행지ToolStripMenuItem1";
            this.모든여행지ToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.모든여행지ToolStripMenuItem1.Text = "모든 여행지";
            // 
            // 결제내역
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(632, 539);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.Name = "결제내역";
            this.Text = "Form7";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 내정보ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 정보수정ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ㄴ9ㅇToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 결제내역ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 상품정보ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 상품리스트ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn res_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn trv_info_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn res_prce;
        private System.Windows.Forms.DataGridViewTextBoxColumn trv_info_price;
        private System.Windows.Forms.ToolStripMenuItem 대표여행지ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 모든여행지ToolStripMenuItem1;
    }
}