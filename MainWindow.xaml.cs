using Syncfusion.UI.Xaml.TreeGrid;
using Syncfusion.UI.Xaml.TreeGrid.Helpers;
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

namespace SfTreeGridDemo
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.treeGrid.MouseDoubleClick += TreeGrid_MouseDoubleClick;
        }

        private void TreeGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var treeGridPanel = this.treeGrid.GetTreePanel();
            // get the row and column index based on the pointer position 
            var rowColumnIndex = treeGridPanel.PointToCellRowColumnIndex(e.GetPosition(treeGridPanel));
            if (rowColumnIndex.IsEmpty)
                return;
            var treeNodeAtRowIndex = treeGrid.GetNodeAtRowIndex(rowColumnIndex.RowIndex);                       

            MessageBox.Show("TreeNode : " + treeNodeAtRowIndex.ToString());
        }
    }
}
