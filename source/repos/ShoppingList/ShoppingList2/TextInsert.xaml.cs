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

namespace ShoppingList2
{
    /// <summary>
    /// Interaction logic for TextInsert.xaml
    /// </summary>
    public partial class TextInsert : UserControl
    {
        public TextInsert()
        {
            InitializeComponent();
        }

        private void OnItemAddButtonClicked(object sender, RoutedEventArgs e)
        {
            //var data = DataContext as ShoppingListData;

            if(DataContext is ShoppingListData data)
            {
                data.Add(ItemsToAdd.Text);
            }
        }
    }
}
