using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace QuizApp
{
    public partial class MainPage : ContentPage
    {
        List<Question> Questions { get; set; }
        public int NumCorrect { get; private set; }
        int Current { get; set; }
        public MainPage()
        {
            InitializeComponent();
            Questions = new List<Question> {
                new Question("The Sky Is Blue","Right","cumuluscloud.jpg"),
                new Question("This Class is Fun","Right",""),
                new Question("Question 1 was False","Left",""),
                new Question("Matt Green is a Great Teacher","Right","mattgreen.jpg"),
                new Question("Question 4 was False","Left","")
            };
            Current = 0;
            text.Text = Questions[0].MyQuestion;
            image.Source = Questions[0].Image;
            NumCorrect = 0;
        }
        async void OnButtonClicked(object sender, EventArgs args)
        {
            if (((Button)sender).Text=="True")
            {
                if (Questions[Current].Answer == "right")
                {
                    NumCorrect++;
                }
            }
            else
            {
                if (Questions[Current].Answer == "left")
                {
                    NumCorrect++;
                }
            }
            NextQuestion();
        }
        private void NextQuestion()
        {
            if (Current < Questions.Count - 1)
            {
                Current++;
                text.Text = Questions[Current].MyQuestion;
                image.Source = Questions[Current].Image;
            }
            else
            {
                b1.IsVisible = false;
                b2.IsVisible = false;
                text.Text = "You Got " + NumCorrect + "/" + Questions.Count;
            }
        }

        void OnSwiped(object sender, SwipedEventArgs e)
        {
            if (e.Direction.ToString() == Questions[Current].Answer)
            {
                NumCorrect++;
            }
            NextQuestion();
        }
    }
}
