
#
#   Python:         3.8.5
#
#   Author:         Courtney Dart
#
#   Description:    To write a script that creates a dB and adds
#                   new data into the dB. Practice looking up
#                   files end with '.txt' and printing
#                   the file names to the console.


# leverage the methods in sqlite3 module
import sqlite3

# query1 variable stores the query string needed to be executed
query1 =    "CREATE TABLE IF NOT EXISTS tbl_files(\
            ID INTEGER PRIMARY KEY AUTOINCREMENT, \
            col_fname TEXT \
            )"

fileList = ('information.docx','Hello.txt','myImage.png', \
            'myMovie.mpg', 'World.txt','data.pdf','myPhoto.jpg')

# check for files ending with '.txt' to then be added to txtFileList
txtFileList = []
for file in fileList:
    if file.endswith('.txt'):
        txtFileList.append(file)

# This function establishes a connection to the dB,
# takes each item in txtFileList and inserts it into 
# col_fname, saves changes, then closes the connection
def connAndQuery():
    conn = sqlite3.connect('test2.db')
    with conn:
        cur = conn.cursor()
        cur.execute(query1)
        for i in txtFileList:
            cur.execute("INSERT INTO tbl_files(col_fname) VALUES (?)", \
                        (i,))
        conn.commit()
    conn.close()


# call the function
connAndQuery()






        















