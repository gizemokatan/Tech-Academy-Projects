
# Encapsulation Assignment

# class Employee
class Employee:
    # initialize the object's values before object is created
    def __init__(self, name, email, salary, pin):
        # protected variable
        self.name = 'Unknown'
        self.email = 'Unknown'
        self._salary = 55000 # protected attribute
        self.__pin = 0123 # private attribute

    # Private method
    def __getPin(self):
        print("Your private pin number: {}", self.__pin)

# Instantiate a class object
emp1 = Employee("Bob Smith", "bobsmith@gmail.com", 60000, 4554)
emp1.name
emp1.email
emp1._salary
emp1._Employee__getPin()
        
     
        
