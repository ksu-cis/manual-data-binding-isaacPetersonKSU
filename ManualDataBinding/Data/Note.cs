using System;

namespace ManualDataBinding.Data
{
    /// <summary>
    /// A class representing a note
    /// </summary>
    public class Note
    {
        public event EventHandler NoteChanged;

        //private backing variables
        private string _title = DateTime.Now.ToString();
        private string _body = "";


        /// <summary>
        /// The title of the Note
        /// </summary>
        public string Title {
            get
            {
                return _title;
            }
            set
            {
                if(_title != value)
                {
                    _title = value;
                    NoteChanged?.Invoke(this, new EventArgs());
                }
            }
        }

        /// <summary>
        /// The text of the note
        /// </summary>
        public string Body {
            get
            {
                return _body;
            }
            set
            {
                if(_body != value)
                {
                    _body = value;
                    NoteChanged?.Invoke(this, new EventArgs());
                }
            }
        }
    }
}
