using System;
using System.Collections.ObjectModel;
using System.Threading;
using System.Windows.Threading;

namespace WpfListBoxVirtualizing
{
    class ViewModel : ObservableObject
    {
        static DispatcherTimer _timer;

        ObservableCollection<RosterItemModel> _itemsButton;


        public ObservableCollection<RosterItemModel> ItemsButton
        {
            get { return _itemsButton; }
            set
            {
                _itemsButton = value;
                Changed(() => ItemsButton);
            }
        }

        ObservableCollection<RosterItemModel> _itemsTimer;


        public ObservableCollection<RosterItemModel> ItemsTimer
        {
            get { return _itemsTimer; }
            set
            {
                _itemsTimer = value;
                Changed(() => ItemsTimer);
            }
        }

        long _delay;
        public long Delay
        {
            get { return _delay; }
            set
            {
                _delay = value;
                if (_timer != null)
                    _timer.Interval = TimeSpan.FromMilliseconds(Delay);
                Changed(() => Delay);
            }
        }

        public RelayCommand RefreshCommand { get; set; }

        public ViewModel()
        {
            ItemsButton = new ObservableCollection<RosterItemModel>();
            ItemsTimer = new ObservableCollection<RosterItemModel>();
            RefreshCommand = new RelayCommand(Refresh);
            Delay = 200;
            _timer = new DispatcherTimer(DispatcherPriority.ApplicationIdle, App.Current.Dispatcher);
            _timer.Interval = TimeSpan.FromMilliseconds(Delay);
            _timer.Tick += TimerUpdate;
            _timer.Start();
        }

        void Refresh(object parameter)
        {
            ItemsButton.Clear();
            for (int i = 0; i < 1000; i++)
                ItemsButton.Add(RosterItemModel.CreateItemModel());
        }
        
        void TimerUpdate(object sender, EventArgs e)
        {
            ItemsTimer.Clear();
            for (int i = 0; i < 1000; i++)
                ItemsTimer.Add(RosterItemModel.CreateItemModel());
        }
    }
}
