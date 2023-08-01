using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting;
using System.Diagnostics;

namespace Spanish_Project
{
    public partial class SpToEng : Form
    {
        // question variables

        private int percentageSP;
        private int scoreSP;
        private int _currentQsNumberSP;
        private QuestionSP _currentQuestionSP;
        private int numOfQuestionsAskedSP = 0;
        private double totalPercentageSP = 0;

        private List<QuestionSP> _questionsSP; 


        int numberOfWordsCorrectSP = 0;
        int totalNumberOfWordsSP = 0;

        // it is 1 class in runtime, it is for use 2 files one class.


        public SpToEng()
        {
            InitializeComponent();

            _questionsSP = new List<QuestionSP>
            {
                new QuestionSP()
                {
                    QuestionValue = new string[] { "me llamo", "Ben" },
                    AnswerValue = new string[] { "my", "name", "is", "Ben" }
                    //index 0
                },
                new QuestionSP()
                {
                    QuestionValue = new string[] { "me encanta", "ver", "las peliculas", "en mi", "tiempo libre" },
                    AnswerValue = new string[] { "i", "love", "to", "watch", "movies", "in" , "my", "free", "time" }
                    //index 1
                },
                new QuestionSP()
                {
                    QuestionValue = new string[] { "me encantaria", "ser", "un","fubolista" },
                    AnswerValue = new string[] { "i",  "would", "love", "to", "be", "a", "footballer" }
                    //index 2
                
                },
                new QuestionSP()
                {
                    QuestionValue = new string[] { "los", "dulces", "son", "muy", "deliciosos" },
                    AnswerValue = new string[] { "the", "sweets", "are", "very", "delicious"}
                    //index 3
                   
                },
                new QuestionSP()
                {
                    QuestionValue = new string[] { "el", "hombre", "que", "esta", "alli", "es", "mi", "padre" },
                    AnswerValue = new string[] { "the", "man", "who", "is", "over", "there", "is", "my", "dad" }
                    //index 4
                 
                },
                new QuestionSP()
                {
                    QuestionValue = new string[] { "el baloncesto", "es", "probablamente", "mi", "deporte", "favorito" },
                    AnswerValue = new string[] { "basketball", "is", "probably", "my", "favourite", "sport"}
                    //index 5
                  
                },
                new QuestionSP()
                {
                    QuestionValue = new string[] { "he", "hablado", "con", "tu", "profesor", "y", "no", "esta", "impresionado" },
                    AnswerValue = new string[] { "i", "have", "spoken", "with", "your", "teacher", "and", "he" ,"is", "not", "impressed" }
                    //index 6
                
                },
                new QuestionSP()
                {
                    QuestionValue = new string[] { "lo que", "me da miedo", "es", "la serpiente", "alli"},
                    AnswerValue = new string[] { "what", "scares","me", "is", "the", "snake", "over", "there" }
                    //index 7
                   
                },
                new QuestionSP()
                {
                    QuestionValue = new string[] { "Franco", "era", "un", "hombre", "muy", "machista" },
                    AnswerValue = new string[] { "Franco", "was", "a", "very", "machist", "man" }
                    //index 8

                },
                new QuestionSP()
                {
                    QuestionValue = new string[] { "Ganar", "el", "mundial", "es", "absolutamente", "fenomenal"},
                    AnswerValue = new string[] { "winning", "the", "world", "cup", "is", "absolutely", "phenomenal" }
                    //index 9
                   
                },
                 new QuestionSP()
                {
                    QuestionValue = new string[] { "Quiz", "Complete!"},
                    
                    //index 10
                   
                }
            };

            // Initialize for start
            _currentQsNumberSP = 5;
            _currentQuestionSP = _questionsSP[_currentQsNumberSP];
            qsLbl2.Text = _currentQuestionSP.ToString();

        }


        

        class QuestionSP
        {
            public string[] QuestionValue { get; set; }

            public string[] AnswerValue { get; set; }

            public override string ToString() // When we use ToString with this class
            {
                return string.Join(" ", QuestionValue); // turns into one sentence
            }
        }
       

        private void nextQs2_Click_1(object sender, EventArgs e)
        {
            
                // return if empty string in textbox
                if (textBox1.Text == "")
                    return; // if there is nothing inputted and user clicks next, the function will not be ran i.e it wont count it as an answer




                var usersAnswer = textBox1.Text.Split(' ');

                foreach (var answerWord in _currentQuestionSP.AnswerValue)
                {
                    foreach (var userAnswerWord in usersAnswer)
                    {
                        if (answerWord.ToUpper() == userAnswerWord.ToUpper())
                        {
                            scoreSP++; //score for one sentence

                        }

                    }
                    textBox1.Clear();

                }
                numOfQuestionsAskedSP++; // counter increments for each question that has been asked and answered


                percentageSP = (int)Math.Round((double)(scoreSP * 100) / _currentQuestionSP.AnswerValue.Length);
                totalPercentageSP += percentageSP; // adds each questions percentage onto it
                scoreSP = 0;
                MessageBox.Show(percentageSP + "%");
                _questionsSP.RemoveAt(_currentQsNumberSP);


                if (percentageSP < 70)
                {
                    _currentQsNumberSP--;
                }

                _currentQuestionSP = _questionsSP[_currentQsNumberSP];
                qsLbl2.Text = _currentQuestionSP.ToString();
                if (numOfQuestionsAskedSP == 5)
                {
                    MessageBox.Show("your average percentage is " + totalPercentageSP / 5 + "%"); //outputs total percentage once program finishes
                    DialogResult dialogResult = MessageBox.Show("Do you want to retry the exercise again?", "End of Game", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        _questionsSP.Clear(); // questions from list are resetted 
                        this.Close(); //once the second form is closed, this form will be closed with it.
                        EngToSp e2s = new EngToSp(); // creates a new instance of the form 
                        e2s.ShowDialog();

                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        this.Close(); // closes the form if user choses no from dialogue box
                    }
                }
            
        }
    }
}




