using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    public class TextEditorHistory
    {
        private Stack<TextEditorMemento> history = new Stack<TextEditorMemento>();

        public void SaveState(TextEditor textEditor)
        {
            history.Push(textEditor.Save());
        }

        public void Undo(TextEditor textEditor)
        {
            if (history.Count > 1)
            {
                history.Pop();
                textEditor.Restore(history.Peek());
            }
        }
    }
}
