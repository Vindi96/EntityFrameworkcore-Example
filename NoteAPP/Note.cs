using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace NoteAPP
{
    [Table("TableNote")]
   internal class Note
    {
        public int ID { get; set; }
        [Column("Title")]
        public String Title { get; set; }
        [Column("Content")]
        public String Content { get; set; }
        [Column("AuthorFirstName")]
        public String firstname { get; set; }
        [Column("AuthorLastName")]
        public String lastName { get; set; }
        


    }
}
