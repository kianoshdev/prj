using System;
using System.Collections.Generic;

namespace LamdaExpresion
{
    static class Program
    {
        // public class Movie
        // {
        //     public byte MovieId { get; set; }
        //     public string MovieName { get; set; }
        //     public Movie(byte MovieId, string MovieName)
        //     {
        //         this.MovieId = MovieId;
        //         this.MovieName = MovieName;
        //     }
        // }
        public class Quesyion
        {
            public int ID { get; set; }
            public int Sectionid { get; set; }      
            public string MyProperty { get; set; }
        }
        public class Exam
        {
            public List<Quesyion> lst { get; set; }
        }
        static void Main(string[] args)
        {
            // List<Movie> Mv = new List<Movie>(){ new Movie(1,"War"), new Movie(2,"Money")};
            // List<Movie> MvCountinu = new List<Movie>(){ new Movie(1,"Craft"), new Movie(2,"Heist")};

            // var result = Mv.Join(MvCountinu, e => e.MovieId, m => m.MovieId, (e,m) => new {Mvname = e.MovieName, Mvname1 = m.MovieName});
            // result.ToList().ForEach(m => System.Console.WriteLine(m.Mvname + m.Mvname1));

        }
    }
}
