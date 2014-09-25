using System;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace WpfListBoxVirtualizing
{
    class RosterItemModel// : ObservableObject
    {
        string _name;

        string _color;

        string _icon;
        string _iconColor;
        FontFamily _fontIcon;

        string _lastMessage;
        string _authorLastMessage;
        string _authorLastMessageColor;

        string _unreadCount;
        BitmapSource _unreadCountIcon;

        string _lastTs;



        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                //Changed(() => Item);
            }
        }

        public string Color
        {
            get { return _color; }
            set
            {
                _color = value;
                //Changed(() => Color);
            }
        }

        public string Icon
        {
            get { return _icon; }
            set
            {
                _icon = value;
                //Changed(() => Icon);
            }
        }

        public string IconColor
        {
            get { return _iconColor; }
            set
            {
                _iconColor = value;
                //Changed(() => IconColor);
            }
        }

        public FontFamily FontIcon
        {
            get { return _fontIcon; }
            set
            {
                _fontIcon = value;
                //Changed(() => FontIcon);
            }
        }

        public string LastMessage
        {
            get { return _lastMessage; }
            set
            {
                _lastMessage = value;
                //Changed(() => LastMessage);
            }
        }

        public string AuthorLastMessage
        {
            get { return _authorLastMessage; }
            set
            {
                _authorLastMessage = value;
                //Changed(() => AuthorLastMessage);
            }
        }

        public string AuthorLastMessageColor
        {
            get { return _authorLastMessageColor; }
            set
            {
                _authorLastMessageColor = value;
                //Changed(() => AuthorLastMessageColor);
            }
        }

        public string UnreadCount
        {
            get { return _unreadCount; }
            set
            {
                _unreadCount = value;
                //Changed(() => UnreadCount);
            }
        }

        public BitmapSource UnreadCountIcon
        {
            get { return _unreadCountIcon; }
            set
            {
                _unreadCountIcon = value;
                //Changed(() => UnreadCountIcon);
            }
        }

        public string LastTs
        {
            get { return _lastTs; }
            set
            {
                _lastTs = value;
                //Changed(() => LastTs);
            }
        }



        public static RosterItemModel CreateItemModel()
        {
            Random rnd = new Random();
            return new RosterItemModel
                {
                    Name = "Ilshat " + RandomString(5),
                    Icon = null,
                    FontIcon = null,
                    Color = "#" + rnd.Next(100000, 999999).ToString(),
                    IconColor = "#" + rnd.Next(100000, 999999).ToString(),
                    UnreadCount = rnd.Next(100000, 999999).ToString(),
                    UnreadCountIcon = null,
                    LastTs = rnd.Next(1, 9).ToString() + "m",
                    LastMessage = RandomString(30),
                    AuthorLastMessage = "Serega " + RandomString(5) + ": ",
                    AuthorLastMessageColor = "#" + rnd.Next(100000, 999999).ToString()
                };
        }

        private static string RandomString(int size)
        {
            Random random = new Random((int)DateTime.Now.Ticks);
            StringBuilder builder = new StringBuilder();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }

            return builder.ToString();
        }
    }
}
