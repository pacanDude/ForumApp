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
using System.Windows.Shapes;

namespace ForumApp
{
    /// <summary>
    /// Логика взаимодействия для CommentaryWindow.xaml
    /// </summary>
    public partial class CommentaryWindow : Window
    {
        public int ansverId;
        public string login;
        public CommentaryWindow(int ansverId, string login)
        {
            InitializeComponent();
            this.ansverId = ansverId;
            this.login = login;
        }
    }
}
