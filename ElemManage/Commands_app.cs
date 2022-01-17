using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ElemManage
{
    class Commands_app
    {
        public static RoutedUICommand ExitApp { get; set; }
        static Commands_app ()
        {
            InputGestureCollection input1 = new InputGestureCollection();
            input1.Add(new KeyGesture(Key.P, ModifierKeys.Control, "Ctrl+P"));
            ExitApp = new RoutedUICommand("Выход","ExitApp", typeof(Commands_app),input1);
        }
    }
}
