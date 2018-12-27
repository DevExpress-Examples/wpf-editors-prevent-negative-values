using DevExpress.Xpf.Core;
using System.Collections.ObjectModel;

namespace DXGridSample {
    public partial class MainWindow : ThemedWindow {
        public MainWindow() {
            InitializeComponent();

            var items = new ObservableCollection<Item>();
            for (int i = 0; i < 100; i++)
                items.Add(new Item(i));

            grid.ItemsSource = items;
        }
    }
    public class Item {
        public Item(int i) {
            Value1 = i;
            Value2 = i;
        }
        public decimal Value1 { get; set; }
        public decimal Value2 { get; set; }
    }
}