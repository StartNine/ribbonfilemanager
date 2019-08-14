﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace RibbonFileManager
{
    public static class WindowManager
    {
        public static Location WindowDefaultLocation = new ShellLocation(new Guid("20D04FE0-3AEA-1069-A2D8-08002B30309D")); //Environment.ExpandEnvironmentVariables(@"%userprofile%");

        public static List<MainWindow> OpenWindows = new List<MainWindow>();

        public static MainWindow CreateWindow()
        {
            return CreateWindow(WindowDefaultLocation);
        }

        public static MainWindow CreateWindow(Location targetLocation)
        {
            //var path = Environment.ExpandEnvironmentVariables(targetPath);
            var found = false;

            if (!found)
            {
                var win = new MainWindow(targetLocation);
                win.Show();
                win.Focus();
                win.Activate();
                return win;
            }
            else
                return null;
        }

        public static void CloneWindow(MainWindow targetWindow)
        {
            var win = new MainWindow(targetWindow);

            win.Show();
            win.Focus();
            win.Activate();
        }
    }
}
