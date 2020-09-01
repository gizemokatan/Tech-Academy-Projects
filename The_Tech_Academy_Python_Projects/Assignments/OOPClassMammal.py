#
#   Python: 3.8.5
#
#   Author: Courtney Dart
#
#   Description:    Practice creating classes, utilizing polymorphism
#                   Remember: a child class can override the behavior
#                   of the parent class.

msg = ("Welcome to the Mammal game, where you decide \nwhat each Mammal does or doesn't do. \n\nFirst up...")
print(msg)

# parent class Mammal
class Mammal:
    family = "Bear"
    name = "Grizzly"
    legs = 4
    arms = 0
    carnivore = "y"

    def information(self):
        msg = "\nFamily: {}\nName: {}\nLegs: {}\nArms: {}\nCarnivore: {}".format(self.family,self.name,self.legs,self.arms,self.carnivore)
        print(msg)

    def question(self):
        carnivore = input("\nDoes this mammal eat meat? (Y/N): \n>>> ").lower()
        if (carnivore == self.carnivore):
            print("Bone-appetite!")
        else:
            print("No meat, yay plants!")


# child class Human
class Human(Mammal):
    family = "Homosapien"
    name = "Courtney"
    legs = 2
    arms = 2
    stands_upright = "y"
    gives_handshakes = "y"

    def information(self):
        msg = "\nFamily: {}\nName: {}\nLegs: {}\nArms: {}\nCarnivore: {}\nStands Upright: {}\nGives Handshakes: {}".format(self.family,self.name,self.legs,self.arms,self.carnivore,self.stands_upright,self.gives_handshakes)
        print(msg)
    # polymorphism: child class 'Human' keeps the same function name of their parent class 'Mammal',
    # but we modify the functionality within this method.
    def question(self):
        carnivore = input("\nDoes this mammal eat meat? (Y/N): \n>>> ").lower()
        handshake = input("\nDoes this mammal shake hands? (Y/N): \n>>> ").lower()
        if (carnivore == self.carnivore and handshake == self.gives_handshakes):
            print("Nice to meet you, Human!")
        else:
            print("Sorry, no handshake.")


# child class Bird
class Eagle(Mammal):
    family = "Bird"
    name = "Bald Eagle"
    legs = 2
    arms = 0
    can_fly = "y"
    feathers = "y"
    
    def information(self):
        msg = "\nFamily: {}\nName: {}\nLegs: {}\nArms: {}\nCarnivore: {}\nCan Fly: {}\nHas Feathers: {}".format(self.family,self.name,self.legs,self.arms,self.carnivore,self.can_fly,self.feathers)
        print(msg)
    # polymorphism: child class 'Eagle' keeps the same function name of their parent class 'Mammal',
    # but we modify the functionality within this method.
    def question(self):
        carnivore = input("\nDoes this mammal eat meat? (Y/N): \n>>> ").lower()
        fly = input("\nDoes this mammal fly? (Y/N): \n>>> ").lower()
        if (carnivore == self.carnivore and fly == self.can_fly):
            print("Spread your wings and fly!")
        else:
            print("Sorry, no bird's eye view here...")
    

# the following code invokes the methods inside each class
bear = Mammal()
bear.information()
bear.question()

human1 = Human()
human1.information()
human1.question()

eagle1 = Eagle()
eagle1.information()
eagle1.question()

thanks = "\n\nThanks for playing!"
print(thanks)




    
