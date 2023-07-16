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

namespace CompleteLoginApp_Project
{
    /// <summary>
    /// Interaction logic for StoreUI.xaml
    /// </summary>
    public partial class StoreUI : UserControl
    {
        public List<myStoreItems> myStoreItems = new List<myStoreItems>
        {
            new myStoreItems {ID = 1, Name = "Marvel's Spiderman", releaseYear = 2018},
            new myStoreItems {ID = 2, Name = "The Witcher 3", releaseYear = 2015},
            new myStoreItems {ID = 3, Name = "The Elder Scrolls: Skyrim", releaseYear = 2011},
            new myStoreItems {ID = 4, Name = "God Of War:Ragnarok",releaseYear = 2022},
            new myStoreItems {ID = 5, Name = "Cyberpunk 2077: Phantom Liberty", releaseYear = 2023},
            new myStoreItems {ID = 6, Name = "The Witcher 3: Blood and Wine", releaseYear = 2016}
        };
        public StoreUI()
        {
            InitializeComponent();

            ListBoxItems.ItemsSource = myStoreItems;
        }

        private void SelectBtn_Click(object sender, RoutedEventArgs e)
        {
            var userSelectItem = ListBoxItems.SelectedItems;

            foreach (var item in userSelectItem)
            {
                var game = (myStoreItems)item;

                MessageBox.Show(game.Name, Convert.ToString(game.releaseYear));

            }
        }
    }
}
