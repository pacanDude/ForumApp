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
                ListViewItem listViewItemX = new ListViewItem() { Content = item };
                listViewItemX.MouseDoubleClick += ListViewItem_MouseDown;
                listCat.Items.Add(listViewItemX);
            }
            ListViewItem listViewItem = new ListViewItem() { Content = "Все" };
            listViewItem.MouseDoubleClick += ListViewItem_MouseDown;
            listCat.Items.Add(listViewItem);

            foreach (var item in forumServiceClient.GetQweryList())
            {
                qweries.Add(item);
            }
            this.DataContext = qweries;


        }

        private void ListViewItem_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ListViewItem listViewItem = (ListViewItem)sender;

            if ((string)listViewItem.Content=="Все")
            {
                qweries.Clear();
                foreach (var item in forumServiceClient.GetQweryList())
                {
                    qweries.Add(item);
                }
                this.DataContext = qweries;
                return;
            }

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
            //
            AllMessageAndQwery list = forumServiceClient.GetQweryWithAnsvers((int)((TextBlock)sender).Tag);
            //List<QweryX> qweryXes = new List<QweryX>();
            //qweryXes.Add(list.qwery);
            TabItem tabItem = new TabItem() { Header = list.qwery.header };
            Grid grid = new Grid() { Height = Double.NaN, Style = (Style)Resources["gridBackroundStyle"] };
            
            ListView listView = new ListView()/* { Style = (Style)Resources["s"]}*/;
            
            ListViewItem lvI = new ListViewItem() { Style = (Style)Resources["s"] };
            //lvI.DataContext = new QweryX { header = "heeedeer", code = "coooooode", date = DateTime.Now, name = "vadim", Id = 3, category = "asd", rating = 5, text = "texxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxt" };
            lvI.DataContext = list.qwery;

            listView.Items.Add(lvI);
            ///////////////////////////////////
            //ListView listView2 = new ListView() /*{ Style = (Style)Resources["sa"] }*/;


            ListViewItem listViewItem2 = new ListViewItem() { Content = "ОТВЕТЫ" };
            listView.Items.Add(listViewItem2);
            foreach (var item in list.answers)
            {
                ListViewItem temp = new ListViewItem() { Style = (Style)Resources["sa"] };
                temp.DataContext = item;
                listView.Items.Add(temp);
                //listView2.Items.Add(item);
            }
            ListViewItem listViewItem = new ListViewItem() { Content = "ДОБАВИТЬ ОТВЕТ", Tag = list.qwery };
            listViewItem.MouseDoubleClick += MainWindow_MouseDown;
            listView.Items.Add(listViewItem);
            //Добавление всех элементов управления вопроса
            grid.Children.Add(listView);
           // grid.Children.Add(listView2);
            tabItem.Content = grid;
            tabItem.MouseDown += TabItem_MouseUp;

            MainTabControl.Items.Add(tabItem);
        }
        ListViewItem viewItem;
        ResponseWindow responseWindow;
        private void MainWindow_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (login != null)
            {
                viewItem = ((ListViewItem)sender);
                responseWindow = new ResponseWindow("Ваш ответ пользователю " + ((QweryX)viewItem.Tag).name, ((QweryX)viewItem.Tag).Id, login);
                responseWindow.Show();
                responseWindow.buttonOk.Click += ButtonOk_Click4;
                responseWindow.buttonCancel.Click += ButtonCancel_Click;
            }
            else
            {
                form1 = new LoginWindow();
                form1.Show();
                form1.buttonOk.Click += ButtonOk_Click1;
            }
        }

        private void ButtonCancel_Click(object sender, RoutedEventArgs e)
        {
            viewItem = null;
            responseWindow.Close();
        }

        private void ButtonOk_Click4(object sender, RoutedEventArgs e)
        {
            forumServiceClient.SendAnsver(new AnsverX() { code = responseWindow.forCodeTextBox.Text, text = responseWindow.messageTextBox.Text, QweryId = responseWindow.QueryId, name = responseWindow.login});
            
            AllMessageAndQwery list = forumServiceClient.GetQweryWithAnsvers(((QweryX)viewItem.Tag).Id);
            ListView listV = ((ListView)viewItem.Parent);
            listV.Items.Clear();

            ListViewItem lvI = new ListViewItem() { Style = (Style)Resources["s"] };
            lvI.DataContext = list.qwery;
            listV.Items.Add(lvI);

            listV.Items.Add(new ListViewItem() { Content = "ОТВЕТЫ" });
            foreach (var item in list.answers)
            {
                ListViewItem temp = new ListViewItem() { Style = (Style)Resources["sa"] };
                temp.DataContext = item;
                listV.Items.Add(temp);
            }
            ListViewItem listViewItem = new ListViewItem() { Content = "ДОБАВИТЬ ОТВЕТ", Tag = list.qwery };
            listViewItem.MouseDoubleClick += MainWindow_MouseDown;
            listV.Items.Add(listViewItem);
            viewItem = null;
            responseWindow.Close();
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
            forumServiceClient.SendQwery(new QweryX() { category = questionW.tagsTextBox.Text, code = questionW.forCodeTextBox.Text, header = questionW.headlineTextBox.Text, name = login, text = questionW.messageTextBox.Text });
            qweries.Clear();
            foreach (var item in forumServiceClient.GetQweryList())
            {
                qweries.Add(item);
            }
            questionW.Close();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
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
            forumServiceClient.EditOneUser(new OneUserX() { about = registrationWindow.aboutSelfTextBox.Text, password = registrationWindow.passwordBox.Password, name = login }, login);
            registrationWindow.Close();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            if (login != null)
            {
                forumServiceClient.QweryRatingUp((int)((Button)sender).Tag);

            }
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            if (login != null)
            {
                forumServiceClient.QweryRatingDown((int)((Button)sender).Tag);

            }
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            if(login != null)
            {

                forumServiceClient.AnsverRatingUp((int)((Button)sender).Tag);
            }
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            if (login != null)
            {

                forumServiceClient.AnsverRatingDown((int)((Button)sender).Tag);
            }
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {

        }

        private void TabItem_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.MiddleButton == MouseButtonState.Pressed)
                this.Close();
        }
    }


    public class Test
    {
        public string MyProperty { get; set; }
        public string ASASASA { get; set; }
    }
}
