using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternalTerminology
{
    public class Term
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        // Constructor
        public Term() 
        {
            Id = 0;
            Title = String.Empty;
            Description = String.Empty;
        }

        public Term(int id, string title, string description) 
        {
            Id = id;
            Title = title;
            Description = description;
        }

        public Term(int id)
        {
            // get row from db where ID = id
            // set Title and Descriton from row

        }

    }
}
