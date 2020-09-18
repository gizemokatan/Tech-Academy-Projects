from django.db import models

class djangoClasses(models.Model):
    title = models.CharField(max_length=60)
    course_num = models.IntegerField()
    instructor_name = models.CharField(max_length=100, default="")
    duration = models.FloatField()

    objects = models.Manager()

    def __str__(self):
        return self.title

c1 = djangoClasses.objects.update_or_create(title="English", course_num=201, instructor_name="Jackie Dunn", duration=1.5)
c2 = djangoClasses.objects.update_or_create(title="Biology", course_num=305, instructor_name="Dan Smith", duration=2.0)
c3 = djangoClasses.objects.update_or_create(title="Mathematics", course_num=400, instructor_name="Rachel Bloom", duration=1.5)

