using System.Windows.Controls;

namespace ListBoxScrollCenter
{
    public partial class SystemList : UserControl
    {
        public SystemList()
        {
            InitializeComponent();
        }

        private void ScrollIntoView(object sender, SelectionChangedEventArgs e)
        {
            CenteredLB.ScrollToCenterOfView(CenteredLB.SelectedItem);
        }
    }
}
