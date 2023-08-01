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
using System.Diagnostics; // need this to output the dialogue box

namespace Spanish_Project
{
    public partial class EngToSp : Form
    {
        // question variables

        private int percentage;
        private int score;
        private int _currentQsNumber;
        private Question _currentQuestion;
        private int numOfQuestionsAsked = 0;
        private double totalPercentage = 0;


        private List<Question> _questions; // All fields written as _field, _score, _percenttage (we have to write it)

        public EngToSp()
        {
            InitializeComponent();

            _questions = new List<Question>
            {
                new Question()
                {
                    QuestionValue = new string[] { "my name is", "cesar" },
                    AnswerValue = new string[] { "Me llamo", "cesar" }
                    //index 0
                },
                new Question()
                {
                    QuestionValue = new string[] { "my", "favourite", "movie", "is", "toy story" },
                    AnswerValue = new string[] { "mi", "pelicula", "favorita", "es", "toy story" }
                    //index 1
                },
                new Question()
                {
                    QuestionValue = new string[] { "I", "love", "eating","chocolates" },
                    AnswerValue = new string[] { "Me", "encanta", "comer", "los chocolates" }
                    //index 2
                
                },
                new Question()
                {
                    QuestionValue = new string[] { "I want", "to go", "to", "England" },
                    AnswerValue = new string[] { "Quiero", "ir", "a", "Inglaterra" }
                    //index 3
                   
                },
                new Question()
                {
                    QuestionValue = new string[] { "I", "would like", "to go", "to", "spain" },
                    AnswerValue = new string[] { "Me", "Gustaria", "ir", "a", "Espana" }
                    //index 4
                 
                },
                new Question()
                {
                    QuestionValue = new string[] { "I will go", "to", "spain" },
                    AnswerValue = new string[] { "ire", "a", "Espana" }
                    //index 5
                  
                },
                new Question()
                {
                    QuestionValue = new string[] { "Maria", "has", "eaten", "her", "food" },
                    AnswerValue = new string[] { "Maria", "ha", "comido", "su", "comida" }
                    //index 6
                
                },
                new Question()
                {
                    QuestionValue = new string[] { "The", "boy", "who", "won", "is", "my", "brother" },
                    AnswerValue = new string[] { "el", "chico", "que", "gano", "es", "mi", "hermano" }
                    //index 7
                   
                },
                new Question()
                {
                    QuestionValue = new string[] {"John", "was", "playing", "the", "piano"},
                    AnswerValue = new string[] { "John", "estaba", "tocando", "el", "piano"}
                    //index 8

                },
                new Question()
                {
                    QuestionValue = new string[] { "it is", "good", "that", "he is", "tall"},
                    AnswerValue = new string[] { "es", "bueno", "que", "sea", "alto"}
                    //index 9
                   
                },
                 new Question()
                {
                    QuestionValue = new string[] { "Quiz", "Complete!"},
                    
                    //index 10
                   
                }
            };

            // Initialize for start
            _currentQsNumber = 5;
            _currentQuestion = _questions[_currentQsNumber];
            qsLbl.Text = _currentQuestion.ToString();

        }


        private void label1_Click(object sender, EventArgs e)
        {
            // nothing
        }

        private void qsLbl_Click(object sender, EventArgs e)
        {
            // nothing
        }

        class Question
        {
            public string[] QuestionValue { get; set; }

            public string[] AnswerValue { get; set; }

            public override string ToString() // When we use ToString with this class
                {
                    return string.Join(" ", QuestionValue); // turns into one sentence
                }
        }



        private void nxtBtn_click(object sender, EventArgs e)
        {
            // return if empty string in textbox
            if (userInpBox.Text == "")
                return; // if there is nothing inputted and user clicks next, the function will not be ran i.e it wont count it as an answer

        

        
            var usersAnswer = userInpBox.Text.Split(' ');

            foreach (var answerWord in _currentQuestion.AnswerValue)
            {
                foreach (var userAnswerWord in usersAnswer)
                {
                    if (answerWord.ToUpper() == userAnswerWord.ToUpper())
                    {
                        score++; //score for one sentence
                        
                    }

                }
                userInpBox.Clear();
                                 
            }
            numOfQuestionsAsked++; // counter increments for each question that has been asked and answered


            percentage = (int)Math.Round((double)(score * 100 ) / _currentQuestion.AnswerValue.Length);
            totalPercentage += percentage; // adds each questions percentage onto it
            score = 0;
            MessageBox.Show(percentage + "%");
            _questions.RemoveAt(_currentQsNumber);


            if (percentage < 70)
            {
                _currentQsNumber--;
            }
            
            _currentQuestion = _questions[_currentQsNumber];
            qsLbl.Text = _currentQuestion.ToString();
            if (numOfQuestionsAsked == 5)
            {
                MessageBox.Show("your average percentage is " + totalPercentage /5 + "%"); //outputs total percentage once program finishes
                DialogResult dialogResult = MessageBox.Show("Do you want to retry the exercise again?", "End of Game", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    _questions.Clear(); // questions from list are resetted 
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

    


