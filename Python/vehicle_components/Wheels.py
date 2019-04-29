class Wheels(object):
    """description of class"""
    def __init__(self, style, material, color):
        self.style = style
        self.material = material
        self.color = color


    def print_wheel_info(self):
        print("Wheel Info:")
        print("Style: {}".format(self.style))
        print("Material: {}".format(self.material))
        print("Color: {}".format(self.color))
