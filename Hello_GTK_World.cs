using Gtk;
using System;

class Hello
{
    static void Main ()
    {
        Application.Init ();

        Window window = new Window ("Hello GTK World");
        window.Show ();

        Application.Run ();
    }
}
