using System;
using System.Collections.Generic;
using System.Text;

namespace MovieListLab
{
    class Movie
    {
        private string _category;
        private string _title;

        public string Category
        {
            get { return _category; }
            set { this._category = value; }
        }

        public string Title
        {
            get { return _title; }
            set { this._title = value; }
        }

        public Movie(string category, string title)
        {
            this._category = category;
            this._title = title;
        }


       
        
        
    }
}
