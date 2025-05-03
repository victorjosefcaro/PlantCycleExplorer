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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        int qNum;
        string[] answersMC = { "A", "C", "A", "A", "D", "D", "B", "B", "D", "C" };
        string[] userAnswersMC = { "", "", "", "", "", "", "", "", "", "" };
        string[] answersTOF = { "F", "T", "T", "F", "T", "T", "T", "T", "F", "T" };
        string[] userAnswersTOF = { "", "", "", "", "", "", "", "", "", "" };

        private void question1MC()
        {
            questionLbl.Text = "Question 1. It s a continuous process that describes " +
                        "how a living thing starts its life, grows to maturity, reproduces, " +
                        "and dies.";
            aRBtn.Text = "A. Life Cycle";
            bRBtn.Text = "B. Evolution";
            cRBtn.Text = "C. Reproduction";
            dRBtn.Text = "D. Ecosystem";
        }

        private void question2MC()
        {
            questionLbl.Text = "Question 2. Which of the following is NOT a stage of a " +
                        "plant's life cycle?";
            aRBtn.Text = "A. Seed Dispersion";
            bRBtn.Text = "B. Germination and Seedling";
            cRBtn.Text = "C. Cessation";
            dRBtn.Text = "D. Growing to Maturity";
        }

        private void question3MC()
        {
            questionLbl.Text = "Question 3. It contains the embryo of the plants with " +
                        "necessary food and an outer coating for protection.";
            aRBtn.Text = "A. Seed";
            bRBtn.Text = "B. Leaf";
            cRBtn.Text = "C. Stem";
            dRBtn.Text = "D. Flower";
        }

        private void question4MC()
        {
            questionLbl.Text = "Question 4. Plants make food for themselves through ____.";
            aRBtn.Text = "A. Photosynthesis";
            bRBtn.Text = "B. Germination";
            cRBtn.Text = "C. Reproduction";
            dRBtn.Text = "D. Photoperiodism";
        }

        private void question5MC()
        {
            questionLbl.Text = "Question 5. It is the process of transferring pollen " +
                        "from the male part to the female part.";
            aRBtn.Text = "A. Photomorphogenesis";
            bRBtn.Text = "B. Transpiration";
            cRBtn.Text = "C. Respiration";
            dRBtn.Text = "D. Pollination";
        }

        private void question6MC()
        {
            questionLbl.Text = "Question 6. It is much like the baby of an animal.";
            aRBtn.Text = "A. Flower";
            bRBtn.Text = "B. Stem";
            cRBtn.Text = "C. Leaf";
            dRBtn.Text = "D. Seed";
        }

        private void question7MC()
        {
            questionLbl.Text = "Question 7. It is the second stage of a plant's life cycle.";
            aRBtn.Text = "A. Seed Dispersion";
            bRBtn.Text = "B. Germination and Seedling";
            cRBtn.Text = "C. Growing to Maturity";
            dRBtn.Text = "D. Flowering, Pollinating, and Seedling";
        }

        private void question8MC()
        {
            questionLbl.Text = "Question 8. At this stage, they are ready to make " +
                        "flowers and new seeds.";
            aRBtn.Text = "A. Flowering, Pollinating, and Seedling";
            bRBtn.Text = "B. Growing to Maturity";
            cRBtn.Text = "C. Seed";
            dRBtn.Text = "D. Germination and Seedling";
        }

        private void question9MC()
        {
            questionLbl.Text = "Question 9. What does the stamen produce?";
            aRBtn.Text = "A. Energy";
            bRBtn.Text = "B. Water";
            cRBtn.Text = "C. Food";
            dRBtn.Text = "D. Pollen";
        }

        private void question10MC()
        {
            questionLbl.Text = "Question 10. Which of the following is not a way of seed " +
                        "dispersion?";
            aRBtn.Text = "A. Water";
            bRBtn.Text = "B. Animal";
            cRBtn.Text = "C. Sunlight";
            dRBtn.Text = "D. Wind";
        }

        private void question1TOF()
        {
            questionLbl.Text = "Question 1. Plants are non-living things.";
        }

        private void question2TOF()
        {
            questionLbl.Text = "Question 2. The female part of a plant is called the pistil.";
        }

        private void question3TOF()
        {
            questionLbl.Text = "Question 3. The roots of a plant absorb water and nutrients.";
        }

        private void question4TOF()
        {
            questionLbl.Text = "Question 4. Plants do not make their own food.";
        }

        private void question5TOF()
        {
            questionLbl.Text = "Question 5. The third stage of the plant's life cycle is " +
                "Growing to Maturity.";
        }

        private void question6TOF()
        {
            questionLbl.Text = "Question 6. In order to produce seeds, the pollen needs to " +
                "reach the pistil.";
        }

        private void question7TOF()
        {
            questionLbl.Text = "Question 7. The life cycle of a plant has five stages.";
        }

        private void question8TOF()
        {
            questionLbl.Text = "Question 8. Most of the time, nature does the job of " +
                "dispersion for the plants.";
        }

        private void question9TOF()
        {
            questionLbl.Text = "Question 9. Leaves make food by reproduction.";
        }

        private void question10TOF()
        {
            questionLbl.Text = "Question 10. Seedlings grow until it reaches its full maturity.";
        }

        private void questionsMC()
        {
            switch (qNum)
            {
                case 0:
                    question1MC();
                    clearAns();
                    break;
                case 1:
                    question2MC();
                    clearAns();
                    break;
                case 2:
                    question3MC();
                    clearAns();
                    break;
                case 3:
                    question4MC();
                    clearAns();
                    break;
                case 4:
                    question5MC();
                    clearAns();
                    break;
                case 5:
                    question6MC();
                    clearAns();
                    break;
                case 6:
                    question7MC();
                    clearAns();
                    break;
                case 7:
                    question8MC();
                    clearAns();
                    break;
                case 8:
                    question9MC();
                    clearAns();
                    break;
                case 9:
                    question10MC();
                    clearAns();
                    nextMCBtn.Visible = false;
                    finishMCBtn.Visible = true;
                    break;
            }
        }

        private void resultsMC()
        {
            switch (qNum)
            {
                case 0:
                    clearAns();
                    resetHighlights();
                    question1MC();
                    highlightAnsMC();
                    break;
                case 1:
                    resetHighlights();
                    question2MC();
                    highlightAnsMC();
                    break;
                case 2:
                    resetHighlights();
                    question3MC();
                    highlightAnsMC();
                    break;
                case 3:
                    resetHighlights();
                    question4MC();
                    highlightAnsMC();
                    break;
                case 4:
                    resetHighlights();
                    question5MC();
                    highlightAnsMC();
                    break;
                case 5:
                    resetHighlights();
                    question6MC();
                    highlightAnsMC();
                    break;
                case 6:
                    resetHighlights();
                    question7MC();
                    highlightAnsMC();
                    break;
                case 7:
                    resetHighlights();
                    question8MC();
                    highlightAnsMC();
                    break;
                case 8:
                    resetHighlights();
                    question9MC();
                    highlightAnsMC();
                    break;
                case 9:
                    resetHighlights();
                    question10MC();
                    highlightAnsMC();
                    break;
            }
        }

        private void questionsTOF()
        {
            switch (qNum)
            {
                case 0:
                    question1TOF();
                    clearAns();
                    break;
                case 1:
                    question2TOF();
                    clearAns();
                    break;
                case 2:
                    question3TOF();
                    clearAns();
                    break;
                case 3:
                    question4TOF();
                    clearAns();
                    break;
                case 4:
                    question5TOF();
                    clearAns();
                    break;
                case 5:
                    question6TOF();
                    clearAns();
                    break;
                case 6:
                    question7TOF();
                    clearAns();
                    break;
                case 7:
                    question8TOF();
                    clearAns();
                    break;
                case 8:
                    question9TOF();
                    clearAns();
                    break;
                case 9:
                    question10TOF();
                    clearAns();
                    nextTOFBtn.Visible = false;
                    finishTOFBtn.Visible = true;
                    break;
            }
        }

        private void resultsTOF()
        {
            switch (qNum)
            {
                case 0:
                    clearAns();
                    resetHighlights();
                    question1TOF();
                    highlightAnsTOF();
                    break;
                case 1:
                    resetHighlights();
                    question2TOF();
                    highlightAnsTOF();
                    break;
                case 2:
                    resetHighlights();
                    question3TOF();
                    highlightAnsTOF();
                    break;
                case 3:
                    resetHighlights();
                    question4TOF();
                    highlightAnsTOF();
                    break;
                case 4:
                    resetHighlights();
                    question5TOF();
                    highlightAnsTOF();
                    break;
                case 5:
                    resetHighlights();
                    question6TOF();
                    highlightAnsTOF();
                    break;
                case 6:
                    resetHighlights();
                    question7TOF();
                    highlightAnsTOF();
                    break;
                case 7:
                    resetHighlights();
                    question8TOF();
                    highlightAnsTOF();
                    break;
                case 8:
                    resetHighlights();
                    question9TOF();
                    highlightAnsTOF();
                    break;
                case 9:
                    resetHighlights();
                    question10TOF();
                    highlightAnsTOF();
                    break;
            }
        }

        private void clearAns()
        {
            aRBtn.Checked = false;
            bRBtn.Checked = false;
            cRBtn.Checked = false;
            dRBtn.Checked = false;
            tRBtn.Checked = false;
            fRBtn.Checked = false;
        }

        private void checkAnsMC()
        {
            double score = 0, grade;
            string result, pass = "PASSED";
            for (int i = 0; i < 10; i++)
            {
                if (answersMC[i] == userAnswersMC[i])
                    score++;
            }
            grade = score / 10 * 50 + 50;
            if (grade < 75)
                pass = "FAILED";
            result = "You got " + score + " out of 10 with a percentage grade of " + grade +
                "%. You " + pass;
            viewResults(result);
        }

        private void checkAnsTOF()
        {
            double score = 0, grade;
            string result, pass = "PASSED";
            for (int i = 0; i < 10; i++)
            {
                if (answersTOF[i] == userAnswersTOF[i])
                    score++;
            }
            grade = score / 10 * 50 + 50;
            if (grade < 75)
                pass = "FAILED";
            result = "You got " + score + " out of 10 with a percentage grade of " + grade +
                "%. You " + pass;
            viewResults(result);
        }

        private void viewResults(string result)
        {
            questionLbl.Text = "Result: " + result;
        }

        private void highlightAnsMC()
        {
            switch (answersMC[qNum])
            {
                case "A":
                    aRBtn.BackColor = Color.LightGreen;
                    break;
                case "B":
                    bRBtn.BackColor = Color.LightGreen;
                    break;
                case "C":
                    cRBtn.BackColor = Color.LightGreen;
                    break;
                case "D":
                    dRBtn.BackColor = Color.LightGreen;
                    break;
            }
            if (answersMC[qNum] != userAnswersMC[qNum])
            {
                switch (userAnswersMC[qNum])
                {
                    case "A":
                        aRBtn.BackColor = Color.LightCoral;
                        break;
                    case "B":
                        bRBtn.BackColor = Color.LightCoral;
                        break;
                    case "C":
                        cRBtn.BackColor = Color.LightCoral;
                        break;
                    case "D":
                        dRBtn.BackColor = Color.LightCoral;
                        break;
                }
            }
        }

        private void highlightAnsTOF()
        {
            switch (answersTOF[qNum])
            {
                case "T":
                    tRBtn.BackColor = Color.LightGreen;
                    break;
                case "F":
                    fRBtn.BackColor = Color.LightGreen;
                    break;
            }
            if (answersTOF[qNum] != userAnswersTOF[qNum])
            {
                switch (userAnswersTOF[qNum])
                {
                    case "T":
                        tRBtn.BackColor = Color.LightCoral;
                        break;
                    case "F":
                        fRBtn.BackColor = Color.LightCoral;
                        break;
                }
            }
        }

        private void resetHighlights()
        {
            aRBtn.UseVisualStyleBackColor = true;
            aRBtn.BackColor = default(Color);
            bRBtn.UseVisualStyleBackColor = true;
            bRBtn.BackColor = default(Color);
            cRBtn.UseVisualStyleBackColor = true;
            cRBtn.BackColor = default(Color);
            dRBtn.UseVisualStyleBackColor = true;
            dRBtn.BackColor = default(Color);
            tRBtn.UseVisualStyleBackColor = true;
            tRBtn.BackColor = default(Color);
            fRBtn.UseVisualStyleBackColor = true;
            fRBtn.BackColor = default(Color);
        }

        private void menuBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 main = new Form1();
            main.Show();
        }

        private void quizMCBtn_Click(object sender, EventArgs e)
        {
            menuBtn.Visible = false;
            quizMCBtn.Visible = false;
            quizTOFBtn.Visible = false;
            questionLbl.Visible = true;
            aRBtn.Visible = true;
            bRBtn.Visible = true;
            cRBtn.Visible = true;
            dRBtn.Visible = true;
            aRBtn.Enabled = true;
            bRBtn.Enabled = true;
            cRBtn.Enabled = true;
            dRBtn.Enabled = true;
            endQuizBtn.Visible = true;
            nextMCBtn.Visible = true;
            questionsMC();
        }

        private void quizTOFBtn_Click(object sender, EventArgs e)
        {
            menuBtn.Visible = false;
            quizMCBtn.Visible = false;
            quizTOFBtn.Visible = false;
            questionLbl.Visible = true;
            tRBtn.Visible = true;
            fRBtn.Visible = true;
            tRBtn.Enabled = true;
            fRBtn.Enabled = true;
            endQuizBtn.Visible = true;
            nextTOFBtn.Visible = true;
            questionsTOF();
        }

        private void endQuizBtn_Click(object sender, EventArgs e)
        {
            menuBtn.Visible = true;
            quizMCBtn.Visible = true;
            quizTOFBtn.Visible = true;
            questionLbl.Visible = false;
            aRBtn.Visible = false;
            bRBtn.Visible = false;
            cRBtn.Visible = false;
            dRBtn.Visible = false;
            tRBtn.Visible = false;
            fRBtn.Visible = false;
            endQuizBtn.Visible = false;
            nextMCBtn.Visible = false;
            finishMCBtn.Visible = false;
            qNum = 0;
        }

        private void aRBtn_CheckedChanged(object sender, EventArgs e)
        {
            userAnswersMC[qNum] = "A";
        }

        private void bRBtn_CheckedChanged(object sender, EventArgs e)
        {
            userAnswersMC[qNum] = "B";
        }

        private void cRBtn_CheckedChanged(object sender, EventArgs e)
        {
            userAnswersMC[qNum] = "C";
        }

        private void dRBtn_CheckedChanged(object sender, EventArgs e)
        {
            userAnswersMC[qNum] = "D";
        }

        private void tRBtn_CheckedChanged(object sender, EventArgs e)
        {
            userAnswersTOF[qNum] = "T";
        }

        private void fRBtn_CheckedChanged(object sender, EventArgs e)
        {
            userAnswersTOF[qNum] = "F";
        }

        private void nextMCBtn_Click(object sender, EventArgs e)
        {
            qNum++;
            questionsMC();
        }

        private void finishMCBtn_Click(object sender, EventArgs e)
        {
            menuBtn.Visible = true;
            aRBtn.Visible = false;
            bRBtn.Visible = false;
            cRBtn.Visible = false;
            dRBtn.Visible = false;
            aRBtn.Enabled = false;
            bRBtn.Enabled = false;
            cRBtn.Enabled = false;
            dRBtn.Enabled = false;
            endQuizBtn.Visible = false;
            finishMCBtn.Visible = false;
            nextResultMCBtn.Visible = true;
            checkAnsMC();
            qNum = 0;
        }

        private void nextResultMCBtn_Click(object sender, EventArgs e)
        {
            aRBtn.Visible = true;
            bRBtn.Visible = true;
            cRBtn.Visible = true;
            dRBtn.Visible = true;
            finishMCBtn.Visible = false;
            resultsMC();
            qNum++;
        }

        private void nextTOFBtn_Click(object sender, EventArgs e)
        {
            qNum++;
            questionsTOF();
        }

        private void finishTOFBtn_Click(object sender, EventArgs e)
        {
            menuBtn.Visible = true;
            tRBtn.Visible = false;
            fRBtn.Visible = false;
            tRBtn.Enabled = false;
            fRBtn.Enabled = false;
            endQuizBtn.Visible = false;
            finishTOFBtn.Visible = false;
            nextResultTOFBtn.Visible = true;
            checkAnsTOF();
            qNum = 0;
        }

        private void nextResultTOFBtn_Click(object sender, EventArgs e)
        {
            tRBtn.Visible = true;
            fRBtn.Visible = true;
            finishTOFBtn.Visible = false;
            resultsTOF();
            qNum++;
        }   
    }
}