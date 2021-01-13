using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NoteAPP
{
    internal class NoteProvider : INoteProvider
    {
        private readonly NoteContext noteContext;

        public NoteProvider(NoteContext noteContext)
        {
            this.noteContext = noteContext;
        }
        public Note Get(int id)
        {
           return noteContext.Notes.Where(n => n.ID == id).FirstOrDefault();
        }
    }
}
