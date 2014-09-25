using System;
using System.ComponentModel;
using System.Linq.Expressions;

namespace WpfListBoxVirtualizing
{
    class ObservableObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void Changed<T>(Expression<Func<T>> memberExpression)
        {
            var memberName = ((MemberExpression)memberExpression.Body).Member.Name;

            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(memberName));
        }
    }
}
