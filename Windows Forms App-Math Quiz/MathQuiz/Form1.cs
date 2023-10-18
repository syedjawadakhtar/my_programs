/*
 * Windows Form .NET application
 * Making a Math quiz in forms with audio on correct and wrond input of values.
 * Tutorial followed: https://learn.microsoft.com/en-us/visualstudio/get-started/csharp/tutorial-windows-forms-math-quiz-create-project-add-controls?view=vs-2022
 */

using System.Media;

namespace MathQuiz
{
    public partial class Form1 : Form
    {
        // Create a Random object called randomizer
        // To generate random numbers.
        Random randomizer = new();

        // These integer variables store the numbers
        // for the addition problem.
        int addend1, addend2;

        // These integer variables store the numbers 
        // for the subtraction problem. 
        int minuend;
        int subtrahend;

        // These integer variables store the numbers 
        // for the multiplication problem. 
        int multiplicand;
        int multiplier;

        // These integer variables store the numbers 
        // for the division problem. 
        int dividend;
        int divisor;

        // This integer variable keeps track of the
        // remaining time.
        int timeLeft;
        // Start the quiz by filling in all of the problems
        // and starting the timer.
        public void StartTheQuiz()
        {
            // Fill in the addition problem.
            // Generate two random numbers to add
            // Store the values in the variables 'addend1' and 'addend2'
            addend1 = randomizer.Next(51);
            addend2 = randomizer.Next(51);

            // Convert the two randomly generated numbers
            // into strings so that they can be displayed 
            // in the label controls.
            plusLeftLabel.Text = addend1.ToString();
            plusRightLabel.Text = addend2.ToString();

            // 'sum' is the name of the NumericUpDown control.
            // This step makes sure its value is zero before
            // adding any values to it.
            sum.Value = 0;

            // Fill in the subtraction problem.
            minuend = randomizer.Next(1, 101);
            subtrahend = randomizer.Next(1, minuend);
            minusLeftLabel.Text = minuend.ToString();
            minusRightLabel.Text = subtrahend.ToString();
            difference.Value = 0;

            // Fill in the multiplication problem.
            // When you give the Next() method two values,
            // it picks a random number that's greater than or
            // equal to the first value and less than the second one.
            multiplicand = randomizer.Next(2, 11);
            multiplier = randomizer.Next(2, 11);
            timesLeftLabel.Text = multiplicand.ToString();
            timesRightLabel.Text = multiplier.ToString();
            product.Value = 0;

            // Fill in the division problem.
            divisor = randomizer.Next(2, 11);
            int temporaryQuotient = randomizer.Next(2, 11);
            dividend = divisor * temporaryQuotient;
            dividedLeftLabel.Text = dividend.ToString();
            dividedRightLabel.Text = divisor.ToString();
            quotient.Value = 0;

            // Start the timer.
            timeLeft = 30;
            timeLabel.Text = "30 seconds";
            timer1.Start();
        }
        // Check the answers to see if the user got everything right
        private bool CheckTheAnswer()
        {
            if ((addend1 + addend2 == sum.Value)
                && (minuend - subtrahend == difference.Value)
                && (multiplicand * multiplier == product.Value)
                && (dividend / divisor == quotient.Value))
                return true;
            else
                return false;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            StartTheQuiz();
            startButton.Enabled = false;
        }
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (CheckTheAnswer())
            {
                // If CheckTheAnswer() returns true, then the user 
                // got the answer right. Stop the timer  
                // and show a MessageBox.
                timer1.Stop();
                MessageBox.Show("You got all the answers right!",
                                "Congratulations!");
                startButton.Enabled = true;
            }
            else if (timeLeft > 0)
            {
                // If CheckTheAnswer() returns false, keep counting
                // down. Decrease the time left by one second and 
                // display the new time left by updating the 
                // Time Left label.
                timeLeft = timeLeft - 1;
                timeLabel.Text = timeLeft + " seconds";
            }
            else
            {
                // If the user ran out of time, stop the timer, show
                // a MessageBox, and fill in the answers.
                timer1.Stop();
                timeLabel.Text = "Time's up!";
                MessageBox.Show("You didn't finish in time.", "Sorry!");
                sum.Value = addend1 + addend2;
                difference.Value = minuend - subtrahend;
                product.Value = multiplicand * multiplier;
                quotient.Value = dividend / divisor;
                startButton.Enabled = true;
            }
        }

        private void playWrongSound()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"d:\Downloads\negative_beeps-6008.wav");
            simpleSound.Play();
        }

        private void playCorrectSound()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"d:\Downloads\correct-2-46134.wav");
            simpleSound.Play();
        }

        private void sum_ValueChanged(object sender, EventArgs e)
        {
            if (addend1 + addend2 != sum.Value)
                playWrongSound();
            else
            {
                playCorrectSound();
            }
        }

        private void difference_ValueChanged(object sender, EventArgs e)
        {
            if (minuend - subtrahend != difference.Value)
                playWrongSound();
            else
            {
                playCorrectSound();
            }
        }

        private void product_ValueChanged(object sender, EventArgs e)
        {
            if (multiplicand * multiplier != product.Value)
                playWrongSound();
            else
            {
                playCorrectSound();
            }
        }

        private void quotient_ValueChanged(object sender, EventArgs e)
        {
            if (dividend / divisor != quotient.Value)
                playWrongSound();
            else
            {
                playCorrectSound();
            }
        }

        private void answer_Enter(object sender, EventArgs e)
        {
            // Select the whole answer in the NumericUpDown control.
            NumericUpDown answerBox = sender as NumericUpDown;

            if (answerBox != null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
        }
    }
}