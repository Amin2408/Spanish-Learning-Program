using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spanish_Project
{
    public partial class FITB : Form
    {
        private int FITBscore;
        public int _currentQsNumberFITB;
        private FITBQuestions _currentQuestionFITB;
        private int numOfQuestionsAskedFITB = 0;


        private List<FITBQuestions> fillBlanksList;
        public FITB()
        {
            InitializeComponent();
            fillBlanksList = new List<FITBQuestions>
            {
                new FITBQuestions()
                {
                    FITBquest = new string[] {"El hombre ____ cafe"}, //toma

                },
                new FITBQuestions()
                {
                    FITBquest = new string[] {"Fumar no ____ bueno para ti"} //es
                },
                new FITBQuestions()
                {
                    FITBquest = new string[] {"La pantalla es muy ____"} //larga
                },
                new FITBQuestions()
                {
                    FITBquest= new string[] {"El chico ____ el te"}// detesta
                },
                new FITBQuestions()
                {
                    FITBquest= new string[] {"Comer ____ es muy bueno"}// bocadillos 
                },
                new FITBQuestions()
                {
                   FITBquest= new string[] {"End of Quiz\nFin de Prueba"}
                }
            };
            _currentQsNumberFITB = 0; // this will set the first question to index 0
            numOfQuestionsAskedFITB++;
            _currentQuestionFITB = fillBlanksList[_currentQsNumberFITB]; // when current qs number iterates through the list the current question will be set to the question that the current qs number is on
            FITBlbl.Text = _currentQuestionFITB.ToString(); // convert the current question to string (again just incase something was to go wrong)
            if (_currentQsNumberFITB == 0) // the buttons will be assigned some text values on each question thats being asked. they need to correspond to the question
            {
                FITBbtn1.Text = "Toma";
                FITBbtn2.Text = "gana";        // these options will correspond to the first question, answer is toma
                FITBbtn3.Text = "baila";
                FITBbtn4.Text = "muy";
            }
            else if (_currentQsNumberFITB == 1)
            {
                FITBbtn1.Text = "creo";
                FITBbtn2.Text = "es";
                FITBbtn3.Text = "jugar";
                FITBbtn4.Text = "comer";
            }
            else if (_currentQsNumberFITB == 2)
            {
                FITBbtn1.Text = "ganar";
                FITBbtn2.Text = "habla";
                FITBbtn3.Text = "larga";
                FITBbtn4.Text = "No error";
            }
            else if (_currentQsNumberFITB == 3)
            {
                FITBbtn1.Text = "detesta";
                FITBbtn2.Text = "crear";
                FITBbtn3.Text = "habla";
                FITBbtn4.Text = "No error";
            }
            else if (_currentQsNumberFITB == 4)
            {
                FITBbtn1.Text = "Voy";
                FITBbtn2.Text = " dentro";
                FITBbtn3.Text = "horas";
                FITBbtn4.Text = "bocadillos";
            }
            else if (_currentQsNumberFITB == 5)
            {
                FITBbtn1.Text = "";
                FITBbtn2.Text = "";
                FITBbtn3.Text = "";
                FITBbtn4.Text = "";
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }
        class FITBQuestions
        {
            public string[] FITBquest { get; set; }

            public override string ToString() //  joins the values in string array together (just incase anything goes wrong i have made them as string array)
            {
                return string.Join(" ", FITBquest); // turns into one sentence
            }
        }

        private void FITBbtn1_Click(object sender, EventArgs e)
        {
            // question 0 and 3 

            if (_currentQsNumberFITB == 0 || _currentQsNumberFITB == 3)
            {

                FITBscore++;
                MessageBox.Show($"Correct    Current Score:  {FITBscore}/5");
            }
            else
            {

                MessageBox.Show($"Incorrect    Current Score: {FITBscore}/5");
            }
            _currentQsNumberFITB++; //increments the index in list
            numOfQuestionsAskedFITB++; // increments after each question is asked. will be used for end 
            _currentQuestionFITB = fillBlanksList[_currentQsNumberFITB]; // sets the current question to the new question after it has been incremented 
            FITBlbl.Text = _currentQuestionFITB.ToString(); // new question is assigned to the label 
            if (_currentQsNumberFITB == 0) // the buttons will be assigned some text values on each question thats being asked. they need to correspond to the question
            {
                FITBbtn1.Text = "Toma";
                FITBbtn2.Text = "gana";        // these options will correspond to the first question, answer is toma
                FITBbtn3.Text = "baila";
                FITBbtn4.Text = "muy";
            }
            else if (_currentQsNumberFITB == 1)
            {
                FITBbtn1.Text = "creo";
                FITBbtn2.Text = "es";
                FITBbtn3.Text = "jugar";
                FITBbtn4.Text = "comer";
            }
            else if (_currentQsNumberFITB == 2)
            {
                FITBbtn1.Text = "ganar";
                FITBbtn2.Text = "habla";
                FITBbtn3.Text = "larga";
                FITBbtn4.Text = "No error";
            }
            else if (_currentQsNumberFITB == 3)
            {
                FITBbtn1.Text = "detesta";
                FITBbtn2.Text = "crear";
                FITBbtn3.Text = "habla";
                FITBbtn4.Text = "No error";
            }
            else if (_currentQsNumberFITB == 4)
            {
                FITBbtn1.Text = "Voy";
                FITBbtn2.Text = " dentro";
                FITBbtn3.Text = "horas";
                FITBbtn4.Text = "bocadillos";
            }
            else if (_currentQsNumberFITB == 5)
            {
                FITBbtn1.Text = "";
                FITBbtn2.Text = "";
                FITBbtn3.Text = "";
                FITBbtn4.Text = "";
            }
            if (numOfQuestionsAskedFITB == 6)
            {
                DialogResult dialogResultSTE = MessageBox.Show("Do you want to retry the exercise again?", "End of Quiz", MessageBoxButtons.YesNo);
                if (dialogResultSTE == DialogResult.Yes)
                {
                    fillBlanksList.Clear(); // questions from list are resetted 
                    this.Close(); //once the second form is closed, this form will be closed with it.
                    SpotError spErr = new SpotError(); // creates a new instance of the form 
                    spErr.ShowDialog();

                }
                else if (dialogResultSTE == DialogResult.No)
                {
                    this.Close(); // closes the form if user choses no from dialogue box
                }
            }
        }

        private void FITBbtn2_Click(object sender, EventArgs e)

        {
            if (_currentQsNumberFITB == 1) // question 1
            {

                FITBscore++;
                MessageBox.Show($"Correct    Current Score:  {FITBscore}/5");
            }
            else
            {

                MessageBox.Show($"Incorrect    Current Score: {FITBscore}/5");
            }
            _currentQsNumberFITB++; //increments the index in list
            numOfQuestionsAskedFITB++; // increments after each question is asked. will be used for end 
            _currentQuestionFITB = fillBlanksList[_currentQsNumberFITB]; // sets the current question to the new question after it has been incremented 
            FITBlbl.Text = _currentQuestionFITB.ToString(); // new question is assigned to the label 
            if (_currentQsNumberFITB == 0) // the buttons will be assigned some text values on each question thats being asked. they need to correspond to the question
            {
                FITBbtn1.Text = "Toma";
                FITBbtn2.Text = "gana";        // these options will correspond to the first question, answer is toma
                FITBbtn3.Text = "baila";
                FITBbtn4.Text = "muy";
            }
            else if (_currentQsNumberFITB == 1)
            {
                FITBbtn1.Text = "creo";
                FITBbtn2.Text = "es";
                FITBbtn3.Text = "jugar";
                FITBbtn4.Text = "comer";
            }
            else if (_currentQsNumberFITB == 2)
            {
                FITBbtn1.Text = "ganar";
                FITBbtn2.Text = "habla";
                FITBbtn3.Text = "larga";
                FITBbtn4.Text = "No error";
            }
            else if (_currentQsNumberFITB == 3)
            {
                FITBbtn1.Text = "detesta";
                FITBbtn2.Text = "crear";
                FITBbtn3.Text = "habla";
                FITBbtn4.Text = "No error";
            }
            else if (_currentQsNumberFITB == 4)
            {
                FITBbtn1.Text = "Voy";
                FITBbtn2.Text = " dentro";
                FITBbtn3.Text = "horas";
                FITBbtn4.Text = "bocadillos";
            }
            else if (_currentQsNumberFITB == 5)
            {
                FITBbtn1.Text = "";
                FITBbtn2.Text = "";
                FITBbtn3.Text = "";
                FITBbtn4.Text = "";
            }
            if (numOfQuestionsAskedFITB == 6)
            {
                DialogResult dialogResultSTE = MessageBox.Show("Do you want to retry the exercise again?", "End of Quiz", MessageBoxButtons.YesNo);
                if (dialogResultSTE == DialogResult.Yes)
                {
                    fillBlanksList.Clear(); // questions from list are resetted 
                    this.Close(); //once the second form is closed, this form will be closed with it.
                    SpotError spErr = new SpotError(); // creates a new instance of the form 
                    spErr.ShowDialog();

                }
                else if (dialogResultSTE == DialogResult.No)
                {
                    this.Close(); // closes the form if user choses no from dialogue box
                }
            }
        }

        private void FITBbtn3_Click(object sender, EventArgs e)
        {
            if (_currentQsNumberFITB == 2) //Question 2
            {

                FITBscore++;
                MessageBox.Show($"Correct    Current Score:  {FITBscore}/5");
            }
            else
            {

                MessageBox.Show($"Incorrect    Current Score: {FITBscore}/5");
            }
            _currentQsNumberFITB++; //increments the index in list
            numOfQuestionsAskedFITB++; // increments after each question is asked. will be used for end 
            _currentQuestionFITB = fillBlanksList[_currentQsNumberFITB]; // sets the current question to the new question after it has been incremented 
            FITBlbl.Text = _currentQuestionFITB.ToString(); // new question is assigned to the label 
            if (_currentQsNumberFITB == 0) // the buttons will be assigned some text values on each question thats being asked. they need to correspond to the question
            {
                FITBbtn1.Text = "Toma";
                FITBbtn2.Text = "gana";        // these options will correspond to the first question, answer is toma
                FITBbtn3.Text = "baila";
                FITBbtn4.Text = "muy";
            }
            else if (_currentQsNumberFITB == 1)
            {
                FITBbtn1.Text = "creo";
                FITBbtn2.Text = "es";
                FITBbtn3.Text = "jugar";
                FITBbtn4.Text = "comer";
            }
            else if (_currentQsNumberFITB == 2)
            {
                FITBbtn1.Text = "ganar";
                FITBbtn2.Text = "habla";
                FITBbtn3.Text = "larga";
                FITBbtn4.Text = "No error";
            }
            else if (_currentQsNumberFITB == 3)
            {
                FITBbtn1.Text = "detesta";
                FITBbtn2.Text = "crear";
                FITBbtn3.Text = "habla";
                FITBbtn4.Text = "No error";
            }
            else if (_currentQsNumberFITB == 4)
            {
                FITBbtn1.Text = "Voy";
                FITBbtn2.Text = " dentro";
                FITBbtn3.Text = "horas";
                FITBbtn4.Text = "bocadillos";
            }
            else if (_currentQsNumberFITB == 5)
            {
                FITBbtn1.Text = "";
                FITBbtn2.Text = "";
                FITBbtn3.Text = "";
                FITBbtn4.Text = "";
            }
            if (numOfQuestionsAskedFITB == 6)
            {
                DialogResult dialogResultSTE = MessageBox.Show("Do you want to retry the exercise again?", "End of Quiz", MessageBoxButtons.YesNo);
                if (dialogResultSTE == DialogResult.Yes)
                {
                    fillBlanksList.Clear(); // questions from list are resetted 
                    this.Close(); //once the second form is closed, this form will be closed with it.
                    SpotError spErr = new SpotError(); // creates a new instance of the form 
                    spErr.ShowDialog();

                }
                else if (dialogResultSTE == DialogResult.No)
                {
                    this.Close(); // closes the form if user choses no from dialogue box
                }
            }
        }

        private void FITBbtn4_Click(object sender, EventArgs e)
        {
            if (_currentQsNumberFITB == 4) // question 4
            {

                FITBscore++;
                MessageBox.Show($"Correct    Current Score:  {FITBscore}/5");
            }
            else
            {

                MessageBox.Show($"Incorrect    Current Score: {FITBscore}/5");
            }
            _currentQsNumberFITB++; //increments the index in list
            numOfQuestionsAskedFITB++; // increments after each question is asked. will be used for end 
            _currentQuestionFITB = fillBlanksList[_currentQsNumberFITB]; // sets the current question to the new question after it has been incremented 
            FITBlbl.Text = _currentQuestionFITB.ToString(); // new question is assigned to the label 
            if (_currentQsNumberFITB == 0) // the buttons will be assigned some text values on each question thats being asked. they need to correspond to the question
            {
                FITBbtn1.Text = "Toma";
                FITBbtn2.Text = "gana";        // these options will correspond to the first question, answer is toma
                FITBbtn3.Text = "baila";
                FITBbtn4.Text = "muy";
            }
            else if (_currentQsNumberFITB == 1)
            {
                FITBbtn1.Text = "creo";
                FITBbtn2.Text = "es";
                FITBbtn3.Text = "jugar";
                FITBbtn4.Text = "comer";
            }
            else if (_currentQsNumberFITB == 2)
            {
                FITBbtn1.Text = "ganar";
                FITBbtn2.Text = "habla";
                FITBbtn3.Text = "larga";
                FITBbtn4.Text = "No error";
            }
            else if (_currentQsNumberFITB == 3)
            {
                FITBbtn1.Text = "detesta";
                FITBbtn2.Text = "crear";
                FITBbtn3.Text = "habla";
                FITBbtn4.Text = "No error";
            }
            else if (_currentQsNumberFITB == 4)
            {
                FITBbtn1.Text = "Voy";
                FITBbtn2.Text = " dentro";
                FITBbtn3.Text = "horas";
                FITBbtn4.Text = "bocadillos";
            }
            else if (_currentQsNumberFITB == 5)
            {
                FITBbtn1.Text = "";
                FITBbtn2.Text = "";
                FITBbtn3.Text = "";
                FITBbtn4.Text = "";
            }
            if (numOfQuestionsAskedFITB == 6)
            {
                DialogResult dialogResultSTE = MessageBox.Show("Do you want to retry the exercise again?", "End of Quiz", MessageBoxButtons.YesNo);
                if (dialogResultSTE == DialogResult.Yes)
                {
                    fillBlanksList.Clear(); // questions from list are resetted 
                    this.Close(); //once the second form is closed, this form will be closed with it.
                    SpotError spErr = new SpotError(); // creates a new instance of the form 
                    spErr.ShowDialog();

                }
                else if (dialogResultSTE == DialogResult.No)
                {
                    this.Close(); // closes the form if user choses no from dialogue box
                }
            }
        }
    }



  

    
    
}
