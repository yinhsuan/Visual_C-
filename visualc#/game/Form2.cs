using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.Devices;

namespace game
{
    public partial class Form2 : Form
    {
        Label[] labelList = new Label[8];

        Image floor;
        Image brickHImg;
        Image cannon;
        Image moveStairImg;
        Image wall;
        Image toxic_rhino;
        Image coinBoxImg;
        Image mirBoxImg;
        Image bullet1;
        Image bullet2;
        Image exit_door;
        Image ice_ball;
        Image toxic_fish;
        Image red_mush;
        Image blue_mush;
        Image gold_mush;

        bool sound_state = false;
        bool stand_status = false; //true -> run //false -> stand
        bool mario_dir = true; //true -> right //false -> left
        bool toxicmushFlag = true;
        bool toxic_mush_die = false;
        bool toxic_mush_show = true;
        bool toxic_turtle_die = false;
        bool toxic_turtle_show = true;
        bool toxic_fish1_die = false;
        bool toxic_fish2_die = false;
        bool toxic_fish1_show = true;
        bool toxic_fish2_show = true;
        bool mario_die_motion_flag = false;
        bool mario_jump_hit_top_flag = false;
        bool ice_ball_flag = false;
        bool object_shake_flag = false;
        bool coin_show = false;
        bool bullet1_move_flag = false; bool bullet2_move_flag = false;
        bool mario_on_moveStair1 = false; bool mario_on_moveStair2 = false;
        bool red_mush_show = false;
        bool blue_mush_show = false;
        bool gold_mush_show = false;
        bool red_mush_eat = false;
        bool blue_mush_eat = false;
        bool gold_mush_eat = false;

        bool labelUp = false; bool labelDown = false;
        bool labelLeft = false; bool labelRight = false;
        bool labelW = false; bool labelS = false;
        bool labelA = false; bool labelD = false;
        bool labelCtrl = false; bool labelAlt = false;

        float angle = 60;
        float screen_x = 15000; float screen_y = 900;
        float path_distance = 10000;
        float cnt_distance = 0;
        float mid_point = 400;
        float move_stair1_step = 20; float move_stair2_step = -20;
        float move_fish1_step = 20; float move_fish2_step = -20;
        float toxic_rhino_radius = 10;
        float toxix_rhino_angle = (float)Math.PI;

        float floor_x = 0; float floor_y = 680;
        float wall_x = 4900; float wall_y = 235;
        float cannon_x = 2300; float cannon_y = 550;
        float bullet1_x = 2310; float bullet1_y = 560;
        float bullet2_x = 2330; float bullet2_y = 560;
        float exit_door_x = 8400; float exit_door_y = 25;
        float toxic_pond_x = 3628; float toxic_pond_y = 520;
        float coin_x = 0; float coin_y = 0;
        float red_mush_x = -100; float red_mush_y = -100;
        float blue_mush_x = -100; float blue_mush_y = -100;
        float gold_mush_x = -100; float gold_mush_y = -100;
        float toxic_rhino1_x = 5600; float toxic_rhino1_y = 250;
        float toxic_rhino2_x = 6100; float toxic_rhino2_y = 250;
        float toxic_turtle_x = 7900; float toxic_turtle_y = 120;
        float toxic_fish1_x = 3685; float toxic_fish1_y = 350;
        float toxic_fish2_x = 3785; float toxic_fish2_y = 450;

        float mario_jumo_hit_top = 0;
        float mario_base_y = 595+80;
        float mario_end_y = 0;
        float mario_jump_y = 0;
        float mario_before_jump_y = 0;
        float mario_jump_time = 0;
        float mario_jump_initial_velocity = -90;
        float mario_x = 50; float mario_y = 595;
        
        float moveStairImg1_x = 4500; float moveStairImg1_y = 200;
        float moveStairImg2_x = 4700; float moveStairImg2_y = 200;

        float toxic_mush1_x = 400; float toxic_mush1_y = 615;
        float toxic_mush1_step = 0;

        int mario_right_index= 0; int mario_left_index = 0;
        int mario_right_stand_index = 0; int mario_left_stand_index = 0;
        int toxic_pond_index = 0;
        int toxic_turtle_index = 0;
        int coin_index = 0;
        int coin_tmp = 0;
        int toxic_mush_dead_index = 0;
        int toxic_fish1_dead_index = 0;
        int toxic_fish2_dead_index = 0;
        int toxic_turtle_dead_index = 0;
        int toxic_mush_right_index = 0; int toxic_mush_left_index = 0;
        
        int cnt = 0;
        int ice_ball_tmp = 0;
        int red_mush_num = 0;
        int blue_mush_num = 0;
        int gold_mush_num = 0;

        float[] brickHlist_x = new float[32];
        float[] brickHlist_y = new float[32];
        float[] moveStairlist = new float[2];
        float[] toxicMushList = new float[4];
        float[] coinBoxlist_x = new float[7];
        float[] coinBoxlist_y = new float[7];
        float[] mirBoxlist_x = new float[8];
        float[] mirBoxlist_y = new float[8];
        float[] ice_ball_list_x = new float[10];
        float[] ice_ball_list_y = new float[10];

        float ice_ball_Img1_x = -30; float ice_ball_Img2_x = -30; float ice_ball_Img3_x = -30; float ice_ball_Img4_x = -30;
        float ice_ball_Img5_x = -30; float ice_ball_Img6_x = -30; float ice_ball_Img7_x = -30; float ice_ball_Img8_x = -30;
        float ice_ball_Img9_x = -30; float ice_ball_Img10_x = -30;

        float ice_ball_Img1_y = 0; float ice_ball_Img2_y = 0; float ice_ball_Img3_y = 0; float ice_ball_Img4_y = 0;
        float ice_ball_Img5_y = 0; float ice_ball_Img6_y = 0; float ice_ball_Img7_y = 0; float ice_ball_Img8_y = 0;
        float ice_ball_Img9_y = 0; float ice_ball_Img10_y = 0;

        //float mirBoxImg_yL = 480;
        //float mirBoxImg_yM = 300;
        //float mirBoxImg_yH = 130;

        float mirBoxImg1_x = 536; float mirBoxImg2_x = 1292; float mirBoxImg3_x = 1964; float mirBoxImg4_x = 3174;
        float mirBoxImg5_x = 5665;float mirBoxImg6_x = 6165; float mirBoxImg7_x = 6828; float mirBoxImg8_x = 6950;

        float mirBoxImg1_y = 300; float mirBoxImg2_y = 300; float mirBoxImg3_y = 300; float mirBoxImg4_y = 300;
        float mirBoxImg5_y = 380; float mirBoxImg6_y = 380; float mirBoxImg7_y = 480; float mirBoxImg8_y = 130;

        //float coinBoxImg_yL = 480;
        //float coinBoxImg_yM = 300;
        //float coinBoxImg_yH = 130;

        float coinBoxImg1_x = 300; float coinBoxImg2_x = 664; float coinBoxImg3_x = 1420; float coinBoxImg4_x = 1836;
        float coinBoxImg5_x = 2928; float coinBoxImg6_x = 6636; float coinBoxImg7_x = 6822;

        float coinBoxImg1_y = 300; float coinBoxImg2_y = 300; float coinBoxImg3_y = 300; float coinBoxImg4_y = 300;
        float coinBoxImg5_y = 300; float coinBoxImg6_y = 480; float coinBoxImg7_y = 300;

        //float brickHImg_yB = 615;
        //float brickHImg_yL = 480;
        //float brickHImg_yM = 300;
        //float brickHImg_yH = 130;

        float brickHImg1_x = 600; float brickHImg2_x = 11100; float brickHImg3_x = 11164; float brickHImg4_x = 11228;
        float brickHImg5_x = 11292;float brickHImg6_x = 11356; float brickHImg7_x = 1356; float brickHImg8_x = 1900;
        float brickHImg9_x = 12800;float brickHImg10_x =12864; float brickHImg11_x =12928; float brickHImg12_x =13056;
        float brickHImg13_x =13120;float brickHImg14_x =2992; float brickHImg15_x =3056; float brickHImg16_x =3120;
        float brickHImg17_x =3500;float brickHImg18_x =3564; float brickHImg19_x =3564; float brickHImg20_x =3885;
        float brickHImg21_x =3885;float brickHImg22_x =3949; float brickHImg23_x =6700; float brickHImg24_x =6764;
        float brickHImg25_x =6886;float brickHImg26_x =7014; float brickHImg27_x =7078; float brickHImg28_x =8200;
        float brickHImg29_x =8264;float brickHImg30_x =8328; float brickHImg31_x =8392; float brickHImg32_x =8456;

        float brickHImg1_y = 300; float brickHImg2_y = 480; float brickHImg3_y = 480; float brickHImg4_y = 480;
        float brickHImg5_y = 480; float brickHImg6_y = 480; float brickHImg7_y = 300; float brickHImg8_y = 300;
        float brickHImg9_y = 480; float brickHImg10_y =480; float brickHImg11_y =480; float brickHImg12_y =480;
        float brickHImg13_y =480; float brickHImg14_y =300; float brickHImg15_y =300; float brickHImg16_y =300;
        float brickHImg17_y =615; float brickHImg18_y =615; float brickHImg19_y =615-64; float brickHImg20_y =615-64;
        float brickHImg21_y =615; float brickHImg22_y =615; float brickHImg23_y =480; float brickHImg24_y =480;
        float brickHImg25_y =300; float brickHImg26_y =130; float brickHImg27_y =130; float brickHImg28_y =130;
        float brickHImg29_y =130; float brickHImg30_y =130; float brickHImg31_y =130; float brickHImg32_y =130;
        

        Computer myComputer2 = new Computer();

        public Form2()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            myComputer2.Audio.Play("..//..//..//..//Resource//Music//background_form2.wav", AudioPlayMode.Background);
            floor = new Bitmap(Properties.Resources.f2);
            cannon = new Bitmap(Properties.Resources.c2);
            wall = new Bitmap(Properties.Resources.wall);
            toxic_rhino = new Bitmap(Properties.Resources.m1);
            bullet1 = new Bitmap(Properties.Resources.cs1);
            bullet2 = new Bitmap(Properties.Resources.cs2);
            brickHImg = new Bitmap(Properties.Resources.bH);
            moveStairImg = new Bitmap(Properties.Resources.s);
            mirBoxImg = new Bitmap(Properties.Resources.mb);
            coinBoxImg = new Bitmap(Properties.Resources.cb);
            exit_door = new Bitmap(Properties.Resources.door);
            ice_ball = new Bitmap(Properties.Resources.ib);
            toxic_fish = new Bitmap(Properties.Resources.tf);
            red_mush = new Bitmap(Properties.Resources.rm2);
            blue_mush = new Bitmap(Properties.Resources.bm1);
            gold_mush = new Bitmap(Properties.Resources.gm1);

            coinBoxlist_x[0] = coinBoxImg1_x; coinBoxlist_x[1] = coinBoxImg2_x; coinBoxlist_x[2] = coinBoxImg3_x; coinBoxlist_x[3] = coinBoxImg4_x;
            coinBoxlist_x[4] = coinBoxImg5_x; coinBoxlist_x[5] = coinBoxImg6_x; coinBoxlist_x[6] = coinBoxImg7_x;

            coinBoxlist_y[0] = coinBoxImg1_y; coinBoxlist_y[1] = coinBoxImg2_y; coinBoxlist_y[2] = coinBoxImg3_y; coinBoxlist_y[3] = coinBoxImg4_y;
            coinBoxlist_y[4] = coinBoxImg5_y; coinBoxlist_y[5] = coinBoxImg6_y; coinBoxlist_y[6] = coinBoxImg7_y;

            mirBoxlist_x[0] = mirBoxImg1_x; mirBoxlist_x[1] = mirBoxImg2_x; mirBoxlist_x[2] = mirBoxImg3_x; mirBoxlist_x[3] = mirBoxImg4_x;
            mirBoxlist_x[4] = mirBoxImg5_x; mirBoxlist_x[5] = mirBoxImg6_x; mirBoxlist_x[6] = mirBoxImg7_x; mirBoxlist_x[7] = mirBoxImg8_x;

            mirBoxlist_y[0] = mirBoxImg1_y; mirBoxlist_y[1] = mirBoxImg2_y; mirBoxlist_y[2] = mirBoxImg3_y; mirBoxlist_y[3] = mirBoxImg4_y;
            mirBoxlist_y[4] = mirBoxImg5_y; mirBoxlist_y[5] = mirBoxImg6_y; mirBoxlist_y[6] = mirBoxImg7_y; mirBoxlist_y[7] = mirBoxImg8_y;

            ice_ball_list_x[0] = ice_ball_Img1_x; ice_ball_list_x[1] = ice_ball_Img2_x; ice_ball_list_x[2] = ice_ball_Img3_x; ice_ball_list_x[3] = ice_ball_Img4_x;
            ice_ball_list_x[4] = ice_ball_Img5_x; ice_ball_list_x[5] = ice_ball_Img6_x; ice_ball_list_x[6] = ice_ball_Img7_x; ice_ball_list_x[7] = ice_ball_Img8_x;
            ice_ball_list_x[8] = ice_ball_Img9_x; ice_ball_list_x[9] = ice_ball_Img10_x;

            ice_ball_list_y[0] = ice_ball_Img1_y; ice_ball_list_y[1] = ice_ball_Img2_y; ice_ball_list_y[2] = ice_ball_Img3_y; ice_ball_list_y[3] = ice_ball_Img4_y;
            ice_ball_list_y[4] = ice_ball_Img5_y; ice_ball_list_y[5] = ice_ball_Img6_y; ice_ball_list_y[6] = ice_ball_Img7_y; ice_ball_list_y[7] = ice_ball_Img8_y;
            ice_ball_list_y[8] = ice_ball_Img9_y; ice_ball_list_y[9] = ice_ball_Img10_y;


            brickHlist_x[0] = brickHImg1_x; brickHlist_x[1] = brickHImg2_x; brickHlist_x[2] = brickHImg3_x; brickHlist_x[3] = brickHImg4_x;
            brickHlist_x[4] = brickHImg5_x; brickHlist_x[5] = brickHImg6_x; brickHlist_x[6] = brickHImg7_x; brickHlist_x[7] = brickHImg8_x;
            brickHlist_x[8] = brickHImg9_x; brickHlist_x[9] = brickHImg10_x;brickHlist_x[10] =brickHImg11_x;brickHlist_x[11] =brickHImg12_x;
            brickHlist_x[12] =brickHImg13_x;brickHlist_x[13] =brickHImg14_x;brickHlist_x[14] =brickHImg15_x;brickHlist_x[15] =brickHImg16_x;
            brickHlist_x[16] =brickHImg17_x;brickHlist_x[17] =brickHImg18_x;brickHlist_x[18] =brickHImg19_x;brickHlist_x[19] =brickHImg20_x;
            brickHlist_x[20] =brickHImg21_x;brickHlist_x[21] =brickHImg22_x;brickHlist_x[22] =brickHImg23_x;brickHlist_x[23] =brickHImg24_x;
            brickHlist_x[24] =brickHImg25_x;brickHlist_x[25] =brickHImg26_x;brickHlist_x[26] =brickHImg27_x;brickHlist_x[27] =brickHImg28_x;
            brickHlist_x[28] =brickHImg29_x;brickHlist_x[29] =brickHImg30_x;brickHlist_x[30] =brickHImg31_x;brickHlist_x[31] =brickHImg32_x;

            brickHlist_y[0] = brickHImg1_y; brickHlist_y[1] = brickHImg2_y; brickHlist_y[2] = brickHImg3_y; brickHlist_y[3] = brickHImg4_y;
            brickHlist_y[4] = brickHImg5_y; brickHlist_y[5] = brickHImg6_y; brickHlist_y[6] = brickHImg7_y; brickHlist_y[7] = brickHImg8_y;
            brickHlist_y[8] = brickHImg9_y; brickHlist_y[9] = brickHImg10_y;brickHlist_y[10] =brickHImg11_y;brickHlist_y[11] =brickHImg12_y;
            brickHlist_y[12] =brickHImg13_y;brickHlist_y[13] =brickHImg14_y;brickHlist_y[14] =brickHImg15_y;brickHlist_y[15] =brickHImg16_y;
            brickHlist_y[16] =brickHImg17_y;brickHlist_y[17] =brickHImg18_y;brickHlist_y[18] =brickHImg19_y;brickHlist_y[19] =brickHImg20_y;
            brickHlist_y[20] =brickHImg21_y;brickHlist_y[21] =brickHImg22_y;brickHlist_y[22] =brickHImg23_y;brickHlist_y[23] =brickHImg24_y;
            brickHlist_y[24] =brickHImg25_y;brickHlist_y[25] =brickHImg26_y;brickHlist_y[26] =brickHImg27_y;brickHlist_y[27] =brickHImg28_y;
            brickHlist_y[28] =brickHImg29_y;brickHlist_y[29] =brickHImg30_y;brickHlist_y[30] =brickHImg31_y;brickHlist_y[31] =brickHImg32_y;

            moveStairlist[0] = moveStairImg1_x; moveStairlist[1] = moveStairImg2_x;

            toxic_mush1_step = toxic_mush1_x;
            
        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            //draw coin
            if (coin_show == true)
                e.Graphics.DrawImage(coin.Images[coin_index], coin_x, coin_y);
            //draw Bullet
            if (CalShowOnScreen(bullet1_x))
                e.Graphics.DrawImage(bullet1, bullet1_x, bullet1_y, bullet1.Width, bullet1.Height);
            if (CalShowOnScreen(bullet2_x))
                e.Graphics.DrawImage(bullet2, bullet2_x, bullet2_y, bullet2.Width, bullet2.Height);
            //draw Cannon
            if (CalShowOnScreen(cannon_x))
                e.Graphics.DrawImage(cannon, cannon_x, cannon_y, cannon.Width, cannon.Height);
            //draw ToxicPond
            if (CalShowOnScreen(toxic_pond_x))
                e.Graphics.DrawImage(toxic_pond.Images[toxic_pond_index], toxic_pond_x, toxic_pond_y);
            
            //draw moveStair
            for (int i = 0; i < moveStairlist.Length; i++)
            {
                if (CalShowOnScreen(moveStairlist[i]))
                {
                    if (i == 0) e.Graphics.DrawImage(moveStairImg, moveStairlist[i], moveStairImg1_y, moveStairImg.Width, moveStairImg.Height);
                    else if (i == 1) e.Graphics.DrawImage(moveStairImg, moveStairlist[i], moveStairImg2_y, moveStairImg.Width, moveStairImg.Height);
                }
            }
            //draw rhino
            if (CalShowOnScreen(toxic_rhino1_x))
                e.Graphics.DrawImage(toxic_rhino, toxic_rhino1_x, toxic_rhino1_y, toxic_rhino.Width, toxic_rhino.Height);
            if (CalShowOnScreen(toxic_rhino2_x))
                e.Graphics.DrawImage(toxic_rhino, toxic_rhino2_x, toxic_rhino2_y, toxic_rhino.Width, toxic_rhino.Height);
            
            //draw brickH
            for (int i = 0; i < brickHlist_x.Length; i++)
                if (CalShowOnScreen(brickHlist_x[i]))
                    e.Graphics.DrawImage(brickHImg, brickHlist_x[i], brickHlist_y[i], brickHImg.Width, brickHImg.Height);
            //draw ice_ball
            if (ice_ball_flag == true)
            {
                for (int i = 0; i < ice_ball_list_x.Length; i++)
                    if (CalShowOnScreen(ice_ball_list_x[i]))
                        e.Graphics.DrawImage(ice_ball, ice_ball_list_x[i], ice_ball_list_y[i], ice_ball.Width, ice_ball.Height);
            }
            //draw floor
            e.Graphics.DrawImage(floor, floor_x, floor_y, floor.Width, floor.Height);
            //draw Exit_Door
            e.Graphics.DrawImage(exit_door, exit_door_x, exit_door_y, exit_door.Width, exit_door.Height);
            //draw wall
            e.Graphics.DrawImage(wall, wall_x, wall_y, wall.Width, wall.Height);
            //draw CoinBox
            for (int i = 0; i < coinBoxlist_x.Length; i++)
                if (CalShowOnScreen(coinBoxlist_x[i]))
                    e.Graphics.DrawImage(coinBoxImg, coinBoxlist_x[i], coinBoxlist_y[i], coinBoxImg.Width, coinBoxImg.Height);
            //draw MirBox
            for (int i = 0; i < mirBoxlist_x.Length; i++)
                if (CalShowOnScreen(mirBoxlist_x[i]))
                    e.Graphics.DrawImage(mirBoxImg, mirBoxlist_x[i], mirBoxlist_y[i], mirBoxImg.Width, mirBoxImg.Height);
            
            //draw mush
            //red_mush
            if (red_mush_show == true)
                e.Graphics.DrawImage(red_mush, red_mush_x, red_mush_y, red_mush.Width, red_mush.Height);
            //blue_mush
            if (blue_mush_show == true)
                e.Graphics.DrawImage(blue_mush, blue_mush_x, blue_mush_y, blue_mush.Width, blue_mush.Height);
            //gold_mush
            if (gold_mush_show == true)
                e.Graphics.DrawImage(gold_mush, gold_mush_x, gold_mush_y, gold_mush.Width, gold_mush.Height);
            //draw mario
            if (stand_status == false)
            {
                if (mario_dir == true)
                    e.Graphics.DrawImage(mario_right_stand.Images[mario_right_stand_index], mario_x, mario_y);
                else
                    e.Graphics.DrawImage(mario_left_stand.Images[mario_left_stand_index], mario_x, mario_y);
            }
            else
            {
                if (mario_dir == true)
                    e.Graphics.DrawImage(mario_right.Images[mario_right_index], mario_x, mario_y);
                else
                    e.Graphics.DrawImage(mario_left.Images[mario_left_index], mario_x, mario_y);
            }
            //draw toxicMush
            if (toxic_mush_show == true)
            {
                if (CalShowOnScreen(toxic_mush1_x))
                {
                    if (toxic_mush_die == false)
                    {
                        if (toxicmushFlag)
                            e.Graphics.DrawImage(toxic_mush_right.Images[toxic_mush_right_index], toxic_mush1_step, toxic_mush1_y);
                        else
                            e.Graphics.DrawImage(toxic_mush_left.Images[toxic_mush_left_index], toxic_mush1_step, toxic_mush1_y);
                    }
                    else
                    {
                        e.Graphics.DrawImage(toxic_mush_dead.Images[toxic_mush_dead_index], toxic_mush1_step, toxic_mush1_y - 20);
                    }
                }
            }
            //draw ToxicFish
            if (toxic_fish1_show == true)
            {
                if (CalShowOnScreen(toxic_fish1_x))
                {
                    if (toxic_fish1_die == false)
                        e.Graphics.DrawImage(toxic_fish, toxic_fish1_x, toxic_fish1_y);
                    else
                        e.Graphics.DrawImage(toxic_fish_dead.Images[toxic_fish1_dead_index], toxic_fish1_x, toxic_fish1_y);
                }
            }
            if (toxic_fish2_show == true)
            {
                if (CalShowOnScreen(toxic_fish2_x))
                {
                    if (toxic_fish2_die == false)
                        e.Graphics.DrawImage(toxic_fish, toxic_fish2_x, toxic_fish2_y);
                    else
                        e.Graphics.DrawImage(toxic_fish_dead.Images[toxic_fish2_dead_index], toxic_fish2_x, toxic_fish2_y);
                }
            }
            //draw ToxicTurtle
            if (toxic_turtle_show == true)
            {
                if (CalShowOnScreen(toxic_turtle_x))
                {
                    if (toxic_turtle_die == false)
                        e.Graphics.DrawImage(toxic_turtle.Images[toxic_turtle_index], toxic_turtle_x, toxic_turtle_y);
                    else
                        e.Graphics.DrawImage(toxic_turtle_dead.Images[toxic_turtle_dead_index], toxic_turtle_x, toxic_turtle_y);
                }
            }
            
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up) labelUp = true;
            if (e.KeyCode == Keys.Down) labelDown = true;
            if (e.KeyCode == Keys.Left) labelLeft = true;
            if (e.KeyCode == Keys.Right) labelRight = true;
            if (e.KeyCode == Keys.W) labelW = true;
            if (e.KeyCode == Keys.S) labelS = true;
            if (e.KeyCode == Keys.A) labelA = true;
            if (e.KeyCode == Keys.D) labelD = true;
            if (e.Control) labelCtrl = true;
            if (e.Alt) labelAlt = true;

            mario_before_jump_y = mario_y;
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            //calculate whether ice_ball kill Toxic_Turtle
            for (int i = 0; i < ice_ball_list_x.Length; i++)
            {
                if ((ice_ball_list_x[i] - toxic_turtle_x >= 0) && (Math.Abs(ice_ball_list_y[i] - toxic_turtle_y) <= 100))
                {
                    toxic_turtle_die = true;
                    ice_ball_tmp = 0;
                    labelW = false;
                    labelS = false;
                    labelD = false;
                    labelA = false;
                    ice_ball_flag = false;
                }
            }
            //calculate whether ice_ball kill Toxic_Fish
            for (int i = 0; i < ice_ball_list_x.Length; i++)
            {
                if ((ice_ball_list_x[i] - toxic_fish1_x >= 0) && (Math.Abs(ice_ball_list_y[i] - toxic_fish1_y) <= 20))
                {
                    toxic_fish1_die = true;
                    ice_ball_tmp = 0;
                    labelW = false;
                    labelS = false;
                    labelD = false;
                    labelA = false;
                    ice_ball_flag = false;
                }
            }
            for (int i = 0; i < ice_ball_list_x.Length; i++)
            {
                if ((ice_ball_list_x[i] - toxic_fish2_x >= 0) && (Math.Abs(ice_ball_list_y[i] - toxic_fish2_y) <= 10))
                {
                    toxic_fish2_die = true;
                    ice_ball_tmp = 0;
                    labelW = false;
                    labelS = false;
                    labelD = false;
                    labelA = false;
                    ice_ball_flag = false;
                }
            }


            //calculate whether ice_ball kill Toxic_Mush
            for (int i = 0; i < ice_ball_list_x.Length; i++)
            {
                if ((ice_ball_list_x[i] - toxic_mush1_step >= 0) && (Math.Abs(ice_ball_list_y[i] - toxic_mush1_y) <= 100))
                {
                    toxic_mush_die = true;
                    ice_ball_tmp = 0;
                    labelW = false;
                    labelS = false;
                    labelD = false;
                    labelA = false;
                    ice_ball_flag = false;
                }
            }
            //show mush num on form
            label1.Text = Convert.ToString(red_mush_num);
            label2.Text = Convert.ToString(blue_mush_num);
            label3.Text = Convert.ToString(gold_mush_num);
            //calculate Mario eat mush
            //red_mush
            if (Math.Abs(mario_x - red_mush_x) <= 20 && Math.Abs(mario_y - red_mush_y) <= 55 && red_mush_eat == false)
            {
                red_mush_num += 1;
                red_mush_eat = true;
            }
            //blue_mush
            if (Math.Abs(mario_x - blue_mush_x) <= 20 && Math.Abs(mario_y - blue_mush_y) <= 55 && blue_mush_eat == false)
            {
                blue_mush_num += 1;
                blue_mush_eat = true;
            }
            //gold_mush
            if (Math.Abs(mario_x - gold_mush_x) <= 20 && Math.Abs(mario_y - gold_mush_y) <= 55 && gold_mush_eat == false)
            {
                gold_mush_num += 1;
                gold_mush_eat = true;
            }

            //mush_motion
            //red_mush
            if (red_mush_show == true && red_mush_x >= -20)
                red_mush_x -= 20;
            else
                red_mush_show = false;
            //calculate whether red_mush free fall
            /*
            //on brickH
            cnt = 0;
            while (cnt < brickHlist_x.Length)
            {
                if (cnt == 2 || cnt == 9 || cnt == 12 || cnt == 17 || cnt == 19 || cnt == 28)
                {
                    if (brickHlist_x[cnt] - red_mush_x >= 64 && brickHlist_x[cnt] - red_mush_x <= 90)
                        red_mush_y = 625;
                }
                cnt++;
            }
            //on CoinBox
            cnt = 0;
            while (cnt < coinBoxlist_x.Length)
            {
                if (cnt == 0 || cnt == 3 || cnt == 4 || cnt == 5 || cnt == 6)
                {
                    if (coinBoxlist_x[cnt] - red_mush_x >= 64 && coinBoxlist_x[cnt] - red_mush_x <= 90)
                        red_mush_y = 625;
                }
                cnt++;
            }
            */
            //on MirBox
            cnt = 0;
            while (cnt < mirBoxlist_x.Length)
            {
                if (cnt == 0 || cnt == 1)
                {
                    if (mirBoxlist_x[cnt] - red_mush_x >= 64 && mirBoxlist_x[cnt] - red_mush_x <= 90)
                        red_mush_y = 625;
                }
                cnt++;
            }
            //blue_mush
            if (blue_mush_show == true && blue_mush_x >= -20)
                blue_mush_x -= 20;
            else
                blue_mush_show = false;
            //calculate whether blue_mush free fall
            /*
            //on brickH
            cnt = 0;
            while (cnt < brickHlist_x.Length)
            {
                if (cnt == 2 || cnt == 9 || cnt == 12 || cnt == 17 || cnt == 19 || cnt == 28)
                {
                    if (brickHlist_x[cnt] - blue_mush_x >= 64 && brickHlist_x[cnt] - blue_mush_x <= 90)
                        blue_mush_y = 625;
                }
                cnt++;
            }
            */
            //on CoinBox
            cnt = 0;
            while (cnt < coinBoxlist_x.Length)
            {
                if (cnt == 3 || cnt == 4)
                {
                    if (coinBoxlist_x[cnt] - blue_mush_x >= 64 && coinBoxlist_x[cnt] - blue_mush_x <= 90)
                        blue_mush_y = 625;
                }
                cnt++;
            }
            /*
            //on MirBox
            cnt = 0;
            while (cnt < mirBoxlist_x.Length)
            {
                if (cnt == 0 || cnt == 1 || cnt == 7)
                {
                    if (mirBoxlist_x[cnt] - blue_mush_x >= 64 && mirBoxlist_x[cnt] - blue_mush_x <= 90)
                        blue_mush_y = 625;
                }
                cnt++;
            }
            */
            //gold_mush
            if (gold_mush_show == true && gold_mush_x >= -20)
                gold_mush_x -= 20;
            else
                gold_mush_show = false;
            //calculate whether gold_mush free fall
            /*
            //on brickH
            cnt = 0;
            while (cnt < brickHlist_x.Length)
            {
                if (cnt == 2 || cnt == 9 || cnt == 12 || cnt == 17 || cnt == 19 || cnt == 28)
                {
                    if (brickHlist_x[cnt] - gold_mush_x >= 64 && brickHlist_x[cnt] - gold_mush_x <= 90)
                        gold_mush_y = 625;
                }
                cnt++;
            }
            */
            //on CoinBox
            cnt = 0;
            while (cnt < coinBoxlist_x.Length)
            {
                if (cnt == 5 || cnt == 6)
                {
                    if (coinBoxlist_x[cnt] - gold_mush_x >= 64 && coinBoxlist_x[cnt] - gold_mush_x <= 90)
                        gold_mush_y = 625;
                }
                cnt++;
            }
            //on MirBox
            cnt = 0;
            while (cnt < mirBoxlist_x.Length)
            {
                if (cnt == 4 || cnt == 5 || cnt == 7)
                {
                    if (mirBoxlist_x[cnt] - gold_mush_x >= 64 && mirBoxlist_x[cnt] - gold_mush_x <= 90)
                        gold_mush_y = 625;
                }
                cnt++;
            }

            //marioRight_Tick
            mario_right_index++;
            if (mario_right_index == mario_right.Images.Count)
                mario_right_index = 0;
            this.Invalidate();

            //marioLeft_Tick
            mario_left_index++;
            if (mario_left_index == mario_left.Images.Count)
                mario_left_index = 0;
            this.Invalidate();

            //marioRightStand_Tick
            mario_right_stand_index++;
            if (mario_right_stand_index == mario_right_stand.Images.Count)
                mario_right_stand_index = 0;
            this.Invalidate();

            //marioLeftStand_Tick
            mario_left_stand_index++;
            if (mario_left_stand_index == mario_left_stand.Images.Count)
                mario_left_stand_index = 0;
            this.Invalidate();

            //ToxicPond_Tick
            toxic_pond_index++;
            if (toxic_pond_index == toxic_pond.Images.Count)
                toxic_pond_index = 0;
            this.Invalidate();

            //Coin_Tick
            coin_index++;
            coin_tmp++;
            if (coin_index == coin.Images.Count)
            {
                coin_index = 0;
                
            }
            if (coin_tmp >= 2* coin.Images.Count)
            {
                coin_show = false;
                coin_tmp = 0;
            }
            this.Invalidate();

            //ToxicTurtle_Tick
            toxic_turtle_index++;
            if (toxic_turtle_index == toxic_turtle.Images.Count)
                toxic_turtle_index = 0;
            this.Invalidate();

            toxic_turtle_dead_index++;
            if (toxic_turtle_dead_index == toxic_turtle_dead.Images.Count)
            {
                toxic_turtle_dead_index = 0;
                if (toxic_turtle_die == true)
                {
                    toxic_turtle_show = false;
                }
            }
            this.Invalidate();

            //ToxicMush_Tick
            toxic_mush_right_index++;
            if (toxic_mush_right_index == toxic_mush_right.Images.Count)
                toxic_mush_right_index = 0;
            this.Invalidate();
            
            toxic_mush_left_index++;
            if (toxic_mush_left_index == toxic_mush_left.Images.Count)
                toxic_mush_left_index = 0;
            this.Invalidate();

            toxic_mush_dead_index++;
            if (toxic_mush_dead_index == toxic_mush_dead.Images.Count)
            {
                toxic_mush_dead_index = 0;
                if (toxic_mush_die == true)
                {
                    toxic_mush_show = false;
                    //toxic_mush_die = false;
                }
            }
            this.Invalidate();

            //Toxic_Fish
            if (CalShowOnScreen(toxic_fish1_x))
            {
                toxic_fish1_y += move_fish1_step;
                if (toxic_fish1_y <= 350 || toxic_fish1_y >= 600)
                    move_fish1_step = -move_fish1_step;
            }
            if (CalShowOnScreen(toxic_fish2_x))
            {
                toxic_fish2_y += move_fish2_step;
                if (toxic_fish2_y <= 350 || toxic_fish2_y >= 600)
                    move_fish2_step = -move_fish2_step;
            }
            toxic_fish1_dead_index++;
            if (toxic_fish1_dead_index == toxic_fish_dead.Images.Count)
            {
                toxic_fish1_dead_index = 0;
                if (toxic_fish1_die == true)
                {
                    toxic_fish1_show = false;
                }
            }
            toxic_fish2_dead_index++;
            if (toxic_fish2_dead_index == toxic_fish_dead.Images.Count)
            {
                toxic_fish2_dead_index = 0;
                if (toxic_fish2_die == true)
                {
                    toxic_fish2_show = false;
                }
            }
            this.Invalidate();

            //moveStair
            for (int i = 0; i < moveStairlist.Length; i++)
            {
                if (CalShowOnScreen(moveStairlist[i]))
                {
                    if (i == 0)
                    {
                        moveStairImg1_y += move_stair1_step;
                        if (moveStairImg1_y <= 0 || moveStairImg1_y >= 621)
                            move_stair1_step = -move_stair1_step;
                    }
                    else if (i == 1)
                    {
                        moveStairImg2_y += move_stair2_step;
                        if (moveStairImg2_y <= 0 || moveStairImg2_y >= 621)
                            move_stair2_step = -move_stair2_step;
                    }  
                }
            }

            


            //toxic_rhino
            toxic_rhino1_x = toxic_rhino1_x + toxic_rhino_radius * (float)Math.Cos(toxix_rhino_angle);
            toxic_rhino1_y = toxic_rhino1_y + toxic_rhino_radius * (float)Math.Sin(toxix_rhino_angle);

            toxic_rhino2_x = toxic_rhino2_x + toxic_rhino_radius * (float)Math.Cos(toxix_rhino_angle);
            toxic_rhino2_y = toxic_rhino2_y + toxic_rhino_radius * (float)Math.Sin(toxix_rhino_angle);
            
            mirBoxlist_x[4] = mirBoxlist_x[4] + toxic_rhino_radius * (float)Math.Cos(toxix_rhino_angle);
            mirBoxlist_y[4] = mirBoxlist_y[4] + toxic_rhino_radius * (float)Math.Sin(toxix_rhino_angle);

            mirBoxlist_x[5] = mirBoxlist_x[5] + toxic_rhino_radius * (float)Math.Cos(toxix_rhino_angle);
            mirBoxlist_y[5] = mirBoxlist_y[5] + toxic_rhino_radius * (float)Math.Sin(toxix_rhino_angle);
            
            toxix_rhino_angle += 0.1f;

            if (toxix_rhino_angle >= 2*Math.PI)
                toxix_rhino_angle = 0;

            //toxic_mush
            if (toxic_mush1_step - toxic_mush1_x >= 0 && toxic_mush1_step - toxic_mush1_x <= 500 && toxicmushFlag)
            {
                toxic_mush1_step += 20;
            }
            else if (toxic_mush1_step - toxic_mush1_x > 500 && toxicmushFlag) 
            {
                toxicmushFlag = !toxicmushFlag;
                toxic_mush1_step -= 20;
            }
            else if (toxic_mush1_step - toxic_mush1_x >= 0 && toxic_mush1_step - toxic_mush1_x <= 500 && !toxicmushFlag)
            {
                toxic_mush1_step -= 20;
            }
            else if (toxic_mush1_step - toxic_mush1_x < 0 && !toxicmushFlag)
            {
                toxicmushFlag = !toxicmushFlag;
                toxic_mush1_step += 20;
            }

            //Shoot Bullet
            //Bullet1
            if (!bullet1_move_flag)
                if (Math.Abs(bullet1_x - mario_x) < 600)
                    bullet1_move_flag = true;
            if (CalShowOnScreen(bullet1_x) && bullet1_move_flag)
                bullet1_x -= 50;
            //Bullet2
            if (!bullet2_move_flag)
                if (mario_x - bullet2_x > 350)
                    bullet2_move_flag = true;
            if (CalShowOnScreen(bullet2_x) && bullet2_move_flag)
                bullet2_x += 50;  
        }

        private void mario_die_Tick(object sender, EventArgs e)
        {
            stand_status = true;
            mario_before_jump_y = mario_y;
            
            //calculate the current position for a jump
            mario_jump_y = -30 * mario_jump_time + 0.5f * 9.8f * mario_jump_time * mario_jump_time;
            //update the current positon
            mario_y = mario_before_jump_y + mario_jump_y;
            //update time duration for a jump
            mario_jump_time += 2f;

            if (mario_y > 1000)
            {
                Form3 f2 = new Form3();
                f2.Show();
                mario_die.Enabled = false;
            }
        }

        private void mario_motion_Tick(object sender, EventArgs e)
        {
            //Mario_MoveStaris
            if ((mario_x >= moveStairlist[0]) && (mario_x <= moveStairlist[0] + 200))
            {
                mario_on_moveStair1 = true;
                mario_on_moveStair2 = false;
                if (move_stair1_step == 20)
                    mario_y = moveStairImg1_y - 70;
                else
                    mario_y = moveStairImg1_y - 100;
            }
            else if ((mario_x >= moveStairlist[1]) && (mario_x <= moveStairlist[1] + 200))
            {
                mario_on_moveStair2 = true;
                mario_on_moveStair1 = false;
                if (move_stair1_step == 20)
                    mario_y = moveStairImg2_y - 70;
                else
                    mario_y = moveStairImg2_y - 100;
            }
            else
            {
                mario_on_moveStair1 = false;
                mario_on_moveStair2 = false;
            }
            

            //Mario_ToxicMush_Die
            if ((labelRight == true || labelLeft == true) && (Math.Abs(mario_x - toxic_mush1_step) <= 50) && (Math.Abs(mario_y + 20 - toxic_mush1_y) <= 50) && (toxic_mush_die == false))
            {
                mario_die.Enabled = true;
                mario_motion.Enabled = false;
            }
            //Mario_Bullet_Die
            //Bullet1
            if ((Math.Abs(bullet1_x - mario_x) <= 50) && (Math.Abs(mario_y - 35 - bullet1_y) <= 50))
            {
                mario_die.Enabled = true;
                mario_motion.Enabled = false;
            }
            //Bullet2
            if ((Math.Abs(mario_x - bullet2_x) <= 50) && (Math.Abs(mario_y - 35 - bullet2_y)
                <= 50))
            {
                mario_die.Enabled = true;
                mario_motion.Enabled = false;
            }
            //Mario_ToxicFish_Die
            //ToxicFish1
            if ((Math.Abs(toxic_fish1_x - mario_x) <= 50) && (Math.Abs(mario_y - toxic_fish1_y) <= 50))
            {
                mario_die.Enabled = true;
                mario_motion.Enabled = false;
            }
            //ToxicFish2
            if ((Math.Abs(toxic_fish2_x - mario_x) <= 50) && (Math.Abs(mario_y - toxic_fish2_y) <= 50))
            {
                mario_die.Enabled = true;
                mario_motion.Enabled = false;
            }

            //tmp>>mario_to_exit_door
            if ((labelCtrl == true) && (labelAlt == true) && (gold_mush_num >= 1))
            {
                mario_x = brickHlist_x[27];
                mario_y = brickHlist_y[27] - 80;
                labelCtrl = false;
                labelAlt = false;
            }

            //mario_right_upstair
            if ((labelUp == true) && (labelCtrl == true))
            {
                mario_dir = true;
                mario_x += 64;
                mario_y -= 64;
                labelUp = false;
                labelCtrl = false;
            }
            //mario_right_downstair
            else if ((labelDown == true) && (labelCtrl == true))
            {
                mario_dir = true;
                mario_x += 64;
                mario_y += 64;
                labelDown = false;
                labelCtrl = false;
            }
            //mario_left_upstair
            else if ((labelUp == true) && (labelAlt == true))
            {
                mario_dir = false;
                mario_x -= 64;
                mario_y -= 64;
                labelUp = false;
                labelAlt = false;
            }
            //mario_left_downstair
            else if ((labelDown == true) && (labelAlt == true))
            {
                mario_dir = false;
                mario_x -= 64;
                mario_y += 64;
                labelDown = false;
                labelAlt = false;
            }
            //mario_forward_jump_Tick
            else if ((labelUp == true) && (labelRight == true))
            {
                stand_status = true;
                mario_dir = true;

                //calculate Mario above object
                //on brickH
                int i = 0;
                while (i < brickHlist_x.Length)
                {
                    if (((mario_x - brickHlist_x[i]) >= 0) && ((mario_x - brickHlist_x[i]) <= 64))
                    {
                        mario_end_y = brickHlist_y[i];
                        break;
                    }
                    else
                    {
                        mario_end_y = mario_base_y;
                    }
                    i++;
                }
                
                //on stair
                if (mario_on_moveStair1 == true)
                    mario_end_y = moveStairImg1_y;
                if (mario_on_moveStair2 == true)
                    mario_end_y = moveStairImg2_y;
                
                /*
                //on CoinBox
                i = 0;
                while (i < coinBoxlist_x.Length)
                {
                    if (((mario_x - coinBoxlist_x[i]) >= 0) && ((mario_x - coinBoxlist_x[i]) <= 64))
                    {
                        mario_end_y = coinBoxlist_y[i];
                        break;
                    }
                    else
                    {
                        mario_end_y = mario_base_y;     
                    }
                    i++;
                }
                //on MirBox
                i = 0;
                while (i < mirBoxlist_x.Length)
                {
                    if (((mario_x - mirBoxlist_x[i]) >= -20) && ((mario_x - mirBoxlist_x[i]) <= 64))
                    {
                        mario_end_y = mirBoxlist_y[i];
                        break;
                    }
                    else
                    {
                        mario_end_y = mario_base_y;
                    }
                    i++;
                }
                */

                //calculate Mario position
                if (mario_y <= mario_end_y - 80)
                {
                    //calculate the current position for a jump
                    mario_x += mario_jump_initial_velocity * (float)Math.Cos(angle) * 0.5f;
                    //mario_jump_y = mario_jump_initial_velocity * (float)Math.Sin(angle * Math.PI / 180) * mario_jump_time + 0.5f * 9.8f * mario_jump_time * mario_jump_time;
                    mario_jump_y = (-90) * (float)Math.Sin(angle * Math.PI / 180) * mario_jump_time + 0.5f * 9.8f * mario_jump_time * mario_jump_time;

                    //update the current positon
                    mario_y = mario_before_jump_y + mario_jump_y;
                    if (mario_y > mario_end_y - 80)
                        mario_y = mario_end_y - 80 + 0.1f;
                    //update time duration for a jump
                    mario_jump_time += 2f;
                }
                else
                {
                    stand_status = false;
                    mario_jump_y = 0;
                    mario_y = mario_end_y - 80;
                    mario_jump_time = 0;
                    labelUp = false;
                    labelRight = false;
                }
            }
            //mario_backward_jump_Tick
            else if ((labelUp == true) && (labelLeft == true))
            {
                stand_status = true;
                mario_dir = false;

                //calculate Mario above object
                //on brickH
                int i = 0;
                while (i < brickHlist_x.Length)
                {
                    if (((mario_x - brickHlist_x[i]) >= -20) && ((mario_x - brickHlist_x[i]) <= 64))
                    {
                        mario_end_y = brickHlist_y[i];
                        break;
                    }
                    else
                    {
                        mario_end_y = mario_base_y;
                    }
                    i++;
                }
                /*
                //on CoinBox
                i = 0;
                while (i < coinBoxlist_x.Length)
                {
                    if (((mario_x - coinBoxlist_x[i]) >= -20) && ((mario_x - coinBoxlist_x[i]) <= 64))
                    {
                        mario_end_y = coinBoxlist_y[i];
                        break;
                    }
                    else
                    {
                        mario_end_y = mario_base_y;
                    }
                    i++;
                }
                //on MirBox
                i = 0;
                while (i < mirBoxlist_x.Length)
                {
                    if (((mario_x - mirBoxlist_x[i]) >= -20) && ((mario_x - mirBoxlist_x[i]) <= 64))
                    {
                        mario_end_y = mirBoxlist_y[i];
                        break;
                    }
                    else
                    {
                        mario_end_y = mario_base_y;
                    }
                    i++;
                }
                */

                //calculate Mario position
                if (mario_y <= mario_end_y - 80)
                {
                    //calculate the current position for a jump
                    mario_x -= mario_jump_initial_velocity * (float)Math.Cos(angle) * 0.5f;
                    mario_jump_y = mario_jump_initial_velocity * (float)Math.Sin(angle * Math.PI / 180) * mario_jump_time + 0.5f * 9.8f * mario_jump_time * mario_jump_time;
                    //update the current positon
                    mario_y = mario_before_jump_y + mario_jump_y;
                    if (mario_y > mario_end_y - 80)
                        mario_y = mario_end_y - 80 + 0.1f;
                    //update time duration for a jump
                    mario_jump_time += 2f;
                }
                else
                {
                    stand_status = false;
                    mario_jump_y = 0;
                    mario_y = mario_end_y - 80;
                    mario_jump_time = 0;
                    labelUp = false;
                    labelLeft = false;
                }
            }
            //mario_jump_Tick
            else if (labelUp == true)
            {
                stand_status = true;

                //calculate Mario hit object
                //hit brickH
                int i = 0;
                while (i < brickHlist_x.Length)
                {
                    if (((mario_x - brickHlist_x[i]) >= -20) && ((mario_x - brickHlist_x[i]) <= 64))
                    {
                        //brick_vibrate
                        if (object_shake_flag == true)
                        {
                            brickHlist_y[i] += 10;
                            object_shake_flag = false;
                        }
                        //mario_not_over_brick
                        mario_jumo_hit_top = brickHlist_y[i] + 64;
                        if ((Math.Abs(mario_y - brickHlist_y[i]) <= 100))
                        {
                            if (object_shake_flag == false)
                            {
                                brickHlist_y[i] -= 10;
                                object_shake_flag = true;
                            }
                        }
                    }
                    i++;
                }
                //hit coinBox
                i = 0;
                while (i < coinBoxlist_x.Length)
                {
                    if (((mario_x - coinBoxlist_x[i]) >= -20) && ((mario_x - coinBoxlist_x[i]) <= 64))
                    {
                        //coinBox_vibrate
                        if (object_shake_flag == true)
                        {
                            coinBoxlist_y[i] += 10;
                            object_shake_flag = false;
                        }
                        //mario_not_over_coinBox
                        mario_jumo_hit_top = coinBoxlist_y[i] + 64;
                        if ((Math.Abs(mario_y - coinBoxlist_y[i]) <= 100))
                        {
                            if (object_shake_flag == false)
                            {
                                coinBoxlist_y[i] -= 10;
                                object_shake_flag = true;
                                coin_show = true;
                            }
                        }
                        coin_x = coinBoxlist_x[i] + 5;
                        coin_y = coinBoxlist_y[i] - 65;
                    }
                    i++;
                }
                //hit mirBox
                i = 0;
                while (i < mirBoxlist_x.Length)
                {
                    if (((mario_x - mirBoxlist_x[i]) >= -20) && ((mario_x - mirBoxlist_x[i]) <= 64))
                    {
                        //mirBox_vibrate
                        if (object_shake_flag == true)
                        {
                            mirBoxlist_y[i] += 10;
                            object_shake_flag = false;
                        }
                        //mario_not_over_mirBox
                        mario_jumo_hit_top = mirBoxlist_y[i] + 64;
                        if ((Math.Abs(mario_y - mirBoxlist_y[i]) <= 100))
                        {
                            if (object_shake_flag == false)
                            {
                                mirBoxlist_y[i] -= 10;
                                object_shake_flag = true;
                            }
                            if (i == 0 || i == 1)
                            {
                                red_mush_eat = false;
                                red_mush_show = true;
                                red_mush_x = mirBoxlist_x[i] + 20;
                                red_mush_y = mirBoxlist_y[i] - 58;
                            }
                            else if (i == 2 || i == 3)
                            {
                                blue_mush_eat = false;
                                blue_mush_show = true;
                                blue_mush_x = mirBoxlist_x[i] + 20;
                                blue_mush_y = mirBoxlist_y[i] - 58;
                            }
                            else
                            {
                                gold_mush_eat = false;
                                gold_mush_show = true;
                                gold_mush_x = mirBoxlist_x[i] + 20;
                                gold_mush_y = mirBoxlist_y[i] - 58;
                            }
                        }
                    }
                    i++;
                }

                if (mario_jump_hit_top_flag == false)
                    if (mario_y <= mario_jumo_hit_top)
                        mario_jump_hit_top_flag = true;
                if (mario_jump_hit_top_flag == true)
                {
                    mario_y += 50;
                    if (mario_y > mario_before_jump_y)
                    {
                        mario_jump_hit_top_flag = false;
                        stand_status = false;
                        mario_jump_y = 0;
                        mario_y = mario_before_jump_y;
                        mario_jump_time = 0;
                        labelUp = false;
                    }
                }
                else 
                if (mario_y <= mario_before_jump_y)
                {
                    //calculate the current position for a jump
                    mario_jump_y = mario_jump_initial_velocity * (float)Math.Sin(angle * Math.PI / 180) * mario_jump_time + 0.5f * 9.8f * mario_jump_time * mario_jump_time;
                    //update the current positon
                    mario_y = mario_before_jump_y + mario_jump_y;
                    if (mario_y > mario_before_jump_y)
                        mario_y = mario_before_jump_y + 0.1f;
                    //update time duration for a jump
                    mario_jump_time += 2f;
                }
                else
                {
                    stand_status = false;
                    mario_jump_y = 0;
                    mario_y = mario_before_jump_y;
                    mario_jump_time = 0;
                    labelUp = false;
                }
            }
            else if (labelDown == true)
            {

            }
            //marioStepInscrease()
            else if (labelRight == true)
            {
                stand_status = true;
                mario_dir = true;

                //for mario_x
                //marioStepInscrease
                if (mario_x + floor_x < path_distance - 400)
                {
                    //Mario_Cannon_Stop
                    if ((Math.Abs(mario_x - cannon_x) < 70) && (Math.Abs(mario_y - 35 - cannon_y) < 50))
                    {
                        
                    }
                    else if (mario_x <= mid_point)
                        mario_x += 50;
                    else
                    {
                        floor_x -= 50;
                        //move brickH
                        for (int i = 0; i < brickHlist_x.Length; i++)
                        {
                            if (CalShowOnScreen(brickHlist_x[i]))
                                brickHlist_x[i] -= 50;
                        }
                        // move moveStair
                        for (int i = 0; i < moveStairlist.Length; i++)
                        {
                            if (CalShowOnScreen(brickHlist_x[i]))
                                moveStairlist[i] -= 50;
                        }
                        //move CoinBox
                        for (int i = 0; i < coinBoxlist_x.Length; i++)
                        {
                            if (CalShowOnScreen(coinBoxlist_x[i]))
                                coinBoxlist_x[i] -= 50;
                        }
                        //move MirBox
                        for (int i = 0; i < mirBoxlist_x.Length; i++)
                        {
                            if (CalShowOnScreen(mirBoxlist_x[i]))
                                mirBoxlist_x[i] -= 50;
                        }
                        //move Cannon
                        cannon_x -= 50;
                        //move ToxicPond
                        toxic_pond_x -= 50;
                        //move wall
                        wall_x -= 50;
                        //move toxic_rhino
                        toxic_rhino1_x -= 50;
                        toxic_rhino2_x -= 50;
                        //move ToxicTurtle
                        toxic_turtle_x -= 50;
                        //move ToxicMush
                        toxic_mush1_step -= 50;
                        toxic_mush1_x -= 50;
                        //move Bullet
                        bullet1_x -= 50;
                        bullet2_x -= 50;
                        //move Exit_Door
                        exit_door_x -= 50;
                        //move ToxicFish
                        toxic_fish1_x -= 50;
                        toxic_fish2_x -= 50;
                    }
                }
                else
                {
                    mario_x += 50;
                }
                cnt_distance = mario_x - floor_x;

                //calculate whether Mario free fall
                //on moveStair
                if (mario_x - moveStairlist[0] >= 200 && mario_x - moveStairlist[0] <= 250)
                    freeFall.Enabled = true;
                if (mario_x - moveStairlist[1] >= 200 && mario_x - moveStairlist[1] <= 250)
                    freeFall.Enabled = true;
                //on brickH
                cnt = 0;
                while (cnt < brickHlist_x.Length)
                {
                    if (cnt == 5 || cnt == 10 || cnt == 12 || cnt == 18 || cnt == 19 || cnt == 21 || cnt == 24 || cnt == 26)
                    {
                        if (mario_x - brickHlist_x[cnt] >= 64 && mario_x - brickHlist_x[cnt] <= 90)
                            freeFall.Enabled = true;
                    }
                    cnt++;
                }
                //on CoinBox
                cnt = 0;
                while (cnt < coinBoxlist_x.Length)
                {
                    if (cnt == 0 || cnt == 1 || cnt == 2)
                    {
                        if (mario_x - coinBoxlist_x[cnt] >= 64 && mario_x - coinBoxlist_x[cnt] <= 90)
                            freeFall.Enabled = true;
                    }
                    cnt++;
                }
                //on MirBox
                cnt = 0;
                while (cnt < mirBoxlist_x.Length)
                {
                    if (cnt == 2 || cnt == 3 || cnt == 6)
                    {
                        if (mario_x - mirBoxlist_x[cnt] >= 64 && mario_x - mirBoxlist_x[cnt] <= 90)
                            freeFall.Enabled = true;
                    }
                    cnt++;
                }
                //on wall
                if ((mario_x - wall_x >= 0) && (mario_x - wall_x <= 400))
                    mario_y = wall_y - 90;
                else if (mario_x - wall_x >= 400) 
                    freeFall.Enabled = true;

                labelRight = false;
            }
            //marioStepDecrease()
            else if (labelLeft == true)
            {
                stand_status = true;
                mario_dir = false;

                //marioStepDecrease_Tick
                if (mario_x >= 50)
                    mario_x -= 50;


                //calculate whether Mario free fall
                //on brickH
                cnt = 0;
                while (cnt < brickHlist_x.Length)
                {
                    if (cnt == 2 || cnt == 9 || cnt == 12 || cnt == 17 || cnt == 19 || cnt == 28)
                    {
                        if (brickHlist_x[cnt] - mario_x >= 64 && brickHlist_x[cnt] - mario_x <= 90)
                            freeFall.Enabled = true;
                    }
                    cnt++;
                }
                //on CoinBox
                cnt = 0;
                while (cnt < coinBoxlist_x.Length)
                {
                    if (cnt == 0 || cnt == 3 || cnt == 4 || cnt == 5 || cnt == 6)
                    {
                        if (coinBoxlist_x[cnt] - mario_x >= 64 && coinBoxlist_x[cnt] - mario_x <= 90)
                            freeFall.Enabled = true;
                    }
                    cnt++;
                }
                //on MirBox
                cnt = 0;
                while (cnt < mirBoxlist_x.Length)
                {
                    if (cnt == 0 || cnt == 1 || cnt == 7)
                    {
                        if (mirBoxlist_x[cnt] - mario_x >= 64 && mirBoxlist_x[cnt] - mario_x <= 90)
                            freeFall.Enabled = true;
                    }
                    cnt++;
                }
                labelLeft = false;
            }
            //135 degree shoot ice_ball
            else if ((labelW == true) && (labelD == true) && (toxic_turtle_x - mario_x <= 800))
            //else if ((labelW == true) && (labelD == true) && (blue_mush_num >= 1))
            {
                //label4.Text = "true";
                mario_dir = true;
                if (ice_ball_flag == false)
                {
                    for (int i = 0; i < ice_ball_list_x.Length; i++)
                    {
                        ice_ball_list_x[i] = mario_x + 20;
                        ice_ball_list_y[i] = mario_y + 20;
                    }
                    ice_ball_flag = true;
                    label4.Text = Convert.ToString(ice_ball_flag);
                }
                for (int i = 0; i < ice_ball_list_x.Length; i++)
                {
                    if (ice_ball_list_x[i] < 1500)
                    {
                        if (i <= ice_ball_tmp)
                        {
                            ice_ball_list_x[i] += 30;
                            ice_ball_list_y[i] -= 30;
                        }
                    }
                    else
                    {
                        ice_ball_tmp = 0;
                        labelW = false;
                        labelD = false;
                        ice_ball_flag = false;
                    }
                }
                ice_ball_tmp++;
            }
            else if (labelW == true)
            {

            }
            else if (labelS == true)
            {

            }
            //180 degree shoot ice_ball
            else if (labelA == true)
            //else if ((labelA == true) && (red_mush_num >= 1))
            {
                mario_dir = false;
                if (ice_ball_flag == false)
                {
                    for (int i = 0; i < ice_ball_list_x.Length; i++)
                    {
                        ice_ball_list_x[i] = mario_x + 20;
                        ice_ball_list_y[i] = mario_y + 20;
                    }
                    ice_ball_flag = true;
                    //label4.Text = Convert.ToString(ice_ball_flag);
                }
                for (int i = 0; i < ice_ball_list_x.Length; i++)
                {
                    if (ice_ball_list_x[i] > -500)
                    {
                        if (i <= ice_ball_tmp)
                        {
                            ice_ball_list_x[i] -= 30;
                        }
                    }
                    else
                    {
                        ice_ball_tmp = 0;
                        labelA = false;
                        ice_ball_flag = false;
                    }
                }
                ice_ball_tmp++;
            }
            else if (labelD == true)
            //else if ((labelD == true) && (red_mush_num >= 1))
            {
                mario_dir = true;
                if (ice_ball_flag == false)
                {
                    for (int i = 0; i < ice_ball_list_x.Length; i++)
                    {
                        ice_ball_list_x[i] = mario_x + 20;
                        ice_ball_list_y[i] = mario_y + 20;
                    }
                    ice_ball_flag = true;
                }
                for (int i = 0; i<ice_ball_list_x.Length; i++)
                {
                    if (ice_ball_list_x[i] < 1500)
                    {
                        if (i <= ice_ball_tmp)
                        {
                            ice_ball_list_x[i] += 30;
                        }
                    }
                    else
                    {
                        ice_ball_tmp = 0;
                        labelD = false;
                        ice_ball_flag = false;
                    }
                }
                ice_ball_tmp++;
            }
        }

        private void Form2_KeyUp(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.D) ice_ball_flag = false;
        }


        private void freeFall_Tick(object sender, EventArgs e)
        {
            //calculate Mario position
            if (mario_y <= mario_base_y - 80)
            {
                //calculate the current position for free fall
                mario_jump_y = 0.5f * 9.8f * mario_jump_time * mario_jump_time;
                //update the current positon
                mario_y = mario_before_jump_y + mario_jump_y;
                if (mario_y > mario_base_y - 80)
                    mario_y = mario_base_y - 80 + 0.1f;
                //update time duration for a jump
                mario_jump_time += 2f;
            }
            else
            {
                stand_status = false;
                mario_jump_y = 0;
                mario_y = mario_base_y - 80;
                mario_jump_time = 0;
                freeFall.Enabled = false;
            }
        }
           
        private bool CalShowOnScreen(float pos)
        {
            if (screen_x - pos + cnt_distance - mid_point > 0)
                return true;
            else
                return false;
        }
        
        /*
        // To turn the background music on / off
        private void button1_Click(object sender, EventArgs e)
        {
            sound_state = !sound_state;
            if (sound_state)
            {
                myComputer2.Audio.Stop();
            }
            else
            {
                myComputer2.Audio.Play("..//..//..//..//Resource//Music//background_form2.wav", AudioPlayMode.Background);
            }
        }
        */
    }
}
