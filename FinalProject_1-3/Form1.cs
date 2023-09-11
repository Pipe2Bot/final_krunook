namespace FinalProject_1_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lbsub1.Visible = false;
            lbsub2.Visible = false;
            lbsub3.Visible = false;
        }

        private void bttgo_Click(object sender, EventArgs e)
        {
            if (ddlmain.Text != "")
            {
                
                if (ddlmain.SelectedIndex == 0) // 4 ผืนผ้า
                {
                    double leng, wide, area;
                    /*
                    wide = Convert.ToDouble(lbsub1.Text);
                    leng = Convert.ToDouble(lbsub2.Text);
                    area = Convert.ToDouble(lbsub3.Text);
                    area = wide * leng;
                    wide = area / leng;
                    leng = area / wide;
                    */
                    if (tbsub1.Text == "")
                    {
                        leng = Convert.ToDouble(tbsub2.Text);
                        area = Convert.ToDouble(tbsub3.Text);
                        wide = area / leng;
                        tbsub1.Text = wide.ToString();
                    }
                    else if (tbsub2.Text == "")
                    {
                        wide = Convert.ToDouble(tbsub1.Text);
                        area = Convert.ToDouble(tbsub3.Text);
                        leng = area / wide;
                        tbsub2.Text = leng.ToString();
                    }
                    else
                    {
                        wide = Convert.ToDouble(tbsub1.Text);
                        leng = Convert.ToDouble(tbsub2.Text);
                        area = wide * leng;
                        tbsub3.Text = area.ToString();
                    }




                }
                else if (ddlmain.SelectedIndex == 1) //circle
                {
                    double rad, area;

                    lbsub1.Visible = true;
                    lbsub2.Visible = true;
                    lbsub3.Visible = false;

                    if (tbsub1.Text == "")
                    {
                        area = Convert.ToDouble(tbsub2.Text);
                        rad = (area / 22 * 7);
                        rad = Math.Sqrt(rad);
                        tbsub1.Text = rad.ToString();

                    }
                    else if (tbsub2.Text == "")
                    {
                        rad = Convert.ToDouble(tbsub1.Text);
                        area = rad * rad * 22 / 7;
                        tbsub2.Text = area.ToString();
                    }
                }
                else if (ddlmain.SelectedIndex == 2)
                {
                    double leng, wide, area;
                    /*
                    wide = Convert.ToDouble(lbsub1.Text);
                    leng = Convert.ToDouble(lbsub2.Text);
                    area = Convert.ToDouble(lbsub3.Text);
                    area = wide * leng;
                    wide = area / leng;
                    leng = area / wide;
                    */
                    if (tbsub1.Text == "")
                    {
                        leng = Convert.ToDouble(tbsub2.Text);
                        area = Convert.ToDouble(tbsub3.Text);
                        wide = area * 2 / leng;
                        tbsub1.Text = wide.ToString();
                    }
                    else if (tbsub2.Text == "")
                    {
                        wide = Convert.ToDouble(tbsub1.Text);
                        area = Convert.ToDouble(tbsub3.Text);
                        leng = area * 2 / wide;
                        tbsub2.Text = leng.ToString();
                    }
                    else
                    {
                        wide = Convert.ToDouble(tbsub1.Text);
                        leng = Convert.ToDouble(tbsub2.Text);
                        area = wide * leng / 2;
                        tbsub3.Text = area.ToString();
                    }
                }
                else if (ddlmain.SelectedIndex == 3)
                {
                    double leng, wide, area;
                    /*
                    wide = Convert.ToDouble(lbsub1.Text);
                    leng = Convert.ToDouble(lbsub2.Text);
                    area = Convert.ToDouble(lbsub3.Text);
                    area = wide * leng;
                    wide = area / leng;
                    leng = area / wide;
                    */
                    if (tbsub1.Text == "")
                    {
                        leng = Convert.ToDouble(tbsub2.Text);
                        area = Convert.ToDouble(tbsub3.Text);
                        wide = area * 2 / leng;
                        tbsub1.Text = wide.ToString();
                    }
                    else if (tbsub2.Text == "")
                    {
                        wide = Convert.ToDouble(tbsub1.Text);
                        area = Convert.ToDouble(tbsub3.Text);
                        leng = area * 2 / wide;
                        tbsub2.Text = leng.ToString();
                    }
                    else
                    {
                        wide = Convert.ToDouble(tbsub1.Text);
                        leng = Convert.ToDouble(tbsub2.Text);
                        area = wide * leng / 2;
                        tbsub3.Text = area.ToString();
                    }
                }
                else if (ddlmain.SelectedIndex == 4) // 4 ผืนผ้า
                {
                    double leng, wide, area;
                    /*
                    wide = Convert.ToDouble(lbsub1.Text);
                    leng = Convert.ToDouble(lbsub2.Text);
                    area = Convert.ToDouble(lbsub3.Text);
                    area = wide * leng;
                    wide = area / leng;
                    leng = area / wide;
                    */
                    if (tbsub1.Text == "")
                    {
                        leng = Convert.ToDouble(tbsub2.Text);
                        area = Convert.ToDouble(tbsub3.Text);
                        wide = area / leng;
                        tbsub1.Text = wide.ToString();
                    }
                    else if (tbsub2.Text == "")
                    {
                        wide = Convert.ToDouble(tbsub1.Text);
                        area = Convert.ToDouble(tbsub3.Text);
                        leng = area / wide;
                        tbsub2.Text = leng.ToString();
                    }
                    else
                    {
                        wide = Convert.ToDouble(tbsub1.Text);
                        leng = Convert.ToDouble(tbsub2.Text);
                        area = wide * leng;
                        tbsub3.Text = area.ToString();
                    }

                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ddlmain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlmain.SelectedIndex == 0) // 4 ผืนผ้า
            {
                lbsub1.Visible = true;
                lbsub2.Visible = true;
                lbsub3.Visible = true;
                tbsub3.Visible = true;
                lbsub1.Text = "กว้าง";
                lbsub2.Text = "ยาว";
                lbsub3.Text = "พื้นที่";

            }
            else if (ddlmain.SelectedIndex == 1) //circle
            {
                lbsub1.Visible = true;
                lbsub2.Visible = true;
                lbsub3.Visible = false;
                tbsub3.Visible = false;
                lbsub1.Text = "รัศมี";
                lbsub2.Text = "พื้นที่";
            }
            else if (ddlmain.SelectedIndex == 2) // 4 ผืนผ้า
            {
                lbsub1.Visible = true;
                lbsub2.Visible = true;
                lbsub3.Visible = true;
                tbsub3.Visible = true;
                lbsub1.Text = "ยาว";
                lbsub2.Text = "สูง";
                lbsub3.Text = "พื้นที่";

            }
            else if (ddlmain.SelectedIndex == 3) // 4 ผืนผ้า
            {
                lbsub1.Visible = true;
                lbsub2.Visible = true;
                lbsub3.Visible = true;
                tbsub3.Visible = true;
                lbsub1.Text = "เส้นทะเเยงมุม 1";
                lbsub2.Text = "เส้นทะเเยงมุม 2";
                lbsub3.Text = "พื้นที่";

            }
            else if (ddlmain.SelectedIndex == 4) // 4 ผืนผ้า
            {
                lbsub1.Visible = true;
                lbsub2.Visible = true;
                lbsub3.Visible = true;
                tbsub3.Visible = true;
                lbsub1.Text = "ฐาน";
                lbsub2.Text = "สูง";
                lbsub3.Text = "พื้นที่";


            }
        }

      

    }
}