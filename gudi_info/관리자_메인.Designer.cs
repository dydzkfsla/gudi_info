namespace gudi_info
{
    partial class 관리자_메인
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("직원 목록");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("직원 상세 정보");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("직원 추가");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("직원 관리", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("여행 상품 목록");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("여행 정보 상세");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("여행 상품 추가");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("여행상품", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("경유지 목록");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("경유지 상세");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("경유지 추가");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("경유지", new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10,
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("여행상품 관리", new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode12});
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("버스 리스트");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("버스 정보");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("버스 추가");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("버스 관리", new System.Windows.Forms.TreeNode[] {
            treeNode14,
            treeNode15,
            treeNode16});
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("예약 리스트");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("예약 상세");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("예약정보 관리", new System.Windows.Forms.TreeNode[] {
            treeNode18,
            treeNode19});
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("회원 리스트");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("회원 정보");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("회원관리", new System.Windows.Forms.TreeNode[] {
            treeNode21,
            treeNode22});
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("코드 관리");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("부서관리");
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.로그아웃ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.Location = new System.Drawing.Point(0, 28);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Employees_list";
            treeNode1.Text = "직원 목록";
            treeNode2.Name = "Employees_info";
            treeNode2.Text = "직원 상세 정보";
            treeNode3.Name = "Employees_Add";
            treeNode3.Text = "직원 추가";
            treeNode4.Name = "Employees";
            treeNode4.Text = "직원 관리";
            treeNode5.Name = "Travel_list";
            treeNode5.Text = "여행 상품 목록";
            treeNode6.Name = "Travel_info";
            treeNode6.Text = "여행 정보 상세";
            treeNode7.Name = "Travel_Add";
            treeNode7.Text = "여행 상품 추가";
            treeNode8.Name = "Travel_info";
            treeNode8.Text = "여행상품";
            treeNode9.Name = "Stopover_list";
            treeNode9.Text = "경유지 목록";
            treeNode10.Name = "Stopover_info";
            treeNode10.Text = "경유지 상세";
            treeNode11.Name = "Stopover_Add";
            treeNode11.Text = "경유지 추가";
            treeNode12.Name = "Stopover";
            treeNode12.Text = "경유지";
            treeNode13.Name = "Travel";
            treeNode13.Text = "여행상품 관리";
            treeNode14.Name = "Bus_list";
            treeNode14.Text = "버스 리스트";
            treeNode15.Name = "BUS_info";
            treeNode15.Text = "버스 정보";
            treeNode16.Name = "BUS_Add()";
            treeNode16.Text = "버스 추가";
            treeNode17.Name = "BUS";
            treeNode17.Text = "버스 관리";
            treeNode18.Name = "reserv_list";
            treeNode18.Text = "예약 리스트";
            treeNode19.Name = "reserv_info";
            treeNode19.Text = "예약 상세";
            treeNode20.Name = "reservation";
            treeNode20.Text = "예약정보 관리";
            treeNode21.Name = "User_list";
            treeNode21.Text = "회원 리스트";
            treeNode22.Name = "User_info";
            treeNode22.Text = "회원 정보";
            treeNode23.Name = "user";
            treeNode23.Text = "회원관리";
            treeNode24.Name = "code";
            treeNode24.Text = "코드 관리";
            treeNode25.Name = "dept";
            treeNode25.Text = "부서관리";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode13,
            treeNode17,
            treeNode20,
            treeNode23,
            treeNode24,
            treeNode25});
            this.treeView1.Size = new System.Drawing.Size(254, 725);
            this.treeView1.TabIndex = 1;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.로그아웃ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1236, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 로그아웃ToolStripMenuItem
            // 
            this.로그아웃ToolStripMenuItem.Name = "로그아웃ToolStripMenuItem";
            this.로그아웃ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.로그아웃ToolStripMenuItem.Text = "로그아웃";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // 관리자_메인
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1236, 753);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "관리자_메인";
            this.Text = "관리자_메인";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 로그아웃ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}