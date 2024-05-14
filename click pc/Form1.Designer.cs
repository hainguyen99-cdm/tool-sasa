namespace click_pc
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnStart = new Button();
            BtnAutoSpin = new Button();
            btnWaterTree = new Button();
            btnDefen = new Button();
            btnBuyTree5Gem = new Button();
            btnPlanTree5 = new Button();
            dataGridView1 = new DataGridView();
            colCheck = new DataGridViewCheckBoxColumn();
            ColIndex = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            contextMenuStrip1 = new ContextMenuStrip(components);
            refreshToolStripMenuItem = new ToolStripMenuItem();
            selectToolStripMenuItem = new ToolStripMenuItem();
            aLLToolStripMenuItem = new ToolStripMenuItem();
            hightlightToolStripMenuItem = new ToolStripMenuItem();
            uncheckedToolStripMenuItem = new ToolStripMenuItem();
            btnBuy100Water = new Button();
            btnBuy300Water = new Button();
            btnBuy500Water = new Button();
            btnBuy1000Water = new Button();
            btn300WaterTheTree = new Button();
            btn500WaterTheTree = new Button();
            btn1000WaterTheTree = new Button();
            btnGiftToFriend = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            groupBox1 = new GroupBox();
            txtLoop = new TextBox();
            txtTimeWater = new TextBox();
            BtnLoop20Water = new Button();
            groupBox2 = new GroupBox();
            button6 = new Button();
            button7 = new Button();
            btnClaimGift = new Button();
            btnAddFriend = new Button();
            btnC3 = new Button();
            btnStop = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.Location = new Point(644, 32);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(144, 29);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // BtnAutoSpin
            // 
            BtnAutoSpin.Location = new Point(644, 67);
            BtnAutoSpin.Name = "BtnAutoSpin";
            BtnAutoSpin.Size = new Size(144, 29);
            BtnAutoSpin.TabIndex = 1;
            BtnAutoSpin.Text = "Auto Spin";
            BtnAutoSpin.UseVisualStyleBackColor = true;
            BtnAutoSpin.Click += BtnAutoSpin_Click;
            // 
            // btnWaterTree
            // 
            btnWaterTree.Location = new Point(168, 66);
            btnWaterTree.Name = "btnWaterTree";
            btnWaterTree.Size = new Size(144, 29);
            btnWaterTree.TabIndex = 2;
            btnWaterTree.Text = "100 Water The Tree";
            btnWaterTree.UseVisualStyleBackColor = true;
            btnWaterTree.Click += btnWaterTree_Click;
            // 
            // btnDefen
            // 
            btnDefen.Location = new Point(644, 102);
            btnDefen.Name = "btnDefen";
            btnDefen.Size = new Size(144, 29);
            btnDefen.TabIndex = 3;
            btnDefen.Text = "Auto Defen & Gachak";
            btnDefen.UseVisualStyleBackColor = true;
            btnDefen.Click += btnDefen_Click;
            // 
            // btnBuyTree5Gem
            // 
            btnBuyTree5Gem.Location = new Point(20, 31);
            btnBuyTree5Gem.Name = "btnBuyTree5Gem";
            btnBuyTree5Gem.Size = new Size(144, 29);
            btnBuyTree5Gem.TabIndex = 4;
            btnBuyTree5Gem.Text = "Buy Tree 5 Gem";
            btnBuyTree5Gem.UseVisualStyleBackColor = true;
            btnBuyTree5Gem.Click += btnBuyTree5Gem_Click;
            // 
            // btnPlanTree5
            // 
            btnPlanTree5.Location = new Point(187, 31);
            btnPlanTree5.Name = "btnPlanTree5";
            btnPlanTree5.Size = new Size(144, 29);
            btnPlanTree5.TabIndex = 5;
            btnPlanTree5.Text = "Plant tree 5 Gem";
            btnPlanTree5.UseVisualStyleBackColor = true;
            btnPlanTree5.Click += btnPlanTree5_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colCheck, ColIndex, colStatus });
            dataGridView1.ContextMenuStrip = contextMenuStrip1;
            dataGridView1.Location = new Point(12, 13);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(626, 425);
            dataGridView1.TabIndex = 6;
            // 
            // colCheck
            // 
            colCheck.HeaderText = "Pick";
            colCheck.MinimumWidth = 6;
            colCheck.Name = "colCheck";
            colCheck.Width = 125;
            // 
            // ColIndex
            // 
            ColIndex.HeaderText = "Index";
            ColIndex.MinimumWidth = 6;
            ColIndex.Name = "ColIndex";
            ColIndex.Width = 125;
            // 
            // colStatus
            // 
            colStatus.HeaderText = "Status";
            colStatus.MinimumWidth = 6;
            colStatus.Name = "colStatus";
            colStatus.Width = 500;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { refreshToolStripMenuItem, selectToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(128, 52);
            contextMenuStrip1.Opening += contextMenuStrip1_Opening;
            // 
            // refreshToolStripMenuItem
            // 
            refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            refreshToolStripMenuItem.Size = new Size(127, 24);
            refreshToolStripMenuItem.Text = "Refresh";
            refreshToolStripMenuItem.Click += refreshToolStripMenuItem_Click;
            // 
            // selectToolStripMenuItem
            // 
            selectToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aLLToolStripMenuItem, hightlightToolStripMenuItem, uncheckedToolStripMenuItem });
            selectToolStripMenuItem.Name = "selectToolStripMenuItem";
            selectToolStripMenuItem.Size = new Size(127, 24);
            selectToolStripMenuItem.Text = "Select";
            // 
            // aLLToolStripMenuItem
            // 
            aLLToolStripMenuItem.Name = "aLLToolStripMenuItem";
            aLLToolStripMenuItem.Size = new Size(164, 26);
            aLLToolStripMenuItem.Text = "ALL";
            aLLToolStripMenuItem.Click += aLLToolStripMenuItem_Click;
            // 
            // hightlightToolStripMenuItem
            // 
            hightlightToolStripMenuItem.Name = "hightlightToolStripMenuItem";
            hightlightToolStripMenuItem.Size = new Size(164, 26);
            hightlightToolStripMenuItem.Text = "Hightlight";
            hightlightToolStripMenuItem.Click += hightlightToolStripMenuItem_Click;
            // 
            // uncheckedToolStripMenuItem
            // 
            uncheckedToolStripMenuItem.Name = "uncheckedToolStripMenuItem";
            uncheckedToolStripMenuItem.Size = new Size(164, 26);
            uncheckedToolStripMenuItem.Text = "Unchecked";
            uncheckedToolStripMenuItem.Click += uncheckedToolStripMenuItem_Click;
            // 
            // btnBuy100Water
            // 
            btnBuy100Water.Location = new Point(18, 66);
            btnBuy100Water.Name = "btnBuy100Water";
            btnBuy100Water.Size = new Size(144, 29);
            btnBuy100Water.TabIndex = 8;
            btnBuy100Water.Text = "Buy 100 water";
            btnBuy100Water.UseVisualStyleBackColor = true;
            btnBuy100Water.Click += btnBuy100Water_Click;
            // 
            // btnBuy300Water
            // 
            btnBuy300Water.Location = new Point(18, 101);
            btnBuy300Water.Name = "btnBuy300Water";
            btnBuy300Water.Size = new Size(144, 29);
            btnBuy300Water.TabIndex = 9;
            btnBuy300Water.Text = "Buy 300 water";
            btnBuy300Water.UseVisualStyleBackColor = true;
            btnBuy300Water.Click += btnBuy300Water_Click;
            // 
            // btnBuy500Water
            // 
            btnBuy500Water.Location = new Point(18, 136);
            btnBuy500Water.Name = "btnBuy500Water";
            btnBuy500Water.Size = new Size(144, 29);
            btnBuy500Water.TabIndex = 10;
            btnBuy500Water.Text = "Buy 500 water";
            btnBuy500Water.UseVisualStyleBackColor = true;
            btnBuy500Water.Click += btnBuy500Water_Click;
            // 
            // btnBuy1000Water
            // 
            btnBuy1000Water.Location = new Point(18, 171);
            btnBuy1000Water.Name = "btnBuy1000Water";
            btnBuy1000Water.Size = new Size(144, 29);
            btnBuy1000Water.TabIndex = 11;
            btnBuy1000Water.Text = "Buy 1000 water";
            btnBuy1000Water.UseVisualStyleBackColor = true;
            btnBuy1000Water.Click += btnBuy1000Water_Click;
            // 
            // btn300WaterTheTree
            // 
            btn300WaterTheTree.Location = new Point(168, 101);
            btn300WaterTheTree.Name = "btn300WaterTheTree";
            btn300WaterTheTree.Size = new Size(144, 29);
            btn300WaterTheTree.TabIndex = 12;
            btn300WaterTheTree.Text = "300 Water The Tree";
            btn300WaterTheTree.UseVisualStyleBackColor = true;
            btn300WaterTheTree.Click += btn300WaterTheTree_Click;
            // 
            // btn500WaterTheTree
            // 
            btn500WaterTheTree.Location = new Point(168, 136);
            btn500WaterTheTree.Name = "btn500WaterTheTree";
            btn500WaterTheTree.Size = new Size(144, 29);
            btn500WaterTheTree.TabIndex = 13;
            btn500WaterTheTree.Text = "500 Water The Tree";
            btn500WaterTheTree.UseVisualStyleBackColor = true;
            btn500WaterTheTree.Click += btn500WaterTheTree_Click;
            // 
            // btn1000WaterTheTree
            // 
            btn1000WaterTheTree.Location = new Point(168, 171);
            btn1000WaterTheTree.Name = "btn1000WaterTheTree";
            btn1000WaterTheTree.Size = new Size(144, 29);
            btn1000WaterTheTree.TabIndex = 14;
            btn1000WaterTheTree.Text = "1000 Water The Tree";
            btn1000WaterTheTree.UseVisualStyleBackColor = true;
            btn1000WaterTheTree.Click += btn1000WaterTheTree_Click;
            // 
            // btnGiftToFriend
            // 
            btnGiftToFriend.Location = new Point(812, 102);
            btnGiftToFriend.Name = "btnGiftToFriend";
            btnGiftToFriend.Size = new Size(131, 29);
            btnGiftToFriend.TabIndex = 15;
            btnGiftToFriend.Text = "Gift to Friend";
            btnGiftToFriend.UseVisualStyleBackColor = true;
            btnGiftToFriend.Click += btnGiftToFriend_Click;
            // 
            // button2
            // 
            button2.Location = new Point(187, 66);
            button2.Name = "button2";
            button2.Size = new Size(144, 29);
            button2.TabIndex = 17;
            button2.Text = "Plant tree 300 Gem";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(20, 66);
            button3.Name = "button3";
            button3.Size = new Size(144, 29);
            button3.TabIndex = 16;
            button3.Text = "Buy Tree 300 Gem";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(187, 101);
            button4.Name = "button4";
            button4.Size = new Size(144, 29);
            button4.TabIndex = 19;
            button4.Text = "Plant tree 500 Gem";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(20, 101);
            button5.Name = "button5";
            button5.Size = new Size(144, 29);
            button5.TabIndex = 18;
            button5.Text = "Buy Tree 500 Gem";
            button5.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtLoop);
            groupBox1.Controls.Add(txtTimeWater);
            groupBox1.Controls.Add(BtnLoop20Water);
            groupBox1.Controls.Add(btnBuy100Water);
            groupBox1.Controls.Add(btnWaterTree);
            groupBox1.Controls.Add(btnBuy300Water);
            groupBox1.Controls.Add(btnBuy500Water);
            groupBox1.Controls.Add(btnBuy1000Water);
            groupBox1.Controls.Add(btn300WaterTheTree);
            groupBox1.Controls.Add(btn500WaterTheTree);
            groupBox1.Controls.Add(btn1000WaterTheTree);
            groupBox1.Location = new Point(644, 225);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(328, 213);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "Water";
            // 
            // txtLoop
            // 
            txtLoop.Location = new Point(252, 31);
            txtLoop.Name = "txtLoop";
            txtLoop.Size = new Size(60, 27);
            txtLoop.TabIndex = 17;
            // 
            // txtTimeWater
            // 
            txtTimeWater.Location = new Point(174, 31);
            txtTimeWater.Name = "txtTimeWater";
            txtTimeWater.Size = new Size(61, 27);
            txtTimeWater.TabIndex = 16;
            // 
            // BtnLoop20Water
            // 
            BtnLoop20Water.Location = new Point(18, 31);
            BtnLoop20Water.Name = "BtnLoop20Water";
            BtnLoop20Water.Size = new Size(144, 29);
            BtnLoop20Water.TabIndex = 15;
            BtnLoop20Water.Text = "Loop 20 Watrer";
            BtnLoop20Water.UseVisualStyleBackColor = true;
            BtnLoop20Water.Click += BtnLoop20Water_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button6);
            groupBox2.Controls.Add(btnBuyTree5Gem);
            groupBox2.Controls.Add(button5);
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(button7);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(btnPlanTree5);
            groupBox2.Location = new Point(978, 225);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(332, 213);
            groupBox2.TabIndex = 21;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tree";
            // 
            // button6
            // 
            button6.Location = new Point(187, 136);
            button6.Name = "button6";
            button6.Size = new Size(144, 29);
            button6.TabIndex = 23;
            button6.Text = "Plant tree 1000 Gem";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(20, 136);
            button7.Name = "button7";
            button7.Size = new Size(144, 29);
            button7.TabIndex = 22;
            button7.Text = "Buy Tree 1000 Gem";
            button7.UseVisualStyleBackColor = true;
            // 
            // btnClaimGift
            // 
            btnClaimGift.Location = new Point(812, 137);
            btnClaimGift.Name = "btnClaimGift";
            btnClaimGift.Size = new Size(131, 29);
            btnClaimGift.TabIndex = 22;
            btnClaimGift.Text = "Claim Gift";
            btnClaimGift.UseVisualStyleBackColor = true;
            btnClaimGift.Click += btnClaimGift_Click;
            // 
            // btnAddFriend
            // 
            btnAddFriend.Location = new Point(812, 67);
            btnAddFriend.Name = "btnAddFriend";
            btnAddFriend.Size = new Size(131, 29);
            btnAddFriend.TabIndex = 23;
            btnAddFriend.Text = "Add Friend";
            btnAddFriend.UseVisualStyleBackColor = true;
            // 
            // btnC3
            // 
            btnC3.Location = new Point(644, 137);
            btnC3.Name = "btnC3";
            btnC3.Size = new Size(144, 29);
            btnC3.TabIndex = 24;
            btnC3.Text = "C3";
            btnC3.UseVisualStyleBackColor = true;
            btnC3.Click += btnC3_Click;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(812, 32);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(131, 29);
            btnStop.TabIndex = 25;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1322, 450);
            Controls.Add(btnStop);
            Controls.Add(btnC3);
            Controls.Add(btnAddFriend);
            Controls.Add(btnClaimGift);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnGiftToFriend);
            Controls.Add(dataGridView1);
            Controls.Add(btnDefen);
            Controls.Add(BtnAutoSpin);
            Controls.Add(btnStart);
            MaximizeBox = false;
            Name = "Form1";
            Text = "`";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnStart;
        private Button BtnAutoSpin;
        private Button btnWaterTree;
        private Button btnDefen;
        private Button btnBuyTree5Gem;
        private Button btnPlanTree5;
        private DataGridView dataGridView1;
        private DataGridViewCheckBoxColumn colCheck;
        private DataGridViewTextBoxColumn ColIndex;
        private DataGridViewTextBoxColumn colStatus;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem refreshToolStripMenuItem;
        private Button btnBuy100Water;
        private Button btnBuy300Water;
        private Button btnBuy500Water;
        private Button btnBuy1000Water;
        private Button btn300WaterTheTree;
        private Button btn500WaterTheTree;
        private Button btn1000WaterTheTree;
        private Button btnGiftToFriend;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button button6;
        private Button button7;
        private ToolStripMenuItem selectToolStripMenuItem;
        private ToolStripMenuItem aLLToolStripMenuItem;
        private ToolStripMenuItem hightlightToolStripMenuItem;
        private Button btnClaimGift;
        private ToolStripMenuItem uncheckedToolStripMenuItem;
        private TextBox txtTimeWater;
        private Button BtnLoop20Water;
        private Button btnAddFriend;
        private TextBox txtLoop;
        private Button btnC3;
        private Button btnStop;
    }
}