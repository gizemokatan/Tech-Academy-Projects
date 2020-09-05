
from tkinter import *
from tkinter import messagebox
import tkinter as tk

import student_tracking_main
import student_tracking_gui
import sqlite3


# function to center the app on the user screen
def center_window(self, w, h):
    # get user's screen width and height
    screen_width = self.master.winfo_screenwidth()
    screen_height = self.master.winfo_screenheight()
    # calculate x and y coordinates to paint the app centered on the user's screen
    x = int((screen_width/2) - (w/2))
    y = int((screen_height/2) - (h/2))
    # '.geometry()' will give dimensions to our app
    centerGeo = self.master.geometry('{}x{}+{}+{}'.format(w, h, x, y))
    return centerGeo

#=========================================================
def create_db(self):
    conn = sqlite3.connect('db_student_tracking.db')
    with conn:
        cur = conn.cursor()
        cur.execute("CREATE TABLE IF NOT EXISTS tbl_student_tracking( \
                    ID INTEGER PRIMARY KEY AUTOINCREMENT, \
                    col_fname TEXT, \
                    col_lname TEXT, \
                    col_phone TEXT, \
                    col_email TEXT, \
                    col_course TEXT \
                    );")
        # save chanegs to dB
        conn.commit()
    conn.close()


def count_records(cur):
    count = ""
    # count all of the rows from our table
    cur.execute("""SELECT COUNT(*) FROM tbl_student_tracking""")
    # this will extract the data from the very first index in the tuple 
    count = cur.fetchone()[0]
    # return the number of rows counted
    return cur,count   


# display list of students in listbox
def addToList(self):
    var_fname = self.txt_fname.get().strip().title()
    var_lname = self.txt_lname.get().strip().title()
    var_phone = self.txt_phone.get().strip()
    var_email = self.txt_email.get().strip()
    if not "@" or not "." in var_email:
        print("Incorrect email format!!!")
    var_course = self.txt_course.get().strip().title()
##    var_fullname = ("{} {}".format(var_fname,var_lname))
    # for development purposes
    var_studentInfo = ("{} {} {} {} {}".format(var_fname,var_lname,var_phone,var_email,var_course))
    print("var_studentInfo: {}".format(var_studentInfo))
    # if the length of var_fname, each character counted, is greater than 0, and so on
    if (len(var_fname) > 0) and (len(var_lname) > 0) and (len(var_phone) > 0) and(len(var_email) > 0) and (len(var_course) > 0):
        conn = sqlite3.connect('db_student_tracking.db')
        with conn:
            cur = conn.cursor()
            # check the database for existance of that studentInfo object, if there is we will alert user and disregard request
            cur.execute("""SELECT COUNT(col_phone) FROM tbl_student_tracking WHERE col_phone = '{}'""".format(var_phone))
            count = cur.fetchone()[0]
            chkphone = count
            if chkphone == 0:
                print("chkphone: {}".format(chkphone))
                cur.execute("""INSERT INTO tbl_student_tracking (col_fname,col_lname,col_phone,col_email,col_course) VALUES (?,?,?,?,?)""",(var_fname,var_lname,var_phone,var_email,var_course))
                self.lstList1.insert(END, var_fname + " | " + var_lname + " | " + var_phone + " | " + var_email + " | " + var_course)
                onClear(self)
            else:
                messagebox.showerror("Name Error","'{} {}' already exists in the database! Please choose a different name.".format(var_fname,var_lname))
                onClear(self)
        
        conn.commit()
        conn.close()
    else:
        messagebox.showerror("Missing Text Error","Please ensure that there is data in all four fields.")
                                                                                                  
                                                                                                          
def onClear(self):
    # clear the text in these textboxes
    self.txt_fname.delete(0,END)
    self.txt_lname.delete(0,END)
    self.txt_phone.delete(0,END)
    self.txt_email.delete(0,END)
    self.txt_course.delete(0,END)


def onDelete(self):
    # clear the text in these textboxes
    self.txt_fname.delete(0,END)
    self.txt_lname.delete(0,END)
    self.txt_phone.delete(0,END)
    self.txt_email.delete(0,END)
    self.txt_course.delete(0,END)

    var_select = self.lstList1.get(self.lstList1.curselection())

    # deletes the lineNumber associated to the data within the dB
    lineNumber = self.lstList1.curselection()[0]
    self.lstList1.delete(lineNumber)

##    print("selected: ", var_select)
    conn = sqlite3.connect('db_student_tracking.db')
    with conn:
        cur = conn.cursor()
        cur.execute("""SELECT * FROM tbl_student_tracking""")
        records = cur.fetchall()
        listOfIDs = []
        for row in records:
            listOfIDs.append(row[0])
##        print(listOfIDs)
            
        cur.execute("""SELECT COUNT(*) FROM tbl_student_tracking""")
        count = cur.fetchone()[0]
        if count > 1:
            confirm = messagebox.askokcancel("Delete Confirmation", "All information associated with, ({}) \nwill be permenantly deleted from the database. \n\nProceed with the deletion request?".format(var_select))
            if confirm:
                cur.execute("""DELETE FROM tbl_student_tracking WHERE ID = '{}'""".format(listOfIDs[lineNumber]))
                conn.commit()
        else:
            confirm = messagebox.showerror("Last Record Error", "({}) is the last record in the database and cannot be deleted at this time. \n\nPlease add another record first before you can delete ({}).".format(var_select,var_select))
       
    conn.commit()
    conn.close()


    

# Populate the listbox, coinciding with data in the dB
def onRefresh(self):
    self.lstList1.delete(0,END)
    conn = sqlite3.connect('db_student_tracking.db')
    with conn:
        cur = conn.cursor()
        # select everyhting from the dB 
        cur.execute("""SELECT * FROM tbl_student_tracking""")
        # Fetches all the rows of a query result. Returns all the rows as a list of tuples.
        # An empty list is returned if there is no record to fetch.
        # len() returns the number of rows in dB
        count = len(cur.fetchall())
        print(count)
        i = 0
        entryList = []
        # as long as our count is greater than 0
        while i < count:
            cur.execute("""SELECT col_fname,col_lname,col_phone,col_email,col_course FROM tbl_student_tracking""")
            # varList is a row in dB
            varList = cur.fetchall()[i]
            # iterate backwards through items in list
            for item in varList:
                entryList.append(item)
            entryListStr = ' | '.join(entryList)
            self.lstList1.insert(END,entryListStr)
            entryList.clear()
            # allows us to go to the next row in dB
            i = i + 1
    conn.close()
    
    
    
    


if __name__ == "__main__":
    pass
    
