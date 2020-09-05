
#
# Python Ver:   3.8.5
#
# Author:       Courtney Dart
#
# Description:  Phonebook demonstrating OOP, Tkinter GUI module,
#               using Tkinter Parent and Child relationships.
#
# Tested OS:    This code was written and tested to work with Windows 10.


from tkinter import *
import tkinter as tk


# Be sure to import our other modules
# so we can have access/reference them.
import phonebook_gui
import phonebook_func


# Frame is a Tkinter frame class that our own class will inherit from.
# We will inherit from the primary Tkinter object 'Frame' when we want to create other frames.
class ParentWindow(Frame):
    # Once we define a class, 'self' references the object, and 'master' is what we will call the Frame
    def __init__ (self, master, *args, **kwargs):
        Frame.__init__(self, master, *args, **kwargs)

        # Define our master frame configurations
        #'self' is saying 'ParentWindow' dot 'master' meaning the ParentWindow Frame.
        self.master = master
        # Set the window size Height, Width in pixels
        # The min and max sizes are the same, therefore we will not be able to resize the window.
        self.master.minsize(500,300)
        self.master.maxsize(500,300)
        # This CenterWindow method will center our app on the user's screen
        # Access phonebook_func and in it, define 'center_window' which makes the window center.
# NOTE: in order for anything to affect all the widgets on the form we have to access the widgets by passing in self.
        phonebook_func.center_window(self,500,300)
        self.master.title("The Tkinter Phonebook Demo")
        self.master.config(bg="#F0F0F0")
        # This protocol method is a tkinter built-in method to catch if
        # the user clicks the upper corner, 'X' on Windows OS to close the window.
        # Microsoft's syntax 'WM_DELETE_WINDOW', the name of a button.
        # 'protocol()' makes a rule and if this windows button is pressed, we do a lambda
        # function and call our 'phonebook_func' file which has the 'ask_quit()' within.
        self.master.protocol("WM_DELETE_WINDOW", lambda: phonebook_func.ask_quit(self))

        # Load in the GUI widgets from a seperate module,
        # keeping your code compartmentalized and clutter free.
        phonebook_gui.load_gui(self)




if __name__ == "__main__":
    # create the window from Tkinter
    root = tk.Tk()
    # calling our class 'App' attaching the Tkinter window 'root'
    App = ParentWindow(root)
    # make the window persistant on our screen, until we cancel the loop
    root.mainloop()













        
