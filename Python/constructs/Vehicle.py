from vehicle_components.Engine import Engine
from vehicle_components.Wheels import Wheels

class Vehicle(object):
    """description of class"""
    def __init__(self, model_number, model_name, engine, wheels):
        self.model_number = model_number
        self.model_name = model_name
        self.engine = engine
        self.wheels = wheels
