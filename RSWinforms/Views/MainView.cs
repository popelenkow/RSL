using MugenMvvmToolkit.Attributes;
using MugenMvvmToolkit.Binding;
using MugenMvvmToolkit.Binding.Builders;
using System.Windows.Forms;
using RSL.ViewModels;

namespace RSL.Views
{
    [ViewModel(typeof(MainViewModel))]
    public partial class MainView : Form
    {
        public MainView()
        {
            InitializeComponent();
            using (var set = new BindingSet<MainViewModel>())
            {
                set.Bind(addToolStripButton).To(() => (vm, ctx) => vm.AddCommand);
                set.Bind(insertToolStripButton).To(() => (vm, ctx) => vm.InsertCommand);
                set.Bind(removeToolStripButton).To(() => (vm, ctx) => vm.RemoveCommand);
                set.Bind(tabControl, AttachedMemberConstants.ItemsSource).To(() => (vm, ctx) => vm.ItemsSource);
                set.Bind(tabControl, AttachedMemberConstants.SelectedItem).To(() => (vm, ctx) => vm.SelectedItem).TwoWay();
            }
        }
    }
}
