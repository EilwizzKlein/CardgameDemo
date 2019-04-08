using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.script.Manager
{
    public class CircleLink<T>
    {
        private class LinkNote<T> {
            public T CurrentNote;
            public LinkNote<T> NextNote;
            public LinkNote<T> PreNote;

            public LinkNote()
            {
            }
        }
        

        private LinkNote<T> Note;
        public int count = 0;

        public CircleLink()
        {
            Note = new LinkNote<T>();
        }

        public T getT() {
            if (this.count == 0) {
                return default(T);
            }
            else
            {
                return Note.CurrentNote;

            }
        }

        public int Add(T NewNote) {
             LinkNote<T> CurrenteNote = new LinkNote<T>();
            CurrenteNote.CurrentNote = NewNote;
            if (Note.CurrentNote == null || count == 0)
            {
                CurrenteNote.NextNote = CurrenteNote;
                CurrenteNote.PreNote = CurrenteNote;
                Note = CurrenteNote;
            }
            else {
                Note.NextNote.PreNote = CurrenteNote;
                CurrenteNote.NextNote = Note.NextNote;
                Note.NextNote = CurrenteNote;
                CurrenteNote.PreNote = Note;

            }
            count = count + 1;
            return count;
        }

        public int Delete() {
            if (count == 0) {
                throw new Exception("链表为空,无法删除");
            }
            if (count == 1)
            {
                Note = new LinkNote<T>();
            }
            else {
                Note.PreNote.NextNote = Note.NextNote;
                Note.NextNote.PreNote = Note.PreNote;
                Note = Note.NextNote;

            }
            count = count - 1;
            return count;
        }

        public T Next() {
            if (count == 0)
            {
                return default(T);
            }
            else {
                Note = Note.NextNote;
                return Note.CurrentNote;
            }
        }

        public T Previous()
        {
            if (count == 0)
            {
                return default(T);
            }
            else
            {
                Note = Note.PreNote;
                return Note.CurrentNote;
            }
        }
    }


}
