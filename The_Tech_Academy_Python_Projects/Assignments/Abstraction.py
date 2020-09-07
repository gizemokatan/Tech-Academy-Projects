
# Abstraction Assignment

from abc import ABC, abstractmethod

# base/abstract class Building
class Building(ABC):
    def enter(self):
        print("I am entering...")

    @abstractmethod
    def exit(self, throughWhat):
        pass

# child class 
class School(Building):
    def exit(self, throughWhat):
        print("Exiting through ",throughWhat)

# child class 
class Church(Building):
    def exit(self, throughWhat):
        print("Exiting through ",throughWhat)

# Instantiation of child classes
brockport = School()
brockport.enter()
brockport.exit("the front door")
viewChurch = Church()
viewChurch.enter()
viewChurch.exit("the gate")
