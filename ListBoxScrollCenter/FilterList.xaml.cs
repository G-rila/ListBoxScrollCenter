using System.Windows.Controls;

namespace ListBoxScrollCenter
{
    public partial class FilterList : UserControl
    {
        public FilterList()
        {
            InitializeComponent();
        }

        private void ScrollIntoView(object sender, SelectionChangedEventArgs e)
        {
            CenteredLB.ScrollToCenterOfView(CenteredLB.SelectedItem);
        }
    }
}
