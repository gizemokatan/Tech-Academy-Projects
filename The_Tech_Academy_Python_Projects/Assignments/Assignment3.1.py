
#
#   Python:         3.8.5
#
#   Author:         Courtney Dart
#
#   Description:    Version 2
#                   To write a script that creates a dB and adds
#                   new data into the dB. Practice looking up
#                   files end with '.txt' and printing
#                   the file names to the console.


# leverage the methods in sqlite3 module
import sqlite3

# connect the the dB
conn = sqlite3.connect('test3.db')

fileList = ('information.docx','Hello.txt','myImage.png', \
            'myMovie.mpg', 'World.txt','data.pdf','myPhoto.jpg')

# with connection open, we can operate on the dB using the cursor() method
with conn:
    cur = conn.cursor()
    # call the execute command and pass in the sql statement
    # using a back slack '\' will allow the same statement to continue on a new line
    cur.execute("CREATE TABLE IF NOT EXISTS tbl_files(\
                ID INTEGER PRIMARY KEY AUTOINCREMENT, \
                col_fname TEXT \
                )")
    # check for files ending with '.txt' to then be inserted into the dB
    for file in fileList:
        if file.endswith('.txt'):
            cur.execute("INSERT INTO tbl_files(col_fname) VALUES (?)", \
                        (file,))
            print(file)
            
    # commit will save any changes to the dB
    conn.commit()
# close the connection
conn.close()
