using System;
using System.Collections.Generic;
using System.Text;

namespace NoteAPP
{
    class NoteRepo : INoteRepo
    {
        private readonly NoteContext noteContext;
        public NoteRepo(NoteContext noteContext)
        {
            this.noteContext = noteContext;

        }
        public Note Create(string Title,
            string Content, 
            string FirstName, 
            string LastName)
        {
            var response= noteContext.Add(new Note {Title=Title,
                Content=Content,
                firstname=FirstName,
                lastName=LastName });

            noteContext.SaveChanges();
            return response.Entity;
           
        }

        public void Delete(Note note)
        {
            noteContext.Remove(note);
            noteContext.SaveChanges();
        }

        public Note Update(Note note)
        {
            var response=noteContext.Update(note);
            noteContext.SaveChanges();
            return response.Entity;
        }
    }
}
