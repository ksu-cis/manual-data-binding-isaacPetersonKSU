using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

namespace ManualDataBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// note being viewed
        /// </summary>
        private Note _note = new Note();

        public MainWindow()
        {
            InitializeComponent();
            Editor.Note = _note;
        }

        /// <summary>
        /// event handler for when new button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnNewNote(object sender, RoutedEventArgs e)
        {
            _note = new Note();
            Editor.Note = _note;
        }

        /// <summary>
        /// event handler for when clear button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnClearNote(object sender, RoutedEventArgs e)
        {
            _note.Body = "";
        }

        /// <summary>
        /// Event for when the mutate button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnMutateNote(object sender, RoutedEventArgs e)
        {
            _note.Title = "Pickle Rick";
            _note.Body = "To be fair, you have to have a very high IQ to understand Rick and Morty." +
                "The humour is extremely subtle, and without a solid grasp of theoretical physics most " +
                "of the jokes will go over a typical viewer's head. There's also Rick's nihilistic " +
                "outlook, which is deftly woven into his characterisation- his personal philosophy " +
                "draws heavily from Narodnaya Volya literature, for instance. The fans understand this " +
                "stuff; they have the intellectual capacity to truly appreciate the depths of these " +
                "jokes, to realise that they're not just funny- they say something deep about LIFE. As " +
                "a consequence people who dislike Rick & Morty truly ARE idiots- of course they wouldn't " +
                "appreciate, for instance, the humour in Rick's existential catchphrase \"Wubba Lubba Dub Dub,\"" +
                "which itself is a cryptic reference to Turgenev's Russian epic Fathers and Sons. I'm " +
                "smirking right now just imagining one of those addlepated simpletons scratching their " +
                "heads in confusion as Dan Harmon's genius wit unfolds itself on their television screens. " +
                "What fools.. how I pity them. 😂\n\n" +

                "And yes, by the way, i DO have a Rick &Morty tattoo.And no, you cannot see it.It's for the " +
                "ladies' eyes only-and even then they have to demonstrate that they're within 5 IQ points " +
                "of my own (preferably lower) beforehand. Nothin personnel kid 😎";
        }
    }
}
