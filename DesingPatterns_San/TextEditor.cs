using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns_San
{
    public class TextEditor
    {
        public string? content { get; set; }
        public DateTime date_modified { get; set;  }
        public Guid user_modified { get; set; }



        public void Write(string content, DateTime date, Guid user)
        {
            this.content = content;
            this.date_modified = date;
            this.user_modified = user;
        }

        public TextEditorMemento Save()
        {
            return new TextEditorMemento(content, date_modified, user_modified);
        }

        public void Restore(TextEditorMemento memento)
        {
            this.content = memento.content;
            this.date_modified = memento.date_modified;
            this.user_modified = memento.user_modified;
        }

        public string GetContent()
        {
            return $"Content: {this.content} on {this.date_modified}";
        }
    }
}
