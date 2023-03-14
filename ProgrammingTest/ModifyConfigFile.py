#!/bin/python

from cmath import nan
from configparser import ConfigParser
from fileinput import filename
import sys
import ast

if __name__ == '__main__':
    config = ConfigParser(allow_no_value=True)
    config.sections()

    # cmdline >>python ModifyConfigFile.py filname [sensor_index] newIP
    filename = sys.argv[1]
    sensor_index = sys.argv[2]
    newIP = sys.argv[3]
    
    #Read OriginalControls.ini
    config.read(filename)

    fullIp = "SockerIp"+newIP

    # if sensor_index == nan:
    #     for i in range (10+1):
    #         [i].SocketIP = newIP
    # else:
    #     [sensor_index].SocketIP = newIP

    #We only need sensor settings
    SensorSettingsWithNames = config['EgoVehicleInfo']['SensorSettingsWithNames']
    
    # When no index is mentioned in the input
    if(sensor_index == ""):
        SensorSettingsWithNames.replace("SocketIp:0.0.0.0", fullIp)
    
    
    # if config_object['EgoVehicleInfo']['SensorSettingsWithNames']:
    #     string = config_object.get('EgoVehicleInfo', 'SensorSettingsWithNames').strip().split('\n')
    #     print(string.find("SocketIp"))
        # list_in_list = ast.literal_eval(config_object['EgoVehicleInfo']['SensorSettingsWithNames'])
        # print(list_in_list)

    # for section in config_object.sections():
    #     print(f"[{section}]")
    #     if section == "EgoVehicleInfo":
    #         for key, value in config_object.items(section):
    #             if key == "sensorsettingswithnames":
    #                 print(f"\tfor key {key} -> {value} (value)")
    #                 if value == "[0]":
    #                     print ("found it")
    
#Update the password
# userinfo["password"] = "newpassword"

# #Write changes back to file
# with open('config.ini', 'w') as conf:
#     config_object.write(conf)