
#
# Python Ver:   3.8.5
#
# Author:       Courtney Dart
#
# Description:  Student Tracking System demonstrating OOP, Tkinter GUI module,
#               using Tkinter Parent and Child relationships.


from tkinter import *
import tkinter as tk

import student_tracking_gui
import student_tracking_func

# Frame is a Tkinter frame class that our own class will inherit from.
class ParentWindow(Frame):
    def __init__(self, master, *args, **kwargs):
        # Once we define a class, 'self' references the object, and 'master' is what we will call the Frame
        Frame.__init__(self, master, *args, **kwargs)

        #'self' is saying 'ParentWindow' dot 'master' meaning the ParentWindow Frame.
        self.master = master
        # Set the window size Height, Width in pixels
        self.master.minsize(500,300)
##        self.master.maxsize(700,400)
        # This CenterWindow method will center our app on the user's screen
        student_tracking_func.center_window(self,500,400)
        self.master.title("Student Tracking")
        self.master.config(bg="lightblue")
##        self.master.protocol("WM_DELETE_WINDOW", lambda: student_tracking_func.ask_quit(self))

        # Load in the GUI widgets from a seperate module,
        # keeping your code compartmentalized and clutter free.
        student_tracking_gui.load_gui(self)



if __name__ == "__main__":
    # create the window from Tkinter
    root = tk.Tk()
    # calling our class 'App' attaching the Tkinter window 'root'
    App = ParentWindow(root)
    # make the window persistant on our screen, until we cancel the loop
    root.mainloop()
        


