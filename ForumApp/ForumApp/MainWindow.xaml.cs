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
            TabItem tabItem = new TabItem() { Header = listViewItem.Content };
            tabItem.MouseDown += TabItem_MouseUp;
            Grid grid = new Grid();
            ScrollViewer scrollViewer = new ScrollViewer() { CanContentScroll = true, HorizontalScrollBarVisibility = ScrollBarVisibility.Auto, VerticalScrollBarVisibility = ScrollBarVisibility.Auto, Margin = new Thickness(15, 11, 30, 10) };
            ListBox listBox = new ListBox() { Style = (Style)Resources["listBoxStyle1"] , ItemsSource = forumServiceClient.GetCategoryQweryList((string)listViewItem.Content).ToList() };
            scrollViewer.Content = listBox;
            grid.Children.Add(scrollViewer);
            tabItem.Content = grid;
            MainTabControl.Items.Add(tabItem);
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
            TabItem tabItem = new TabItem() { Header = SearchBox.Text };
            tabItem.MouseDown += TabItem_MouseUp;
            MainTabControl.Items.Add(tabItem);
        }

        private void TabItem_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (e.MiddleButton == MouseButtonState.Pressed)
                MainTabControl.Items.Remove(sender);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
        }

        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TabItem tabItem = new TabItem() { Header = (string)((TextBlock)sender).Text };

            tabItem.MouseDown += TabItem_MouseUp;
            MainTabControl.Items.Add(tabItem);
        }

        private void TextBlock_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            List<AnsverX> list = forumServiceClient.GetQweryWithAnsvers((int)((TextBlock)sender).Tag).answers.ToList();
            foreach (var item in list)
            {
                TabItem tabItem = new TabItem() { Header = item.text };
                Grid grid = new Grid();
                ScrollViewer scrollViewer = new ScrollViewer() { CanContentScroll = true, HorizontalScrollBarVisibility = ScrollBarVisibility.Auto, VerticalScrollBarVisibility = ScrollBarVisibility.Auto };


                tabItem.Content = grid;

                ListView listView = new ListView() { Style = (Style)Resources["ListViewStyle"] };
                //listView.ItemsSource = item;
                scrollViewer.Content = listView;
                grid.Children.Add(scrollViewer);

                tabItem.MouseDown += TabItem_MouseUp;
                MainTabControl.Items.Add(tabItem);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TabItem tabItem = new TabItem() { Header = SearchBox.Text };
            tabItem.MouseDown += TabItem_MouseUp;
            MainTabControl.Items.Add(tabItem);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
    public class Test
    {
        public string MyProperty { get; set; }
        public string ASASASA { get; set; }
    }
}
