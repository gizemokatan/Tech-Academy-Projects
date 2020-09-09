
# File transfer assignment

import shutil
import os

#set where the source of the files are
source = '/Users/marti/Desktop/Python/A/'
#set destination path to folder B
destination = '/Users/marti/Desktop/Python/B/'
files = os.listdir(source)

for i in files:
    #move the files represented by 'i' to their new destination
    shutil.move(source+i, destination)
