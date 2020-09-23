from django.db import models

class Account(models.Model):
    first_name = models.CharField(max_length=50)
    last_name = models.CharField(max_length=50)
    initial_deposit = models.DecimalField(max_digits=15, decimal_places=2)

    # NOTE: We do the line below to then be able to name our account object. On the
    # https://docs.djangoproject.com/en/2.2/topics/db/managers/#manager-names
    # documentation, it says you must define a class attribute of type models.Manager() on
    # the model we're on.
    Accounts = models.Manager()

    # Python's integrated dunder method __str__() can convert an object name to a string value that
    # would make more sense to the user.
    def __str__(self):
        return self.first_name + ' ' + self.last_name

# A dictionary with key/value pairs for the 'type' field.
TransactionTypes = [('Deposit', 'Deposit'), ('Withdrawal', 'Withdrawal')]

class Transaction(models.Model):
    date = models.DateField()
    type = models.CharField(max_length=10, choices=TransactionTypes)
    amount = models.DecimalField(max_digits=15, decimal_places=2)
    description = models.CharField(max_length=100)
    # A ForeignKey field represents a many-to-one relationship. It requires two positional arguments:
    # the class to which the model is related and the on_delete option.
    # this is the foreign key to an account object
    account = models.ForeignKey(Account, on_delete=models.CASCADE)

    Transactions = models.Manager()