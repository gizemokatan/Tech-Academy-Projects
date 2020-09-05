
from tkinter import *
# NOTE: I had to import messagebox separately to prevent this error: 'NameError: name 'messagebox' is not defined'
from tkinter import messagebox
import tkinter as tk

# import our own modules so we
# can access them
import phonebook_main
import phonebook_func

# Pass in 'self' to the method to have access to the class 'ParentWindow' objects.
def load_gui(self):

    # Labels
    
    # Give the class all of the GUI widgets(text boxes, buttons, labels, scrollbar, list) accessable by passing in 'self'
    # Using the grid geometry manager, first access/instantiate tkinter's 'Label' class and give that instantiation a
    # class name 'self.lbl_fname'
    self.lbl_fname = tk.Label(self.master, text='First Name:')
    # Once we built it, we put in on the self.master and give it a text, and we have to place it
    # using the '.grid' (identifying what type of geometry manager we want to paint it with on the screen).
    # 'sticky=N+W' paints it in the upper most left corner.
    self.lbl_fname.grid(row=0,column=0,padx=(27,0),pady=(10,0),sticky=N+W)
    self.lbl_lname = tk.Label(self.master, text='Last Name:')
    self.lbl_lname.grid(row=2,column=0,padx=(27,0),pady=(10,0),sticky=N+W)
    self.lbl_phone = tk.Label(self.master, text='Phone Number:')
    self.lbl_phone.grid(row=4,column=0,padx=(27,0),pady=(10,0),sticky=N+W)
    self.lbl_email = tk.Label(self.master, text='Email Address:')
    self.lbl_email.grid(row=6,column=0,padx=(27,0),pady=(10,0),sticky=N+W)
    self.lbl_user = tk.Label(self.master, text='User:')
    self.lbl_user.grid(row=0,column=2,padx=(0,0),pady=(10,0),sticky=N+W)

    # Text boxes
    
    # In OOP, you're creating an instance of what the class object can be, taking tkinters diagram for
    # an 'Entry', bringing it into reality, and then giving that instance a name that we can access
    # and call it 'self.txt_fname'.
    self.txt_fname = tk.Entry(self.master,text='')
    self.txt_fname.grid(row=1,column=0,rowspan=1,columnspan=2,padx=(30,40),pady=(0,0),sticky=N+E+W)
    self.txt_lname = tk.Entry(self.master,text='')
    self.txt_lname.grid(row=3,column=0,rowspan=1,columnspan=2,padx=(30,40),pady=(0,0),sticky=N+E+W)
    self.txt_phone = tk.Entry(self.master,text='')
    self.txt_phone.grid(row=5,column=0,rowspan=1,columnspan=2,padx=(30,40),pady=(0,0),sticky=N+E+W)
    self.txt_email = tk.Entry(self.master,text='')
    self.txt_email.grid(row=7,column=0,rowspan=1,columnspan=2,padx=(30,40),pady=(0,0),sticky=N+E+W)

    # List box

    # Define a listbox with a scrollbar and grid them
    self.scrollbar1 = Scrollbar(self.master,orient=VERTICAL)
    self.lstList1 = Listbox(self.master,exportselection=0,yscrollcommand=self.scrollbar1.set)
    # We are binding to our List box, an event. In Tkinter we are creating an event listener.
    # If a user selects/clicks on an object within our list, call our function (lambda anonymous function)
    # in phonebook_func file called 'onSelect()'.
    # a bound event, needs to know the event, so we must pass in the 'event', as well as the key 'self'.
    self.lstList1.bind('<<ListboxSelect>>',lambda event: phonebook_func.onSelect(self,event))
    self.scrollbar1.config(command=self.lstList1.yview)
    self.scrollbar1.grid(row=1,column=5,rowspan=7,columnspan=1,padx=(0,0),pady=(0,0),sticky=N+E+S)
    self.lstList1.grid(row=1,column=2,rowspan=7,columnspan=3,padx=(0,0),pady=(0,0),sticky=N+E+S+W)

    # Buttons

    # When a user clicks on a button, we call the lambda (anonymous) functions
    # in the phonebook_func page that contains the instructions, and we pass in the key 'self'/ the class object.
    self.btn_add = tk.Button(self.master,width=12,height=2,text='Add',command=lambda: phonebook_func.addToList(self))
    self.btn_add.grid(row=8,column=0,padx=(25,0),pady=(45,10),sticky=W)
    self.btn_update = tk.Button(self.master,width=12,height=2,text='Update',command=lambda: phonebook_func.onUpdate(self))
    self.btn_update.grid(row=8,column=1,padx=(15,0),pady=(45,10),sticky=W)
    self.btn_delete = tk.Button(self.master,width=12,height=2,text='Delete',command=lambda: phonebook_func.onDelete(self))
    self.btn_delete.grid(row=8,column=2,padx=(15,0),pady=(45,10),sticky=W)
    self.btn_close = tk.Button(self.master,width=12,height=2,text='Close',command=lambda: phonebook_func.ask_quit(self))
    self.btn_close.grid(row=8,column=4,padx=(15,0),pady=(45,10),sticky=E)

    # calling these functions
    phonebook_func.create_db(self)
    phonebook_func.onRefresh(self)




if __name__== "__main__":
    # 'pass' will not do anything
    # only the 'main' will be in charge of running functions underneath
    pass

    
    
    
    
    
