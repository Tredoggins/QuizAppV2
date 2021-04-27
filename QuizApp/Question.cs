using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace QuizApp
{
    class Question
    {
        public Question(string question,string answer,string image)
        {
            this.MyQuestion = question;
            this.Answer = answer;
            this.Image = image;
        }
        public string MyQuestion { private set; get; }
        public string Answer { private set; get; }
        public string Image { private set; get; }
    }
}
