using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics; // need this for the dialog box 

namespace Spanish_Project
{
    public partial class SpotError : Form
    {

        private int STEscore;
        public int _currentQsNumberSTE;
        private STEQuestions _currentQuestionSTE;
        private int numOfQuestionsAskedSTE = 0; // sets the variable to zero so it can increment each time a questions been asked 


        private List<STEQuestions> errorList;

        public SpotError()
        {
            InitializeComponent();


            errorList = new List<STEQuestions> // initialising a list  
            {
                new STEQuestions()
                {
                    STEquest = new string[] {"La chico es muy guapo"},
                    
                },
                new STEQuestions()
                {
                    STEquest = new string[] {"Mi hermano juego mucho del futbol"}
                },
                new STEQuestions()
                {
                    STEquest = new string[] {"el lengua de espanol es muy dificil"}
                },
                new STEQuestions()
                {
                    STEquest= new string[] {"Esta programa es bastante util para mi estudios"}
                },
                new STEQuestions()
                {
                    STEquest= new string[] {"Voy a tomando un cafe dentro de 5 horas."}
                },
                new STEQuestions()
                {
                    STEquest= new string[] {"End of Quiz\nFin de Prueba"}
                }
            };
            _currentQsNumberSTE = 0; // this will set the first question to index 0
            numOfQuestionsAskedSTE++;
            _currentQuestionSTE = errorList[_currentQsNumberSTE]; // when current qs number iterates through the list the current question will be set to the question that the current qs number is on
            STElabel.Text = _currentQuestionSTE.ToString(); // convert the current question to string (again just incase something was to go wrong)
            if (_currentQsNumberSTE == 0) // the buttons will be assigned some text values on each question thats being asked. they need to correspond to the question
            {
                opt1btnSTE.Text = "La"; 
                opt2btnSTE.Text = "guapo";        // these options will correspond to the first question
                opt3btnSTE.Text = "es";
                opt4btnSTE.Text = "muy";
            }
            else if (_currentQsNumberSTE == 1)
            {
                opt1btnSTE.Text = "hermano";
                opt2btnSTE.Text = "juego";
                opt3btnSTE.Text = "del";
                opt4btnSTE.Text = "No error";
            }
            else if (_currentQsNumberSTE == 2)
            {
                opt1btnSTE.Text = "espanol";
                opt2btnSTE.Text = "muy";
                opt3btnSTE.Text = "el";
                opt4btnSTE.Text = "no error";
            }
            else if (_currentQsNumberSTE == 3)
            {
                opt1btnSTE.Text = "mi";
                opt2btnSTE.Text = "estudios";
                opt3btnSTE.Text = "programa";
                opt4btnSTE.Text = "No error";
            }
            else if (_currentQsNumberSTE == 4)
            {
                opt1btnSTE.Text = "Voy";
                opt2btnSTE.Text = " dentro";
                opt3btnSTE.Text = "horas";
                opt4btnSTE.Text = "tomando";
            }
            else if (_currentQsNumberSTE == 5)
            {
                  opt1btnSTE.Text = "";
                  opt2btnSTE.Text = "";
                  opt3btnSTE.Text = "";
                  opt4btnSTE.Text = "";
            }

            if (numOfQuestionsAskedSTE == 6)
            {
                DialogResult dialogResultSTE = MessageBox.Show("Do you want to retry the exercise again?", "End of Game", MessageBoxButtons.YesNo);
                if (dialogResultSTE == DialogResult.Yes)
                {
                    errorList.Clear(); // questions from list are resetted 
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
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        class STEQuestions
        {
            public string[] STEquest { get; set; }
            
            public override string ToString() //  joins the values in string array together (just incase anything goes wrong i have made them as string array)
            {
                return string.Join(" ", STEquest); // turns into one sentence
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            // question 0 and 3 

            if (_currentQsNumberSTE == 0 || _currentQsNumberSTE == 3)
            {

                STEscore++;
                MessageBox.Show($"Correct    Current Score:  {STEscore}/5");
            }
            else
            {

                MessageBox.Show($"Incorrect    Current Score: {STEscore}/5");
            }
            _currentQsNumberSTE++; //increments the index in list
            numOfQuestionsAskedSTE++; // increments after each question is asked. will be used for end 
            _currentQuestionSTE = errorList[_currentQsNumberSTE]; // sets the current question to the new question after it has been incremented 
            STElabel.Text = _currentQuestionSTE.ToString(); // new question is assigned to the label 
            if (_currentQsNumberSTE == 0) // the buttons will be assigned some text values on each question thats being asked. they need to correspond to the question
            {
                opt1btnSTE.Text = "La";
                opt2btnSTE.Text = "guapo";        // these options will correspond to the first question
                opt3btnSTE.Text = "es";
                opt4btnSTE.Text = "muy";
            }
            else if (_currentQsNumberSTE == 1)
            {
                opt1btnSTE.Text = "hermano";
                opt2btnSTE.Text = "juego";
                opt3btnSTE.Text = "del";
                opt4btnSTE.Text = "No error";
            }
            else if (_currentQsNumberSTE == 2)
            {
                opt1btnSTE.Text = "espanol";
                opt2btnSTE.Text = "muy";
                opt3btnSTE.Text = "el";
                opt4btnSTE.Text = "no error";
            }
            else if (_currentQsNumberSTE == 3)
            {
                opt1btnSTE.Text = "mi";
                opt2btnSTE.Text = "estudios";
                opt3btnSTE.Text = "programa";
                opt4btnSTE.Text = "No error";
            }
            else if (_currentQsNumberSTE == 4)
            {
                opt1btnSTE.Text = "Voy";
                opt2btnSTE.Text = " dentro";
                opt3btnSTE.Text = "horas";
                opt4btnSTE.Text = "tomando";
            }
            else if (_currentQsNumberSTE == 5)
            {
                opt1btnSTE.Text = "";
                opt2btnSTE.Text = "";
                opt3btnSTE.Text = "";
                opt4btnSTE.Text = "";
            }
            if (numOfQuestionsAskedSTE == 6)
            {
                DialogResult dialogResultSTE = MessageBox.Show("Do you want to retry the exercise again?", "End of Quiz", MessageBoxButtons.YesNo);
                if (dialogResultSTE == DialogResult.Yes)
                {
                    errorList.Clear(); // questions from list are resetted 
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
        private void button2_Click(object sender, EventArgs e)
        {
            //question 1   
            if (_currentQsNumberSTE == 1)
            {

                STEscore++;
                MessageBox.Show($"Correct    Current Score: {STEscore}/5");
            }
            else
            {

                MessageBox.Show($"Incorrect    Current Score: {STEscore}/5");
            }
            _currentQsNumberSTE++; //increments the index in list
            numOfQuestionsAskedSTE++; // increments after each question is asked. will be used for end 
            _currentQuestionSTE = errorList[_currentQsNumberSTE]; // sets the current question to the new question after it has been incremented 
            STElabel.Text = _currentQuestionSTE.ToString(); // new question is assigned to the label 
            if (_currentQsNumberSTE == 0) // the buttons will be assigned some text values on each question thats being asked. they need to correspond to the question
            {
                opt1btnSTE.Text = "La";
                opt2btnSTE.Text = "guapo";        // these options will correspond to the first question
                opt3btnSTE.Text = "es";
                opt4btnSTE.Text = "muy";
            }
            else if (_currentQsNumberSTE == 1)
            {
                opt1btnSTE.Text = "hermano";
                opt2btnSTE.Text = "juego";
                opt3btnSTE.Text = "del";
                opt4btnSTE.Text = "No error";
            }
            else if (_currentQsNumberSTE == 2)
            {
                opt1btnSTE.Text = "espanol";
                opt2btnSTE.Text = "muy";
                opt3btnSTE.Text = "el";
                opt4btnSTE.Text = "no error";
            }
            else if (_currentQsNumberSTE == 3)
            {
                opt1btnSTE.Text = "mi";
                opt2btnSTE.Text = "estudios";
                opt3btnSTE.Text = "programa";
                opt4btnSTE.Text = "No error";
            }
            else if (_currentQsNumberSTE == 4)
            {
                opt1btnSTE.Text = "Voy";
                opt2btnSTE.Text = " dentro";
                opt3btnSTE.Text = "horas";
                opt4btnSTE.Text = "tomando";
            }
            else if (_currentQsNumberSTE == 5)
            {
                opt1btnSTE.Text = "";
                opt2btnSTE.Text = "";
                opt3btnSTE.Text = "";
                opt4btnSTE.Text = "";
            }
            if (numOfQuestionsAskedSTE == 6)
            {
                DialogResult dialogResultSTE = MessageBox.Show("Do you want to retry the exercise again?", "End of Quiz", MessageBoxButtons.YesNo);
                if (dialogResultSTE == DialogResult.Yes)
                {
                    errorList.Clear(); // questions from list are resetted 
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

        private void button3_Click(object sender, EventArgs e)
        {
            //question 2
            if (_currentQsNumberSTE == 2)
            {

                STEscore++;
                MessageBox.Show($"Correct    Current Score:  {STEscore}/5");
            }
            else
            {

                MessageBox.Show($"Incorrect    Current Score: {STEscore}/5");
            }
            _currentQsNumberSTE++; //increments the index in list
            numOfQuestionsAskedSTE++; // increments after each question is asked. will be used for end 
            _currentQuestionSTE = errorList[_currentQsNumberSTE]; // sets the current question to the new question after it has been incremented 
            STElabel.Text = _currentQuestionSTE.ToString(); // new question is assigned to the label 
            if (_currentQsNumberSTE == 0) // the buttons will be assigned some text values on each question thats being asked. they need to correspond to the question
            {
                opt1btnSTE.Text = "La";
                opt2btnSTE.Text = "guapo";        // these options will correspond to the first question
                opt3btnSTE.Text = "es";
                opt4btnSTE.Text = "muy";
            }
            else if (_currentQsNumberSTE == 1)
            {
                opt1btnSTE.Text = "hermano";
                opt2btnSTE.Text = "juego";
                opt3btnSTE.Text = "del";
                opt4btnSTE.Text = "No error";
            }
            else if (_currentQsNumberSTE == 2)
            {
                opt1btnSTE.Text = "espanol";
                opt2btnSTE.Text = "muy";
                opt3btnSTE.Text = "el";
                opt4btnSTE.Text = "no error";
            }
            else if (_currentQsNumberSTE == 3)
            {
                opt1btnSTE.Text = "mi";
                opt2btnSTE.Text = "estudios";
                opt3btnSTE.Text = "programa";
                opt4btnSTE.Text = "No error";
            }
            else if (_currentQsNumberSTE == 4)
            {
                opt1btnSTE.Text = "Voy";
                opt2btnSTE.Text = " dentro";
                opt3btnSTE.Text = "horas";
                opt4btnSTE.Text = "tomando";
            }
            else if (_currentQsNumberSTE == 5)
            {
                opt1btnSTE.Text = "";
                opt2btnSTE.Text = "";
                opt3btnSTE.Text = "";
                opt4btnSTE.Text = "";
            }
            if (numOfQuestionsAskedSTE == 6)
            {
                DialogResult dialogResultSTE = MessageBox.Show("Do you want to retry the exercise again?", "End of Quiz", MessageBoxButtons.YesNo);
                if (dialogResultSTE == DialogResult.Yes)
                {
                    errorList.Clear(); // questions from list are resetted 
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

        private void button4_Click(object sender, EventArgs e)
        {
            //question 4
            if (_currentQsNumberSTE == 4)
            {

                STEscore++;
                MessageBox.Show($"Correct    Current Score:  {STEscore}/5");
            }
            else
            {
                
                MessageBox.Show($"Incorrect    Current Score: {STEscore}/5");
            }
            _currentQsNumberSTE++; //increments the index in list
            numOfQuestionsAskedSTE++; // increments after each question is asked. will be used for end 
            _currentQuestionSTE = errorList[_currentQsNumberSTE]; // sets the current question to the new question after it has been incremented 
            STElabel.Text = _currentQuestionSTE.ToString(); // new question is assigned to the label
            if (_currentQsNumberSTE == 0) // the buttons will be assigned some text values on each question thats being asked. they need to correspond to the question
            {
                opt1btnSTE.Text = "La";
                opt2btnSTE.Text = "guapo";        // these options will correspond to the first question
                opt3btnSTE.Text = "es";
                opt4btnSTE.Text = "muy";
            }
            else if (_currentQsNumberSTE == 1)
            {
                opt1btnSTE.Text = "hermano";
                opt2btnSTE.Text = "juego";
                opt3btnSTE.Text = "del";
                opt4btnSTE.Text = "No error";
            }
            else if (_currentQsNumberSTE == 2)
            {
                opt1btnSTE.Text = "espanol";
                opt2btnSTE.Text = "muy";
                opt3btnSTE.Text = "el";
                opt4btnSTE.Text = "no error";
            }
            else if (_currentQsNumberSTE == 3)
            {
                opt1btnSTE.Text = "mi";
                opt2btnSTE.Text = "estudios";
                opt3btnSTE.Text = "programa";
                opt4btnSTE.Text = "No error";
            }
            else if (_currentQsNumberSTE == 4)
            {
                opt1btnSTE.Text = "Voy";
                opt2btnSTE.Text = " dentro";
                opt3btnSTE.Text = "horas";
                opt4btnSTE.Text = "tomando";
            }
            else if (_currentQsNumberSTE == 5)
            {
                opt1btnSTE.Text = "";
                opt2btnSTE.Text = "";
                opt3btnSTE.Text = "";
                opt4btnSTE.Text = "";
            }
            if (numOfQuestionsAskedSTE == 6)
            {
                DialogResult dialogResultSTE = MessageBox.Show("Do you want to retry the exercise again?", "End of Quiz", MessageBoxButtons.YesNo);
                if (dialogResultSTE == DialogResult.Yes)
                {
                    errorList.Clear(); // questions from list are resetted 
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
