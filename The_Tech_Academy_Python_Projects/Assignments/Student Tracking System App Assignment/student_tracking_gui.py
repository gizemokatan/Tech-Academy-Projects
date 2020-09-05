
from tkinter import *
import tkinter as tk

import student_tracking_main
import student_tracking_func


def load_gui(self):
    # Labels
    # Using the grid geometry manager, first access/instantiate tkinter's
    # 'Label' class and give that instantiation a class name 'self.lbl_fname'
    self.lbl_fname = tk.Label(self.master, text='First Name:')
    self.lbl_fname.grid(row=0,column=0,padx=(30,0),pady=(10,0),sticky=N+W)
    self.lbl_lname = tk.Label(self.master, text='Last Name:')
    self.lbl_lname.grid(row=2,column=0,padx=(30,0),pady=(10,0),sticky=N+W)
    self.lbl_phone = tk.Label(self.master, text='Phone Number:')
    self.lbl_phone.grid(row=4,column=0,padx=(30,0),pady=(10,0),sticky=N+W)
    self.lbl_email = tk.Label(self.master, text='Email Address:')
    self.lbl_email.grid(row=6,column=0,padx=(30,0),pady=(10,0),sticky=N+W)
    self.lbl_course = tk.Label(self.master, text='Current Course:')
    self.lbl_course.grid(row=8,column=0,padx=(30,0),pady=(10,0),sticky=N+W)
    self.lbl_student = tk.Label(self.master, text='Student Info:')
    self.lbl_student.grid(row=0,column=2,padx=(0,0),pady=(10,0),sticky=N+W)

    # Text Boxes
    # In OOP, we're creating an instance of what a class object can be, taking
    # tkinters diagram for an 'Entry', bringing it into reality, and then giving
    # that instance a name that we can access and call it, 'self.txt_fname'.
    self.txt_fname = tk.Entry(self.master,text='')
    self.txt_fname.grid(row=1,column=0,rowspan=1,columnspan=2,padx=(30,40),pady=(0,0),sticky=N+E+W)
    self.txt_lname = tk.Entry(self.master,text='')
    self.txt_lname.grid(row=3,column=0,rowspan=1,columnspan=2,padx=(30,40),pady=(0,0),sticky=N+E+W)
    self.txt_phone = tk.Entry(self.master,text='')
    self.txt_phone.grid(row=5,column=0,rowspan=1,columnspan=2,padx=(30,40),pady=(0,0),sticky=N+E+W)
    self.txt_email = tk.Entry(self.master,text='')
    self.txt_email.grid(row=7,column=0,rowspan=1,columnspan=2,padx=(30,40),pady=(0,0),sticky=N+E+W)
    self.txt_course = tk.Entry(self.master,text='')
    self.txt_course.grid(row=9,column=0,rowspan=1,columnspan=2,padx=(30,40),pady=(0,0),sticky=N+E+W)

    # List Box
    # Define a listbox with a scrollbar and grid them
    self.scrollbar1 = Scrollbar(self.master,orient=VERTICAL)
    self.lstList1 = Listbox(self.master,exportselection=0,yscrollcommand=self.scrollbar1.set)
    self.scrollbar1.config(command=self.lstList1.yview)
    self.scrollbar1.grid(row=1,column=5,rowspan=9,columnspan=1,padx=(0,0),pady=(0,0),sticky=N+E+S)
    self.lstList1.grid(row=1,column=2,rowspan=9,columnspan=3,padx=(0,0),pady=(0,0),sticky=N+E+S+W)

    #Buttons
    # When a user clicks on a button, we call the lambda function in the student_tracking_func
    # file that contains the instructions, and we pass in the key 'self'/ the class object.
    self.btn_submit = tk.Button(self.master,width=12,height=2,text='Submit',command=lambda: student_tracking_func.addToList(self))
    self.btn_submit.grid(row=9,column=0,padx=(30,0),pady=(45,10),sticky=W)
    self.btn_delete = tk.Button(self.master,width=25,height=2,text='Delete',command=lambda: student_tracking_func.onDelete(self))
    self.btn_delete.grid(row=10,column=4,padx=(15,0),pady=(15,10),sticky=E)

    # call to create the dB
    student_tracking_func.create_db(self)
    student_tracking_func.onRefresh(self)




if __name__ == "__main__":
    pass
    
