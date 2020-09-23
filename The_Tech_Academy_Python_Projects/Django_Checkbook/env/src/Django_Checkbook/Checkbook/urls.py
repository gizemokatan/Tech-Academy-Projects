from django.urls import path
# the '.' states that we will import a file within this same directory, in our case the 'Checkbook' directory.
from . import views

# the urlpatterns list routes URLs to the views methods.
urlpatterns = [
    path('', views.home, name='index'),
    path('create/', views.create_account, name='create'),
    path('<int:pk>/balance/', views.balance, name='balance'),
    path('transaction/', views.transaction, name='transaction'),
]