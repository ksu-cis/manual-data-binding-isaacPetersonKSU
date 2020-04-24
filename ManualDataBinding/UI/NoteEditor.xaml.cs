using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ManualDataBinding.Data;

namespace ManualDataBinding.UI
{
    /// <summary>
    /// Interaction logic for NoteEditor.xaml
    /// </summary>
    public partial class NoteEditor : UserControl
    {
        private Note _note;

        /// <summary>
        /// not getting edited
        /// </summary>
        public Note Note {
            get
            {
                return _note;
            }
            set
            {
                if (_note != null) _note.NoteChanged -= OnNoteChange;
                _note = value;
                if (_note != null)_note.NoteChanged += OnNoteChange;
                OnNoteChange(Note, new EventArgs());
            }
        }

        public NoteEditor()
        {
            InitializeComponent();
        }

        /// <summary>
        /// event handler for when the note gets changed
        /// </summary>
        public void OnNoteChange(object sender, EventArgs e)
        {
            if (Note != null)
            {
                Title.Text = Note.Title;
                Body.Text = Note.Body; 
            } 
        }
    }
}
