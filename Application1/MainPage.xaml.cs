using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Application1
{
    public partial class MainPage : Page
    {

        public MainPage()
        {
            this.InitializeComponent();
            LotsListBox.ItemsSource = new ObservableCollection<Lot>() {
new Lot("2", "1", "3"),
new Lot("2", "1", "3"),
new Lot("3", "1", "3"),
new Lot("3", "1", "3"),
new Lot("2", "1", "3"),
new Lot("2", "1", "3"),
new Lot("3", "1", "3"),
new Lot("3", "1", "3"),
new Lot("4", "1", "3"),
new Lot("2", "1", "3"),
new Lot("3", "1", "3"),
new Lot("3", "1", "3"),
new Lot("2", "1", "3"),
new Lot("2", "1", "3"),
new Lot("3", "1", "3"),
new Lot("3", "1", "3"),
new Lot("4", "1", "3"),
new Lot("2", "1", "3"),
new Lot("3", "1", "3"),
new Lot("3", "1", "3"),
new Lot("2", "1", "3"),
new Lot("2", "1", "3"),
new Lot("3", "1", "3"),
new Lot("3", "1", "3"),
new Lot("4", "1", "3"),
new Lot("2", "1", "3"),
new Lot("3", "1", "3"),
new Lot("3", "1", "3"),
new Lot("2", "1", "3"),
new Lot("2", "1", "3"),
new Lot("3", "1", "3"),
new Lot("3", "1", "3"),
new Lot("4", "1", "3"),
new Lot("2", "1", "3"),
new Lot("3", "1", "3"),
new Lot("3", "1", "3"),
new Lot("2", "1", "3"),
new Lot("2", "1", "3"),
new Lot("3", "1", "3"),
new Lot("3", "1", "3"),
new Lot("4", "1", "3") };
            // Enter construction logic here...
        }
        public class Lot
        {
            public Lot(string title, string iconSource, string objectId)
            {
                IconSource = iconSource;
                Title = title;
                ObjectId = objectId;
            }

            public string Title { get; set; }
            public string IconSource { get; set; }
            public string ObjectId { get; set; }

            public static List<string> LotTypes { get; set; } = new List<string>{
"Категория не указана",
"Мягкие игрушки",
"Книги",
"Игрушки из пластика",
};
        }
    }
}
