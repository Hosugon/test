
namespace WindowsFormsApp1
{
    partial class FindFood
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindFood));
            this.PB_Map = new System.Windows.Forms.PictureBox();
            this.LB_Title = new System.Windows.Forms.Label();
            this.LB_Type = new System.Windows.Forms.Label();
            this.RB_Rice = new System.Windows.Forms.RadioButton();
            this.RB_Noodles = new System.Windows.Forms.RadioButton();
            this.RB_Cafe = new System.Windows.Forms.RadioButton();
            this.RB_Rand = new System.Windows.Forms.RadioButton();
            this.BT_Submit = new System.Windows.Forms.Button();
            this.LB_Goto_Title = new System.Windows.Forms.Label();
            this.LB_GOTO = new System.Windows.Forms.Label();
            this.LB_Chamicha = new System.Windows.Forms.Label();
            this.LB_S711 = new System.Windows.Forms.Label();
            this.LB_MAM = new System.Windows.Forms.Label();
            this.LB_Yehwa = new System.Windows.Forms.Label();
            this.LB_Zawa = new System.Windows.Forms.Label();
            this.LB_Cactus = new System.Windows.Forms.Label();
            this.LB_Chanwa = new System.Windows.Forms.Label();
            this.LB_MWD = new System.Windows.Forms.Label();
            this.LB_JJW = new System.Windows.Forms.Label();
            this.LB_EUAN = new System.Windows.Forms.Label();
            this.LB_Leaf = new System.Windows.Forms.Label();
            this.LB_Wanzj = new System.Windows.Forms.Label();
            this.LB_Three = new System.Windows.Forms.Label();
            this.LB_DAFN = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Map)).BeginInit();
            this.SuspendLayout();
            // 
            // PB_Map
            // 
            this.PB_Map.Image = ((System.Drawing.Image)(resources.GetObject("PB_Map.Image")));
            this.PB_Map.Location = new System.Drawing.Point(472, 5);
            this.PB_Map.Name = "PB_Map";
            this.PB_Map.Size = new System.Drawing.Size(1000, 950);
            this.PB_Map.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PB_Map.TabIndex = 0;
            this.PB_Map.TabStop = false;
            // 
            // LB_Title
            // 
            this.LB_Title.AutoSize = true;
            this.LB_Title.Font = new System.Drawing.Font("微軟正黑體", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LB_Title.Location = new System.Drawing.Point(89, 30);
            this.LB_Title.Name = "LB_Title";
            this.LB_Title.Size = new System.Drawing.Size(291, 81);
            this.LB_Title.TabIndex = 1;
            this.LB_Title.Text = "要吃什麼";
            // 
            // LB_Type
            // 
            this.LB_Type.AutoSize = true;
            this.LB_Type.Font = new System.Drawing.Font("微軟正黑體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LB_Type.Location = new System.Drawing.Point(12, 111);
            this.LB_Type.Name = "LB_Type";
            this.LB_Type.Size = new System.Drawing.Size(267, 61);
            this.LB_Type.TabIndex = 2;
            this.LB_Type.Text = "想吃的種類";
            // 
            // RB_Rice
            // 
            this.RB_Rice.AutoSize = true;
            this.RB_Rice.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RB_Rice.Location = new System.Drawing.Point(172, 176);
            this.RB_Rice.Name = "RB_Rice";
            this.RB_Rice.Size = new System.Drawing.Size(67, 44);
            this.RB_Rice.TabIndex = 3;
            this.RB_Rice.Text = "飯";
            this.RB_Rice.UseVisualStyleBackColor = true;
            // 
            // RB_Noodles
            // 
            this.RB_Noodles.AutoSize = true;
            this.RB_Noodles.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RB_Noodles.Location = new System.Drawing.Point(245, 176);
            this.RB_Noodles.Name = "RB_Noodles";
            this.RB_Noodles.Size = new System.Drawing.Size(67, 44);
            this.RB_Noodles.TabIndex = 4;
            this.RB_Noodles.Text = "麵";
            this.RB_Noodles.UseVisualStyleBackColor = true;
            // 
            // RB_Cafe
            // 
            this.RB_Cafe.AutoSize = true;
            this.RB_Cafe.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RB_Cafe.Location = new System.Drawing.Point(318, 176);
            this.RB_Cafe.Name = "RB_Cafe";
            this.RB_Cafe.Size = new System.Drawing.Size(99, 44);
            this.RB_Cafe.TabIndex = 5;
            this.RB_Cafe.Text = "簡餐";
            this.RB_Cafe.UseVisualStyleBackColor = true;
            // 
            // RB_Rand
            // 
            this.RB_Rand.AutoSize = true;
            this.RB_Rand.Checked = true;
            this.RB_Rand.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RB_Rand.Location = new System.Drawing.Point(23, 176);
            this.RB_Rand.Name = "RB_Rand";
            this.RB_Rand.Size = new System.Drawing.Size(131, 44);
            this.RB_Rand.TabIndex = 6;
            this.RB_Rand.TabStop = true;
            this.RB_Rand.Text = "都可以";
            this.RB_Rand.UseVisualStyleBackColor = true;
            // 
            // BT_Submit
            // 
            this.BT_Submit.Font = new System.Drawing.Font("微軟正黑體", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BT_Submit.Location = new System.Drawing.Point(12, 876);
            this.BT_Submit.Name = "BT_Submit";
            this.BT_Submit.Size = new System.Drawing.Size(184, 73);
            this.BT_Submit.TabIndex = 7;
            this.BT_Submit.Text = "開始";
            this.BT_Submit.UseVisualStyleBackColor = true;
            this.BT_Submit.Click += new System.EventHandler(this.BT_Submit_Click);
            // 
            // LB_Goto_Title
            // 
            this.LB_Goto_Title.AutoSize = true;
            this.LB_Goto_Title.Font = new System.Drawing.Font("微軟正黑體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LB_Goto_Title.Location = new System.Drawing.Point(12, 604);
            this.LB_Goto_Title.Name = "LB_Goto_Title";
            this.LB_Goto_Title.Size = new System.Drawing.Size(123, 61);
            this.LB_Goto_Title.TabIndex = 8;
            this.LB_Goto_Title.Text = "去吃";
            // 
            // LB_GOTO
            // 
            this.LB_GOTO.AutoSize = true;
            this.LB_GOTO.Font = new System.Drawing.Font("微軟正黑體", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LB_GOTO.Location = new System.Drawing.Point(168, 588);
            this.LB_GOTO.Name = "LB_GOTO";
            this.LB_GOTO.Size = new System.Drawing.Size(0, 81);
            this.LB_GOTO.TabIndex = 9;
            // 
            // LB_Chamicha
            // 
            this.LB_Chamicha.AutoSize = true;
            this.LB_Chamicha.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LB_Chamicha.Location = new System.Drawing.Point(1258, 508);
            this.LB_Chamicha.Name = "LB_Chamicha";
            this.LB_Chamicha.Size = new System.Drawing.Size(0, 31);
            this.LB_Chamicha.TabIndex = 11;
            // 
            // LB_S711
            // 
            this.LB_S711.AutoSize = true;
            this.LB_S711.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LB_S711.Location = new System.Drawing.Point(1247, 478);
            this.LB_S711.Name = "LB_S711";
            this.LB_S711.Size = new System.Drawing.Size(0, 31);
            this.LB_S711.TabIndex = 12;
            // 
            // LB_MAM
            // 
            this.LB_MAM.AutoSize = true;
            this.LB_MAM.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LB_MAM.Location = new System.Drawing.Point(1131, 440);
            this.LB_MAM.Name = "LB_MAM";
            this.LB_MAM.Size = new System.Drawing.Size(0, 31);
            this.LB_MAM.TabIndex = 13;
            // 
            // LB_Yehwa
            // 
            this.LB_Yehwa.AutoSize = true;
            this.LB_Yehwa.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LB_Yehwa.Location = new System.Drawing.Point(1109, 446);
            this.LB_Yehwa.Name = "LB_Yehwa";
            this.LB_Yehwa.Size = new System.Drawing.Size(0, 31);
            this.LB_Yehwa.TabIndex = 14;
            // 
            // LB_Zawa
            // 
            this.LB_Zawa.AutoSize = true;
            this.LB_Zawa.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LB_Zawa.Location = new System.Drawing.Point(1094, 446);
            this.LB_Zawa.Name = "LB_Zawa";
            this.LB_Zawa.Size = new System.Drawing.Size(0, 31);
            this.LB_Zawa.TabIndex = 15;
            // 
            // LB_Cactus
            // 
            this.LB_Cactus.AutoSize = true;
            this.LB_Cactus.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LB_Cactus.Location = new System.Drawing.Point(1103, 446);
            this.LB_Cactus.Name = "LB_Cactus";
            this.LB_Cactus.Size = new System.Drawing.Size(0, 31);
            this.LB_Cactus.TabIndex = 16;
            // 
            // LB_Chanwa
            // 
            this.LB_Chanwa.AutoSize = true;
            this.LB_Chanwa.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LB_Chanwa.Location = new System.Drawing.Point(1087, 446);
            this.LB_Chanwa.Name = "LB_Chanwa";
            this.LB_Chanwa.Size = new System.Drawing.Size(0, 31);
            this.LB_Chanwa.TabIndex = 17;
            // 
            // LB_MWD
            // 
            this.LB_MWD.AutoSize = true;
            this.LB_MWD.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LB_MWD.Location = new System.Drawing.Point(929, 456);
            this.LB_MWD.Name = "LB_MWD";
            this.LB_MWD.Size = new System.Drawing.Size(0, 31);
            this.LB_MWD.TabIndex = 19;
            // 
            // LB_JJW
            // 
            this.LB_JJW.AutoSize = true;
            this.LB_JJW.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LB_JJW.Location = new System.Drawing.Point(901, 487);
            this.LB_JJW.Name = "LB_JJW";
            this.LB_JJW.Size = new System.Drawing.Size(0, 31);
            this.LB_JJW.TabIndex = 20;
            // 
            // LB_EUAN
            // 
            this.LB_EUAN.AutoSize = true;
            this.LB_EUAN.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LB_EUAN.Location = new System.Drawing.Point(861, 478);
            this.LB_EUAN.Name = "LB_EUAN";
            this.LB_EUAN.Size = new System.Drawing.Size(0, 31);
            this.LB_EUAN.TabIndex = 21;
            // 
            // LB_Leaf
            // 
            this.LB_Leaf.AutoSize = true;
            this.LB_Leaf.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LB_Leaf.Location = new System.Drawing.Point(846, 477);
            this.LB_Leaf.Name = "LB_Leaf";
            this.LB_Leaf.Size = new System.Drawing.Size(0, 31);
            this.LB_Leaf.TabIndex = 22;
            // 
            // LB_Wanzj
            // 
            this.LB_Wanzj.AutoSize = true;
            this.LB_Wanzj.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LB_Wanzj.Location = new System.Drawing.Point(834, 477);
            this.LB_Wanzj.Name = "LB_Wanzj";
            this.LB_Wanzj.Size = new System.Drawing.Size(0, 31);
            this.LB_Wanzj.TabIndex = 23;
            // 
            // LB_Three
            // 
            this.LB_Three.AutoSize = true;
            this.LB_Three.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LB_Three.Location = new System.Drawing.Point(815, 446);
            this.LB_Three.Name = "LB_Three";
            this.LB_Three.Size = new System.Drawing.Size(0, 31);
            this.LB_Three.TabIndex = 24;
            // 
            // LB_DAFN
            // 
            this.LB_DAFN.AutoSize = true;
            this.LB_DAFN.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LB_DAFN.Location = new System.Drawing.Point(696, 440);
            this.LB_DAFN.Name = "LB_DAFN";
            this.LB_DAFN.Size = new System.Drawing.Size(0, 31);
            this.LB_DAFN.TabIndex = 26;
            // 
            // FindFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1484, 961);
            this.Controls.Add(this.LB_DAFN);
            this.Controls.Add(this.LB_Three);
            this.Controls.Add(this.LB_Wanzj);
            this.Controls.Add(this.LB_Leaf);
            this.Controls.Add(this.LB_EUAN);
            this.Controls.Add(this.LB_JJW);
            this.Controls.Add(this.LB_MWD);
            this.Controls.Add(this.LB_Chanwa);
            this.Controls.Add(this.LB_Cactus);
            this.Controls.Add(this.LB_Zawa);
            this.Controls.Add(this.LB_Yehwa);
            this.Controls.Add(this.LB_MAM);
            this.Controls.Add(this.LB_S711);
            this.Controls.Add(this.LB_Chamicha);
            this.Controls.Add(this.LB_GOTO);
            this.Controls.Add(this.LB_Goto_Title);
            this.Controls.Add(this.BT_Submit);
            this.Controls.Add(this.RB_Rand);
            this.Controls.Add(this.RB_Cafe);
            this.Controls.Add(this.RB_Noodles);
            this.Controls.Add(this.RB_Rice);
            this.Controls.Add(this.LB_Type);
            this.Controls.Add(this.LB_Title);
            this.Controls.Add(this.PB_Map);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FindFood";
            this.Text = "不知道要吃什麼_alpha";
            ((System.ComponentModel.ISupportInitialize)(this.PB_Map)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PB_Map;
        private System.Windows.Forms.Label LB_Title;
        private System.Windows.Forms.Label LB_Type;
        private System.Windows.Forms.RadioButton RB_Rice;
        private System.Windows.Forms.RadioButton RB_Noodles;
        private System.Windows.Forms.RadioButton RB_Cafe;
        private System.Windows.Forms.RadioButton RB_Rand;
        private System.Windows.Forms.Button BT_Submit;
        private System.Windows.Forms.Label LB_Goto_Title;
        private System.Windows.Forms.Label LB_GOTO;
        private System.Windows.Forms.Label LB_Chamicha;
        private System.Windows.Forms.Label LB_S711;
        private System.Windows.Forms.Label LB_MAM;
        private System.Windows.Forms.Label LB_Yehwa;
        private System.Windows.Forms.Label LB_Zawa;
        private System.Windows.Forms.Label LB_Cactus;
        private System.Windows.Forms.Label LB_Chanwa;
        private System.Windows.Forms.Label LB_MWD;
        private System.Windows.Forms.Label LB_JJW;
        private System.Windows.Forms.Label LB_EUAN;
        private System.Windows.Forms.Label LB_Leaf;
        private System.Windows.Forms.Label LB_Wanzj;
        private System.Windows.Forms.Label LB_Three;
        private System.Windows.Forms.Label LB_DAFN;
    }
}

