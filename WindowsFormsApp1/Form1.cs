using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FindFood : Form
    {
        #region 全域變數
        string[] restaurant = new string[] {
            "億圓","今井屋","茶米茶", "學校711","大方","三多","葉子","王記","美而美","宜華","仙人掌","米澤" 
        };
        #endregion

        public FindFood()
        {
            InitializeComponent();
        }

        #region 控制按鈕
        private void BT_Submit_Click(object sender, EventArgs e)
        {
            reset();
            if (RB_Rand.Checked)
            {
                int x = rand(12);
                LB_GOTO.Text = restaurant[x];
                mark(x);
            }
            else if (RB_Rice.Checked)
            {
                int x = rand(7);
                LB_GOTO.Text = restaurant[x];
                mark(x);
            }
            else if (RB_Noodles.Checked)
            {
                int x = rand(10)+2;
                LB_GOTO.Text = restaurant[x];
                mark(x);
                
            }
            else 
            {
                int x = rand(3)+9;
                LB_GOTO.Text = restaurant[x];
                mark(x);
            }

            

        }


        #endregion

        #region 副程式
        int rand(int x) 
        {
            Random RD = new Random(Guid.NewGuid().GetHashCode());
            return RD.Next(x);

        }
        void mark(int x) 
        {
            switch (x) 
            {
                case 0:
                    LB_EUAN.Parent = PB_Map;
                    LB_EUAN.Text = "O";
                    LB_EUAN.BackColor = Color.Transparent;
                    LB_EUAN.Location = new Point(380, 478);
                    break;
                case 1:
                    LB_JJW.Parent = PB_Map;
                    LB_JJW.Text = "O";
                    LB_JJW.BackColor = Color.Transparent;
                    LB_JJW.Location = new Point(430, 478);
                    break;
                case 2:
                    LB_Chamicha.Parent = PB_Map;
                    LB_Chamicha.Text = "O";
                    LB_Chamicha.BackColor = Color.Transparent;
                    LB_Chamicha.Location = new Point(780, 500);
                    break;
                case 3:
                    LB_S711.Parent = PB_Map;
                    LB_S711.Text = "O";
                    LB_S711.BackColor = Color.Transparent;
                    LB_S711.Location = new Point(780, 470);
                    break;
                case 4:
                    LB_DAFN.Parent = PB_Map;
                    LB_DAFN.Text = "O";
                    LB_DAFN.BackColor = Color.Transparent;
                    LB_DAFN.Location = new Point(250, 440);
                    break;
                case 5:
                    LB_Three.Parent = PB_Map;
                    LB_Three.Text = "O";
                    LB_Three.BackColor = Color.Transparent;
                    LB_Three.Location = new Point(355, 446);
                    break;
                case 6:
                    LB_Leaf.Parent = PB_Map;
                    LB_Leaf.Text = "O";
                    LB_Leaf.BackColor = Color.Transparent;
                    LB_Leaf.Location = new Point(375, 478);
                    break;
                case 7:
                    LB_Wanzj.Parent = PB_Map;
                    LB_Wanzj.Text = "O";
                    LB_Wanzj.BackColor = Color.Transparent;
                    LB_Wanzj.Location = new Point(370, 478);
                    break;
                case 8:
                    LB_MAM.Parent = PB_Map;
                    LB_MAM.Text = "O";
                    LB_MAM.BackColor = Color.Transparent;
                    LB_MAM.Location = new Point(660, 440);
                    break;
                case 9:
                    LB_Yehwa.Parent = PB_Map;
                    LB_Yehwa.Text = "O";
                    LB_Yehwa.BackColor = Color.Transparent;
                    LB_Yehwa.Location = new Point(635, 440);
                    break;
                case 10:
                    LB_Cactus.Parent = PB_Map;
                    LB_Cactus.Text = "O";
                    LB_Cactus.BackColor = Color.Transparent;
                    LB_Cactus.Location = new Point(630, 440);
                    break;
                case 11:
                    LB_Zawa.Parent = PB_Map;
                    LB_Zawa.Text = "O";
                    LB_Zawa.BackColor = Color.Transparent;
                    LB_Zawa.Location = new Point(625, 440);
                    break;                    
            }


        }
        void reset() 
        {
            LB_Cactus.Text = "";
            LB_Chamicha.Text = "";
            LB_DAFN.Text = "";
            LB_EUAN.Text = "";
            LB_JJW.Text = "";
            LB_Leaf.Text = "";
            LB_MAM.Text = "";
            LB_MWD.Text = "";
            LB_S711.Text = "";
            LB_Three.Text = "";
            LB_Wanzj.Text = "";
            LB_Yehwa.Text = "";
            LB_Zawa.Text = "";
        }
        #endregion
    }
}
