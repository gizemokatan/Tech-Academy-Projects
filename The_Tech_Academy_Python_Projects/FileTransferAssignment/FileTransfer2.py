
# Description:  Utilize shutil, os, and datetime modules
#               Practice file transfering files that were
#               modified within the last 24 hours.
#
# NOTE:         print statements are for development purposes

import shutil
import os
import datetime

source = 'C:\\Tech-Academy-Projects\\The_Tech_Academy_Python_Projects\\FileTransferAssignment\\createmodify\\'

destination = '/Tech-Academy-Projects/The_Tech_Academy_Python_Projects/FileTransferAssignment/dailycopies'

# Returns a list of the file names in the directory given by path
files = os.listdir(source)
#print(files)

for i in files:

    # create an absolute path of each file
    abPath = source+i
    #print(abPath)
    
    # get last modified date and today's date
    modDate = datetime.datetime.fromtimestamp(os.path.getmtime(abPath))
    todaysDate = datetime.datetime.today()

    # add 1 day to modDate, to get modified within the last 24 hours
    modDateLimit = modDate + datetime.timedelta(days=1)

    # if modDateLimit is greater than todaysDate, then copy the files to their new destination
    if modDateLimit > todaysDate:
        shutil.copy(abPath, destination)
