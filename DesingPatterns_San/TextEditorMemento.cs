using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns_San
{
    public class TextEditorMemento
    {
        internal string? content { get; }
        internal DateTime date_modified { get; }
        internal Guid user_modified { get; }

        public TextEditorMemento(string content, DateTime date_modified, Guid user_modified)
        {
            this.content = content;
            this.date_modified = date_modified;
            this.user_modified = user_modified;
        }
    }
}
