using System;
using System.Collections.Generic;
using System.Text;

namespace NoteAPP
{
    internal interface INoteRepo
    {
        Note Create(String Title, String Content, String FirstName, String LastName);
        Note Update(Note note);
        void Delete(Note note);

    }
}
