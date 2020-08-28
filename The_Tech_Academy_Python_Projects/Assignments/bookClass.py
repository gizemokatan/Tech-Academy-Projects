#
#   Demonstrate creating classes and inheritance
#   Set attributes with default values

class Book:
    isbn = '980-3-16-148410-0'
    author = 'No Name Provided'
    publisher = 'Penguin'
    price = 0
    title = ' '
    isDigital = True

class Magazine(Book):
    company_name = 'Vogue'
    company_industry = 'Fashion'
    editor = 'Jacob Childs'
    page_designer = 'Samantha Green'
    edition = 12

class Textbook(Book):
    school_subject = 'Chemistry'
    teacher = 'Ms. Sweeney'
    class_code = 101
    isRequired = False
    
    
