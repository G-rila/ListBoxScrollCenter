using System.Windows.Controls;

namespace ListBoxScrollCenter
{
    public partial class GameList : UserControl
    {
        public GameList()
        {
            InitializeComponent();
        }

        private void ScrollIntoView(object sender, SelectionChangedEventArgs e)
        {
            CenteredLB.ScrollToCenterOfView(CenteredLB.SelectedItem);
        }
    }
}
