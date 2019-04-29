class Engine(object):
    """description of class"""
    def __init__(self, model_number, cylinders, horse_power, city_mpg, hwy_mpg):
        self.model_number = model_number
        self.cylinders = cylinders
        self.horse_power = horse_power
        self.city_mpg = city_mpg
        self.hwy_mpg = hwy_mpg
        

    def get_details(self):
        print("Vehicle Engine Details")
        print("Model No.: {}".format(self.model_number))
        print("Cylinders: {}".format(self.cylinders))
        print("Horsepower: {}".format(self.horse_power))
        print("City MPG: {}".format(self.city_mpg))
        print("Highway MPG: {}".format(self.hwy_mpg))
