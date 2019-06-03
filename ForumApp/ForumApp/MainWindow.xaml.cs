using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using ForumApp.ServiceReference1;
using окна;
using ВопросОтвет;

namespace ForumApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<QweryX> qweries = new ObservableCollection<QweryX>();
        ForumServiceClient forumServiceClient = new ForumServiceClient();
        public MainWindow()
        {
            InitializeComponent();
            

            foreach (var item in forumServiceClient.GetCategoryList())
            {
                ListViewItem listViewItem = new ListViewItem() { Content = item };
                listViewItem.MouseDoubleClick += ListViewItem_MouseDown;
                listCat.Items.Add(listViewItem);
            }
            foreach (var item in forumServiceClient.GetQweryList())
            {
                qweries.Add(item);
            }
            this.DataContext = qweries;
        }

        private void ListViewItem_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ListViewItem listViewItem = (ListViewItem)sender;
            qweries.Clear();
            foreach (var item in forumServiceClient.GetCategoryQweryList((string)listViewItem.Content))
            {
                qweries.Add(item);
            }
        }

        private void TextBox_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (((TextBox)sender).Text == "Search")
            {
                ((TextBox)sender).Text = String.Empty;
            }
        }

        
        private void TextBox_TextInput(object sender, TextCompositionEventArgs e)
        {
            
        }
        private void TextBox_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.Key != System.Windows.Input.Key.Enter) return;
            // your event handler here
            e.Handled = true;
            qweries.Clear();
            foreach (var item in forumServiceClient.GetFindQweryList(SearchBox.Text))
            {
                qweries.Add(item);
            }
        }

        private void TabItem_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (e.MiddleButton == MouseButtonState.Pressed)
                MainTabControl.Items.Remove(sender);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
        }

        RegistrationWindow registrationWindow;
        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TextBlock textBlock = (TextBlock)sender;
            registrationWindow = new RegistrationWindow();
            registrationWindow.Show();
            OneUserX userX = forumServiceClient.GetOneUser((string)textBlock.Text);
            registrationWindow.nameTextBox.Text = userX.name;
            registrationWindow.nameTextBox.IsReadOnly = true;
            registrationWindow.passwordBox.Visibility = Visibility.Hidden;
            registrationWindow.aboutSelfTextBox.Text = userX.about;
            registrationWindow.aboutSelfTextBox.IsReadOnly = true;
            registrationWindow.confirmPasswordBox.Visibility = Visibility.Hidden;
        }

        private void TextBlock_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            //List<AnsverX> list = forumServiceClient.GetQweryWithAnsvers((int)((TextBlock)sender).Tag).answers;
            AllMessageAndQwery list = forumServiceClient.GetQweryWithAnsvers((int)((TextBlock)sender).Tag);
            
            foreach (var item in list.answers)
            {
                TabItem tabItem = new TabItem() { Header = item.text };
                Grid grid = new Grid();
                ScrollViewer scrollViewer = new ScrollViewer() { CanContentScroll = true, HorizontalScrollBarVisibility = ScrollBarVisibility.Auto, VerticalScrollBarVisibility = ScrollBarVisibility.Auto, Margin = new Thickness(50, 200, 50, 50) };



                ListView listView = new ListView() { Style = (Style)Resources["ListViewStyle"] };
                //listView.ItemsSource = item;
                scrollViewer.Content = listView;
                grid.Children.Add(scrollViewer);

                tabItem.Content = grid;
                tabItem.MouseDown += TabItem_MouseUp;
                MainTabControl.Items.Add(tabItem);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            qweries.Clear();
            foreach (var item in forumServiceClient.GetFindQweryList(SearchBox.Text))
            {
                qweries.Add(item);
            }
        }
        LoginWindow form1;
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            form1 = new LoginWindow();
            form1.Show();
            form1.buttonOk.Click += ButtonOk_Click1;
        }

        string login;
        private void ButtonOk_Click1(object sender, RoutedEventArgs e)
        {
            
            bool a = forumServiceClient.LogIn(form1.nicknameTextBox.Text, form1.passwordBox.Password);
            if (a == true)
            {
                login = form1.nicknameTextBox.Text;
                Name.IsEnabled = true;
                Log.Visibility = Visibility.Hidden;
                Reg.Visibility = Visibility.Hidden;
                Red.Visibility = Visibility.Visible;
                Name.Visibility = Visibility.Visible;
            }
            else
                MessageBox.Show("ВЫ НЕ ВОШЛИ");
            form1.Close();
        }

        RegistrationWindow form2;
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            form2 = new RegistrationWindow();
            form2.Show();
            form2.buttonOk.Click += ButtonOk_Click;
        }

        private void ButtonOk_Click(object sender, RoutedEventArgs e)
        {
            forumServiceClient.RegisterUser(new OneUserX() { about = form2.aboutSelfTextBox.Text, age = 0, foto = null, name = form2.nameTextBox.Text, password = form2.passwordBox.Password, rating = 0, ratingAnswers = 0, ratingQwery = 0, });
            form2.Close();
        }
        QuestionWindow questionW;
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            questionW = new QuestionWindow();
            questionW.Show();
            questionW.buttonOk.Click += ButtonOk_Click2;
        }

        private void ButtonOk_Click2(object sender, RoutedEventArgs e)
        {
            forumServiceClient.SendQwery(new QweryX() { category = questionW.tagsTextBox.Text, code = questionW.forCodeTextBox.Text, header = questionW.headlineTextBox.Text,name = login, text = questionW.messageTextBox.Text });
            qweries.Clear();
            foreach (var item in forumServiceClient.GetQweryList())
            {
                qweries.Add(item);
            }
            questionW.Close();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            ResponseWindow responseW = new ResponseWindow("... например ivan59");
            responseW.ShowDialog();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            registrationWindow = new RegistrationWindow();
            registrationWindow.Show();
            OneUserX userX = forumServiceClient.GetOneUser(login);
            registrationWindow.nameTextBox.Text = userX.name;
            registrationWindow.nameTextBox.IsReadOnly = true;
            registrationWindow.aboutSelfTextBox.Text = userX.about;
            registrationWindow.buttonOk.Click += ButtonOk_Click3;
        }

        private void ButtonOk_Click3(object sender, RoutedEventArgs e)
        {
            forumServiceClient.EditOneUser(new OneUserX() { about = registrationWindow.aboutSelfTextBox.Text, password = registrationWindow.passwordBox.Password, name = login}, login);
            registrationWindow.Close();
        }
    }


    public class Test
    {
        public string MyProperty { get; set; }
        public string ASASASA { get; set; }
    }
}
