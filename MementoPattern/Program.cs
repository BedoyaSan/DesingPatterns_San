// Memento pattern, kinda like undo/redo functionality

using MementoPattern;

TextEditor textEditor = new TextEditor();

TextEditorHistory history = new TextEditorHistory();

textEditor.Write("First edition of this content", DateTime.UtcNow, Guid.NewGuid());
history.SaveState(textEditor);

textEditor.Write("Second edition of this content", DateTime.UtcNow, Guid.NewGuid());
history.SaveState(textEditor);

textEditor.Write("Last edition of this content", DateTime.UtcNow, Guid.NewGuid());
history.SaveState(textEditor);

history.Undo(textEditor);

Console.WriteLine(textEditor.GetContent());
