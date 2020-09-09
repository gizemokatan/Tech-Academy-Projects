
# Description:  Utilize shutil, os, and datetime modules
#               Practice file transfering files that were
#               modified within the last 24 hours.
#               Create a GUI and connect functionality.
#
# NOTE:         print statements are for development purposes

from tkinter import *
from tkinter import filedialog as fd
import shutil
import os
import datetime

win= Tk()
win.title("File Transfer System")
win.geometry("500x250")
f = Frame(win)

# textvariables to hold user's selection
sourceDir = StringVar()
destDir = StringVar()

# clicking the first 'Browse' btn in GUI invokes this method
def onSelect():
    # global variable is needed for use in fileCheck() method
    global file1
    # 'askdirectory()' opens the the system directory and allows user to select a folder directory
    file1 = fd.askdirectory()
    print("file1:",file1)
    # 'set()' updates the value of variable 'sourceDir' with 'file1'
    sourceDir.set(file1)
    
def onCopy():
    global file2
    file2 = fd.askdirectory()
    destDir.set(file2)

def fileCheck():
    # Returns a list of the file names in the directory given by path
    files = os.listdir(file1)
    print("\nfiles of fileCheck():",files)
    
    for i in files:

        # check for files ending with '.txt' 
        if i.endswith('.txt'):

            # create an absolute path of each file
            abPath = file1+"/"+i
            print("\nabPath:",abPath)

            # get last modified date and today's date
            modDate = datetime.datetime.fromtimestamp(os.path.getmtime(abPath))
            todaysDate = datetime.datetime.today()

            # add 1 day to modDate, to get modified within the last 24 hours
            modDateLimit = modDate + datetime.timedelta(days=1)

            # if modDateLimit is greater than todaysDate, then copy the files to their new destination
            if modDateLimit > todaysDate:
                shutil.copy(abPath, file2)

# Labels
label = Label(f,text="Please select a folder with files to be copied:",bg="lightblue")
label2 = Label(f,text="Please select a folder to receive copied files:",bg="lightblue")
label.grid(row=0,column=1,columnspan=2,padx=(0,0),pady=(20,0),sticky=W)
label2.grid(row=2,column=1,columnspan=2,padx=(0,0),pady=(20,0),sticky=W)

# Entry textbox
entry = Entry(f,width=55,textvariable=sourceDir)
entry2 = Entry(f,width=55,textvariable=destDir)
entry.grid(row=1,column=1,columnspan=2)
entry2.grid(row=3,column=1,columnspan=2)

# Buttons
btn = Button(f,width=10,height=2,text="Browse...",command=onSelect)
btn2 = Button(f,width=10,height=2,text="Browse...",command=onCopy)
btn3 = Button(f,width=35,height=2,text="Process",command=fileCheck)
btn.grid(row=1,column=0,padx=(5,15),pady=(0,0),sticky=W)
btn2.grid(row=3,column=0,padx=(5,15),pady=(0,0),sticky=W)
btn3.grid(row=4,column=1,columnspan=2,padx=(5,15),pady=(0,0,))

f.pack(padx=(0,0),pady=(25,0))


