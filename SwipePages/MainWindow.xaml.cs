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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SwipePages
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        protected TouchPoint TouchStart;

        public MainWindow()
        {
            InitializeComponent();
            this.TouchDown += MainWindow_TouchDown;
            this.TouchMove += MainWindow_TouchMove;
        }

        private bool AlreadySwiped = true;
        private void MainWindow_TouchMove(object sender, TouchEventArgs e)
        {
            if(!AlreadySwiped)
            {
                var Touch = e.GetTouchPoint(this);


                if (TouchStart != null && Touch.Position.X > (TouchStart.Position.X + 100))
                {
                    MoveView(0);
                    AlreadySwiped = true;
                }

                if (TouchStart != null && Touch.Position.X < (TouchStart.Position.X - 100))
                {
                    MoveView(1);
                    AlreadySwiped = true;
                }
            }

            e.Handled = true;
        }

        private void MainWindow_TouchDown(object sender, TouchEventArgs e)
        {
            TouchStart = e.GetTouchPoint(this);
            AlreadySwiped = false;
        }

        private void btnSecondPage_Click(object sender, RoutedEventArgs e)
        {
            MoveView(1);
        }

        private void btnFirstPage_Click(object sender, RoutedEventArgs e)
        {
            MoveView(0);
        }

        private void MoveView(int TargetViewIndex)
        {
            CollectionViewSource viewSource = (CollectionViewSource)this.Resources["ViewSource"];
            if (viewSource.View.CurrentPosition > TargetViewIndex)
            {
                for (int i = viewSource.View.CurrentPosition; i > TargetViewIndex; i--)
                {
                    viewer.BeginStoryboard((Storyboard)this.Resources["slideRightToLeft"]);
                    viewSource.View.MoveCurrentToPrevious();
                }
            }
            else
            {
                for (int i = viewSource.View.CurrentPosition; i < TargetViewIndex; i++)
                {
                    viewer.BeginStoryboard((Storyboard)this.Resources["slideLeftToRight"]);
                    viewSource.View.MoveCurrentToNext();
                }
            }
        }
    }
}
