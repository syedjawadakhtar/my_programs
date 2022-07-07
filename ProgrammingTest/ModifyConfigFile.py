#!/bin/python

from cmath import nan
from configparser import ConfigParser
from fileinput import filename
import sys

if __name__ == '__main__':
    config_object = ConfigParser(allow_no_value=True)

    filename = sys.argv[1]
    #Read OriginalControls.ini
    config_object.read(filename)
    print ("The config file name is ", filename)

    sensor_index = sys.argv[2]

    newIP = sys.argv[3]

    if sensor_index == nan:
        for i in range (10+1):
            [i].SocketIP = newIP
    else:
        [sensor_index].SocketIP = newIP

    #We only need sensor settings
    # config_object["SensorSettingsWithNames"] = {
    #     SocketIp = 127.0.0.1
    # }