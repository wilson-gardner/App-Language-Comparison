from vehicle_components.Engine import Engine
from vehicle_components.Wheels import Wheels
from constructs.Vehicle import Vehicle

engine = Engine("VFR850", 8, 848, 13, 16)
wheels = Wheels("Sport", "Carbon Fiber", "Black")
mycar = Vehicle("335BXY", "Boxy", engine, wheels)

mycar.engine.get_details()
mycar.wheels.print_wheel_info()
