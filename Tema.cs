using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Appptteme
{
    internal class Tema
    {
        private int grade=1;
        private List<string> questions,answers;
        private List<int> correct_pos;
        private string title, description,status,tip;
        private string assigment_answer,comment;
        private DateTime start, deadline;
        int i, j,k,RAC;
        
        int sum;
        public Tema(string title,string description, DateTime start, DateTime deadline)
        {
            this.title = title;
            this.description = description;
            this.start = start;
            this.deadline = deadline;
            status = "neevaluat";
            tip = "assignment";
        }
        public int get_grade()
        {
            return grade;
        }
        public string get_status()
        {
            return status;
        }
        public string get_tip()
        {
            return tip;
        }
        public string get_comment()
        {
            return comment;
        }
        //public void Grade_Average(List<Tema> list)
        //{
        //    sum = 0;
        //    for (int i = 0; i < list.Count; i++) 
        //    {
        //        sum+= list[i].get_grade();
                

        //    }
        //    Console.WriteLine("media este: " + sum / list.Count);
        //}
        public void create_quiz(List<string> questions, List<string> answers,List<int>correct_pos)
        {
            this.questions = questions;
            this.answers = answers;
            this.correct_pos = correct_pos;
            tip = "quiz";

        }
        public void take_quiz()
        {
            k = 0;
            RAC = 0;
            if (DateTime.Today < deadline && DateTime.Today > start)
            {
                for (i = 0; i < questions.Count; i++)
                {

                    Console.WriteLine(questions[i]);
                    Console.WriteLine(answers[k]);
                    Console.WriteLine(answers[k + 1]);
                    Console.WriteLine(answers[k + 2]);
                    k += 3;
                    Console.WriteLine("insert answer: \n");
                    if (int.Parse(Console.ReadLine()) == correct_pos[i])
                    {
                        RAC++;
                    }
                }
                Console.WriteLine("quizul s-a terminat nota ta este: " + RAC*10/correct_pos.Count);
                grade = RAC;
                status = "evaluat";
            }
            else
            {
                Console.WriteLine("A expirat timpul/Nu a inceput taskul inca!");
            }
        }
        public void assigment()
        {
            if (DateTime.Today < deadline && DateTime.Today > start)
            {
                Console.WriteLine("Enter your response to the assigment as text: ");
                assigment_answer = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("A expirat timpul");
            }
        }
        public void revierw_assigment()
        {
            Console.WriteLine(assigment_answer);
            Console.WriteLine("Grade assigment: ");
            grade=int.Parse(Console.ReadLine());
            Console.WriteLine("Add Comment: ");
            comment =Console.ReadLine();
            status = "evaluat";
        }
        public override string ToString()
        {
            return ("title: " + title + "\n description: " + description + "\nstart: " + start + "\n deadline: " + deadline);
        }
        public void display_pt_prof()
        {
            
                Console.WriteLine(" title: " + title + "\n description: " + description + "\n start: " + start + "\n deadline: " + deadline + " \n nota: " + grade + "\n comentriu: " + comment);
            
        }
        //public void calculare_medie(List<Tema> teme)
        //{
        //    for(int j = 0; j < teme.Count; j++)
        //    {
        //        sum += teme[j].get_grade();
        //    }
        //    Console.WriteLine("Media este: " + sum / teme.Count);
        //}
    }
}
