#!/bin/python

from cmath import nan
from configparser import ConfigParser
from fileinput import filename
import sys
import ast

if __name__ == '__main__':
    config_object = ConfigParser(allow_no_value=True)
    config_object.sections()

    # python ModifyConfigFile.py filname [sensor_index] newIP
    filename = sys.argv[1]
    sensor_index = sys.argv[2]
    newIP = sys.argv[3]
    
    #Read OriginalControls.ini
    config_object.read(filename)


    # if sensor_index == nan:
    #     for i in range (10+1):
    #         [i].SocketIP = newIP
    # else:
    #     [sensor_index].SocketIP = newIP

    #We only need sensor settings
    if config_object['EgoVehicleInfo']['SensorSettingsWithNames']:
        String = config_object.get('EgoVehicleInfo', 'SensorSettingsWithNames').strip().split('\n')
        print("SocketIP" in String)
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