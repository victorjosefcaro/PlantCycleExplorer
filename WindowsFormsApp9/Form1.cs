using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int page;

        private void hideMenu()
        {
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button32.Visible = false;
            button7.Visible = true;
        }

        private void hideChapters()
        {
            button26.Visible = false;
            button27.Visible = false;
            button28.Visible = false;
            button29.Visible = false;
            button30.Visible = false;
            button31.Visible = false;
        }

        private void jumpChapter()
        {
            content();
            hideChapters();
            showContent();
            label1.Visible = false;
        }

        private void showContent()
        {
            button1.Visible = true;
            button2.Visible = true;
            label2.Visible = true;
        }

        private void content()
        {
            if (page == 0)
            {
                label2.Text = "Hello! in this module, you will learn all about the life " +
                    "cycle of a plant. To proceed, press the next button on the bottom " +
                    "right. You can also go back by pressing the back button on the " +
                    "bottom right. Pressing the menu button on the bottom left will " +
                    "take you back to the main screen. Make sure to understand the " +
                    "concepts because some questions will be asked before you can proceed.";
            }

            if (page == 1)
            {
                label2.Text = "Lifecycle is a continuous process that describes how a " +
                    "living thing starts its life, grows to maturity, reproduces, and " +
                    "dies. Plants are living things, they grow and reproduce like any " +
                    "other living thing. They follow a cyclic process of starting a new " +
                    "life, growing, and then coming back to the starting stage " +
                    "(reproducing). Plants start their life from seed and grow up to " +
                    "become mature plants.";
                pictureBox1.Visible = true;
            }

            if (page == 2)
            {
                label2.Text = "Most of the plants start their life as a seed. The seed " +
                    "is buried in the ground by various methods where it germinates and " +
                    "the first leaves of the plant start to appear called seedling. After " +
                    "that, further growth starts and the plants reaches maturity where " +
                    "it pollinates and gives seeds so that its species continue to " +
                    "survive by starting the life cycle again. The life cycle of plants " +
                    "can be broken into 5 main stages which are listed above.";
                pictureBox1.Visible = true;
            }

            if (page != 1 && page != 2)
            {
                pictureBox1.Visible = false;
            }

            if (page == 3)
            {
                label2.Text = "How many stages are there in a plant's life cycle?";
                disableNavBtns();
                button8.Visible = true;
                button9.Visible = true;
                button10.Visible = true;
                pictureBox7.Visible = true;
            }

            if (page == 4)
            {
                label2.Text = "The first stage of the life cycle is the seed stage." +
                    "Seeds are much like babies of animals. Seeds contain " +
                    "the embryo of the plants with necessary food and an outer coating " +
                    "for protection. The seeds are dispersed across the land in many " +
                    "ways, such as moving water, wind, animals, and humans. When they " +
                    "fall on the rich soil with necessary things, such as water and the " +
                    "right temperature, they germinate and start their journey of life.";
                pictureBox2.Visible = true;
            }

            if (page != 4)
            {
                pictureBox2.Visible = false;
            }

            if (page == 5)
            {
                label2.Text = "Seeds contain the ______ of the plants.";
                disableNavBtns();
                button11.Visible = true;
                button12.Visible = true;
                button13.Visible = true;
                pictureBox7.Visible = true;
            }

            if (page == 6)
            {
                label2.Text = "The second stage of the life cycle is the germination " +
                    "and seedling stage. When the conditions in the soil are just " +
                    "right, the seed germinates. First, it breaks the outer coating " +
                    "and begins growing its first roots and leaves. When the first sign " +
                    "of life from a seed appears out of the soil, it is called a " +
                    "seedling. As soon as the roots and leaves appear, they start their " +
                    "work, i.e. roots absorb water and nutrients, and leaves make food " +
                    "by photosynthesis.";
                pictureBox3.Visible = true;
            }

            if (page != 6)
            {
                pictureBox3.Visible = false;
            }

            if (page == 7)
            {
                label2.Text = "When the first sign of life from a seed appears out of " +
                    "the soil, it is called a ________";
                disableNavBtns();
                button14.Visible = true;
                button15.Visible = true;
                button16.Visible = true;
                pictureBox7.Visible = true;
            }

            if (page == 8)
            {
                label2.Text = "The third stage of the life cycle is the growing to " +
                    "maturity stage. The seedling continues to grow until it reaches " +
                    "its full maturity. The plant needs many necessary things during " +
                    "its growth. When plants become mature, they have to get stronger " +
                    "roots and an increased number of branches and leaves. At this " +
                    "stage, they are ready to make flowers and new seeds.";
                pictureBox4.Visible = true;
            }

            if (page != 8)
            {
                pictureBox4.Visible = false;
            }

            if (page == 9)
            {
                label2.Text = "When plants mature, what happens to its branches and leaves?";
                disableNavBtns();
                button17.Visible = true;
                button18.Visible = true;
                button19.Visible = true;
                pictureBox7.Visible = true;

            }

            if (page == 10)
            {
                label2.Text = "The fourth stage of the life cycle is the flowering, " +
                    "pollinating, and seeding stage. When plants become mature, they " +
                    "start to make flowers. A flower contains male and female parts; " +
                    "the male part is called a stamen, and the female part is called " +
                    "a pistil. The pollen is produced in the stamen part and needs to " +
                    "reach the pistil for the production of seeds. The pollen usually " +
                    "reaches to pistils by insects that land on flowers for sucking " +
                    "sweet fluids. When the pollen reaches the pistils, it fertilizes " +
                    "the cells inside it and produces seeds.";
                pictureBox5.Visible = true;
            }

            if (page == 11)
            {
                label2.Text = "There are many plants whose male and female parts are " +
                    "separated very far away. In this case, winds and insects play a " +
                    "very important role in pollination. Winds usually carry pollen " +
                    "along with them which often reach to female parts. On the other " +
                    "hand, Insects go from one plant to other for drinking sweets " +
                    "fluids. When they enter a flower, pollen sticks to their bodies " +
                    "and is carried to female parts when they land on that part of the " +
                    "plant.";
                pictureBox5.Visible = true;
            }

            if (page != 10 && page != 11)
            {
                pictureBox5.Visible = false;
            }

            if (page == 12)
            {
                label2.Text = "What part of the flower produces pollen?";
                disableNavBtns();
                button20.Visible = true;
                button21.Visible = true;
                button22.Visible = true;
                pictureBox7.Visible = true;
            }

            if (page == 13)
            {
                label2.Text = "The final stage of the life cycle is the seed dipsersion " +
                    "stage. After the production of seeds, the plants need a way to " +
                    "disperse these seeds to favorable places where they can germinate " +
                    "and start their life cycle. Most of the time, nature does the job " +
                    "of dispersion for the plants through winds, moving water, and " +
                    "animals. But there are also plants whose seeds are surrounded by " +
                    "fibers that help them to glide in the air upon falling from the " +
                    "plant. During their glide, they reach very far distances and start " +
                    "their life away from their parent plants.";
                pictureBox6.Visible = true;
            }

            if (page != 13)
            {
                pictureBox6.Visible = false;
            }

            if (page == 14)
            {
                label2.Text = "Which of the following isn't a method of seed dispersal?";
                disableNavBtns();
                button23.Visible = true;
                button24.Visible = true;
                button25.Visible = true;
                pictureBox7.Visible = true;
            }

            if (page == 15)
            {
                label2.Text = "Congratulations! You have reached the end of the module. " +
                    "Hopefully you have learned more about how plants go through their " +
                    "life cycles. You can check the chapters section in the menu to go " +
                    "back to specific topics in this module. Happy learning!";
            }
        }

        private void disableNavBtns()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button7.Enabled = false;
        }

        private void enableNavBtns()
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button7.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            page--;
            if (page < 0)
                page = 0;
            content();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            page++;
            if (page > 15)
                page = 15;
            content();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            hideMenu();
            label1.Visible = false;
            content();
            showContent();    
        }

        private void button4_Click(object sender, EventArgs e)
        {
            hideMenu();
            label1.Text = "Chapters";
            button26.Visible = true;
            button27.Visible = true;
            button28.Visible = true;
            button29.Visible = true;
            button30.Visible = true;
            button31.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            hideMenu();
            label1.Visible = false;
            label3.Visible = true;
            label3.Text = "Information: " + "\r\n" + "https://science4fun.info/life-cycle-of-plants/"
                + " \r\n" + "Images:" + "\r\n" + "https://www.irasutoya.com/";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = false;
            button32.Visible = true;
            label1.Visible = true;
            label1.Text = "Life Cycle of a Plant";
            label2.Visible = false;
            hideChapters();
            page = 0;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            label3.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            enableNavBtns();
            label2.Text = "Correct!";
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button9.UseVisualStyleBackColor = true;
            button10.UseVisualStyleBackColor = true;
            pictureBox7.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.BackColor = Color.LightCoral;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button10.BackColor = Color.LightCoral;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button11.BackColor = Color.LightCoral;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button12.BackColor = Color.LightCoral;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            enableNavBtns();
            label2.Text = "Correct!";
            button11.Visible = false;
            button12.Visible = false;
            button13.Visible = false;
            button11.UseVisualStyleBackColor = true;
            button12.UseVisualStyleBackColor = true;
            pictureBox7.Visible = false;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            enableNavBtns();
            label2.Text = "Correct!";
            button14.Visible = false;
            button15.Visible = false;
            button16.Visible = false;
            button15.UseVisualStyleBackColor = true;
            button16.UseVisualStyleBackColor = true;
            pictureBox7.Visible = false;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            button15.BackColor = Color.LightCoral;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            button16.BackColor = Color.LightCoral;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            button17.BackColor = Color.LightCoral;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            enableNavBtns();
            label2.Text = "Correct!";
            button17.Visible = false;
            button18.Visible = false;
            button19.Visible = false;
            button17.UseVisualStyleBackColor = true;
            button19.UseVisualStyleBackColor = true;
            pictureBox7.Visible = false;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            button19.BackColor = Color.LightCoral;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            button20.BackColor = Color.LightCoral;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            enableNavBtns();
            label2.Text = "Correct!";
            button20.Visible = false;
            button21.Visible = false;
            button22.Visible = false;
            button20.UseVisualStyleBackColor = true;
            button22.UseVisualStyleBackColor = true;
            pictureBox7.Visible = false;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            button22.BackColor = Color.LightCoral;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            button23.BackColor = Color.LightCoral;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            button24.BackColor = Color.LightCoral;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            enableNavBtns();
            label2.Text = "Correct!";
            button23.Visible = false;
            button24.Visible = false;
            button25.Visible = false;
            button23.UseVisualStyleBackColor = true;
            button24.UseVisualStyleBackColor = true;
            pictureBox7.Visible = false;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            page = 0;
            jumpChapter();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            page = 4;
            jumpChapter();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            page = 6;
            jumpChapter();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            page = 8;
            jumpChapter();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            page = 10;
            jumpChapter();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            page = 13;
            jumpChapter();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 quiz = new Form2();
            quiz.Show();
        }
    }
}