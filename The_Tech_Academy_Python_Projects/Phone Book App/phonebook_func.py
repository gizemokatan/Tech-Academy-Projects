

import os
from tkinter import *
# NOTE: I had to import messagebox separatly to prevent tis error: 'NameError: name 'messagebox' is not defined'
from tkinter import messagebox
import tkinter as tk
import sqlite3

# import our other modules
import phonebook_main
import phonebook_gui

# function to center the app on the user screen
def center_window(self, w, h): # pass in the tkinter frame (master) reference and the w and h of our form
    # get user's screen width and height
    # Remember: 'self.master' is tkinter's primary window and to access info you must use
    # 'self.master' to get to that window.
    # another tkinter method 'winfo_screenwidth()' will get the actual user's screen width
    screen_width = self.master.winfo_screenwidth()
    screen_height = self.master.winfo_screenheight()
    # calculate x and y coordinates to paint the app centered on the user's screen
    x = int((screen_width/2) - (w/2))
    y = int((screen_height/2) - (h/2))
    # '.geometry()' will give dimensions to our form
    centerGeo = self.master.geometry('{}x{}+{}+{}'.format(w, h, x, y))
    return centerGeo


# catch if the user's clicks on the windows upper-right 'X' or the 'Close' button to ensure they want to close
def ask_quit(self):
    # invoke tkinters 'messagebox' class to use the 'askokcancel()' method to display a message to the user
    # 'Exit program' is the title of the window and 'Okay to exit app' is inside the body
    if messagebox.askokcancel("Exit program", "Okay to exit application?"):
        # This closes app
        self.master.destroy()
        # this takes all our widgets and deletes it from memory, to free up the memory, otherwise you can create a memory leak
        os._exit(0)


#=========================================================
def create_db(self):
    conn = sqlite3.connect('db_phonebook.db')
    with conn:
        cur = conn.cursor()
        cur.execute("CREATE TABLE if not exists tbl_phonebook( \
            ID INTEGER PRIMARY KEY AUTOINCREMENT, \
            col_fname TEXT, \
            col_lname TEXT, \
            col_fullname TEXT, \
            col_phone TEXT, \
            col_email TEXT \
            );")
        # You must commit() to save changes & close the database connection
        conn.commit()
    conn.close()
    first_run(self)

# function will insert into dB for the first time
def first_run(self):
    # this creates a tuple of dummy info in the first row as an example entry so the dB isnt empty
    data = ('John', 'Doe', 'John Doe', '111-111-1111', 'jdoe@gmail.com')
    conn = sqlite3.connect('db_phonebook.db')
    with conn:
        cur = conn.cursor()
        cur,count = count_records(cur)
        # this is only the first run, since we are checking if the count of the rows in the dB is 0
        if count < 1:
            # is no rows, if empty, insert the dummy info 
            cur.execute("""INSERT INTO tbl_phonebook (col_fname,col_lname,col_fullname,col_phone,col_email) VALUES (?,?,?,?,?)""", ('John','Doe','John Doe','111-111-1111','jdoe@email.com'))
            conn.commit()
    conn.close()


def count_records(cur):
    count = ""
    # select count all of the rows from our table
    cur.execute("""SELECT COUNT(*) FROM tbl_phonebook""")
    # this will extract the data from the very first index in the tuple 
    count = cur.fetchone()[0]
    # return the number of rows counted
    return cur,count
  

# Select item in ListBox
# When the user clicks on a name in our list box, we quickly access the dB and put in the data that corresponds to the name they clicked on.
def onSelect(self,event):
    #calling the event is the self.lstList1 widget
    varList = event.widget
    # the varList, its selection is a tuple, and this catches the index number it is, but doesnt get the actual text name
    select = varList.curselection()[0]
    # get the text of whatever is this index number
    value = varList.get(select)
    conn = sqlite3.connect('db_phonebook.db')
    # if the connection is successful, 
    with conn:
        cursor = conn.cursor()
        # NOTE: we are taking the info in the dB that relates to [value] which is the full name seen from the List box
        cursor.execute("""SELECT col_fname,col_lname,col_phone,col_email FROM tbl_phonebook WHERE col_fullname = (?)""", [value])
        # 'fetchall()' is for accessing info, taking it out of the sqlite dB, which is comes back as a tuple, so
        varBody = cursor.fetchall()
        # because this returns a tuple, we want to access specific parts of it, so we can slice it into 4 parts
        # using data[] during the iteration
        for data in varBody:
            # delete the whole thing from the beginning of the text box to the very end, and after you delete, 
            self.txt_fname.delete(0,END)
            # you want to '.insert' the data into the text box
            # 'data[0]' is accessing the first part of the tuple
            self.txt_fname.insert(0,data[0])
            self.txt_lname.delete(0,END)
            # 'data[1]' is accessing the second part of the tuple, and so on
            self.txt_lname.insert(0,data[1])
            self.txt_phone.delete(0,END)
            self.txt_phone.insert(0,data[2])
            self.txt_email.delete(0,END)
            self.txt_email.insert(0,data[3])

# add to our list we currently have
def addToList(self):
    var_fname = self.txt_fname.get()
    var_lname = self.txt_lname.get()
    # normalize the data to keep it consistent in the database
    var_fname = var_fname.strip() # This will remove any blank spaces before and after the user's entry
    var_lname = var_lname.strip() 
    var_fname = var_fname.title() # This will ensure that the first character in each word is capitalized
    var_lname = var_lname.title()
    var_fullname = ("{} {}".format(var_fname,var_lname)) # combine our normailzed names into a fullname
    # for development purposes, see that the name is presented the way we want it
    print("var_fullname: {}".format(var_fullname))
    var_phone = self.txt_phone.get().strip()
    var_email = self.txt_email.get().strip()
    if not "@" or not "." in var_email: # will use this soon
        print("Incorrect email format!!!")
    # if the length of var_fname, each character counted, is greater than 0, and so on    
    if (len(var_fname) > 0) and (len(var_lname) > 0) and (len(var_phone) > 0) and(len(var_email) > 0): # enforce the user to provide both names
        # if that passes, then we can connect to the dB,
        conn = sqlite3.connect('db_phonebook.db')
        # and if the connection is successful,
        with conn:
            cursor = conn.cursor()
            # check the database for existance of the fullname, if so we will alert user and disregard request
            # SQL 'COUNT' will count the number of entries 
            cursor.execute("""SELECT COUNT(col_fullname) FROM tbl_phonebook WHERE col_fullname = '{}'""".format(var_fullname))#,(var_fullname))
            # capture the count
            count = cursor.fetchone()[0]
            chkName = count
            if chkName == 0: # if this is 0 then there is no existance of the fullname and we can add new data
                # just for development to see if the chkName is in fact 0 (checks and balances)
                print("chkName: {}".format(chkName))
                cursor.execute("""INSERT INTO tbl_phonebook (col_fname,col_lname,col_fullname,col_phone,col_email) VALUES (?,?,?,?,?)""",(var_fname,var_lname,var_fullname,var_phone,var_email))
                self.lstList1.insert(END, var_fullname) # update listbox with the new fullname
                onClear(self) # call the function to clear all of the textboxes
            else:
                messagebox.showerror("Name Error","'{}' already exists in the database! Please choose a different name.".format(var_fullname))
                onClear(self) # call the function to clear all of the textboxes
        conn.commit()
        conn.close()
    else:
        messagebox.showerror("Missing Text Error","Please ensure that there is data in all four fields.")
        
# function to delete entry from dB
def onDelete(self):
    var_select = self.lstList1.get(self.lstList1.curselection()) # Listbox's selected value
    conn = sqlite3.connect('db_phonebook.db')
    with conn:
        cur = conn.cursor()
        # check count to ensure that this is not the last record in
        # the database...cannot delete last record or we will get an error
        cur.execute("""SELECT COUNT(*) FROM tbl_phonebook""")
        # with all rows counted from above line, store number of rows as 'count'
        count = cur.fetchone()[0]
        # if we have more than 1 row, then we have more than 1 user in the dB
        if count > 1:
            confirm = messagebox.askokcancel("Delete Confirmation", "All information associated with, ({}) \nwill be permenantly deleted from the database. \n\nProceed with the deletion request?".format(var_select))
            # if user confirms to delete entry,
            if confirm:
                conn = sqlite3.connect('db_phonebook.db')
                with conn:
                    cursor = conn.cursor()
                    cursor.execute("""DELETE FROM tbl_phonebook WHERE col_fullname = '{}'""".format(var_select))
                onDeleted(self) # call the function to clear all of the textboxes and the selected index of listbox
######             onRefresh(self) # update the listbox of the changes
                conn.commit()
        else:
            confirm = messagebox.showerror("Last Record Error", "({}) is the last record in the database and cannot be deleted at this time. \n\nPlease add another record first before you can delete ({}).".format(var_select,var_select))
    conn.close()


def onDeleted(self):
    # clear the text in these textboxes
    self.txt_fname.delete(0,END)
    self.txt_lname.delete(0,END)
    self.txt_phone.delete(0,END)
    self.txt_email.delete(0,END)
##    onRefresh(self) # update the listbox of the changes
    try:
        # deletes the index associated to the data within the dB
        index = self.lstList1.curselection()[0]
        self.lstList1.delete(index)
    except IndexError:
        pass

def onClear(self):
    # clear the text in these textboxes
    self.txt_fname.delete(0,END)
    self.txt_lname.delete(0,END)
    self.txt_phone.delete(0,END)
    self.txt_email.delete(0,END)
    

def onRefresh(self):
    # Populate the listbox, coinciding with names(data) in the database
    self.lstList1.delete(0,END)
    conn = sqlite3.connect('db_phonebook.db')
    with conn:
        cursor = conn.cursor()
        # count everything in the dB, making sure its not empty
        cursor.execute("""SELECT COUNT(*) FROM tbl_phonebook""")
        count = cursor.fetchone()[0]
        i = 0
        # as long as our count is greater than 0
        while i < count:
                cursor.execute("""SELECT col_fullname FROM tbl_phonebook""")
                # the position of [i] in the tuple will continue to change as we go through the loop
                varList = cursor.fetchall()[i]
                # take the item in varList, and put it in List box
                for item in varList:
                    self.lstList1.insert(0,str(item))
                    i = i + 1
    conn.close()

# function to update/ make changes to user info
def onUpdate(self):
    try:
        var_select = self.lstList1.curselection()[0] # index of the list selection
        var_value = self.lstList1.get(var_select) # list selection's text value
    except:
        # in the event, there is an error trying to get the above two pieces of info, we display a message
        messagebox.showinfo("Missing selection","No name was selected from the list box. \nCancelling the Update request.")
        return
    # The user will only be allowed to update changes for phone and emails.
    # For name changes, the user will need to delete the entire record and start over.
    var_phone = self.txt_phone.get().strip() # normalize the data to maintain database integrity using .strip() method
    var_email = self.txt_email.get().strip()
    if (len(var_phone) > 0) and (len(var_email) > 0): # ensure that there is data present
        conn = sqlite3.connect('db_phonebook.db')
        with conn:
            cur = conn.cursor()
            # count records to see if the user's changes are already in
            # the database...meaning, there are no changes to update.
            cur.execute("""SELECT COUNT(col_phone) FROM tbl_phonebook WHERE col_phone = '{}'""".format(var_phone))
            # get the return value back after we do the selection query
            count = cur.fetchone()[0]
            print(count)
            cur.execute("""SELECT COUNT(col_email) FROM tbl_phonebook WHERE col_email = '{}'""".format(var_email))
            count2 = cur.fetchone()[0]
            print(count2)
            if count == 0 or count2 == 0: # if proposed changes are not already in the database, then proceed
                response = messagebox.askokcancel("Update Request","The following changes ({}) and ({}) will be implemented for ({}). \n\nProceed with the update request?".format(var_phone,var_email,var_value))
                print(response)
                # if user responds 'okay'
                if response:
                    #conn = sqlite3.connect('db_phonebook.db')
                    with conn:
                        cursor = conn.cursor()
                        cursor.execute("""UPDATE tbl_phonebook SET col_phone = '{0}',col_email = '{1}' WHERE col_fullname = '{2}'""".format(var_phone,var_email,var_value))
                        # clears the text boxes
                        onClear(self)
                        conn.commit()
                # if the user responds 'cancel' 
                else:
                    messagebox.showinfo("Cancel request","No changes have been made to ({}).".format(var_value))
            else:
                messagebox.showinfo("No changes detected","Both ({}) and ({}) \nalready exist in the database for this name. \n\nYour update request has been cancelled.".format(var_phone, var_email))
            onClear(self)
        conn.close()
    else:
        messagebox.showerror("Missing information","Please select a name from the list. \nThen edit the phone or email information.")
    onClear(self)


if __name__ == "__main__":
    pass

