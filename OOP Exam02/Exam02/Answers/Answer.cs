﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    public class Answer
    {
        public int AnswerId { get; set; }
        public string? AnswerText { get; set; }
        public int AnswerMarks { get; set; }
        public Answer() { }

        public Answer(int id, string? text)
        {
            AnswerId = id;
            AnswerText = text;
        }
        public override string ToString()
        {
            return $"{AnswerId} => {AnswerText}";
        }
    }
}
