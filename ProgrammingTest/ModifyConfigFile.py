#!/bin/python

from configparser import ConfigParser
from fileinput import filename  # File handling
import sys                      # for cmd line arguments
import re                       # for regular expressions

if __name__ == '__main__':
    config = ConfigParser(allow_no_value=True)

    # cmdline >>python ModifyConfigFile.py filname [sensor_index] newIP
    if len(sys.argv) == 3:
        filename = sys.argv[1]
        newIP = str(sys.argv[2])
         
        #Read the configutation file
        config.read(filename)
        
        for sensor_index in range (11):
            input_str=config['EgoVehicleInfo']['SensorSettingsWithNames']
            input_str = re.sub(r'\s+', '', input_str)
        
            pattern = r"\[%d\]={([^}]*).*?SocketIp=([\d\.]+)" % sensor_index
            match = re.search(pattern, input_str)

            # If there is a match, extract the SocketIp value and replace it
            if match:
                socket_ip = match.group(2)
                print(f"Socket IP for sensor {sensor_index}: {socket_ip}")
                new_settings = input_str.replace(socket_ip, newIP)
                
                # Adding spaces in the string to look good
                input_str = re.sub(r'\s+', '', input_str)
                input_str = re.sub(r'([^\{\}\[\]\(\)=,]+)(=)', r'\1 = ', input_str)

                # print(input_str) # Debugging

                # Write new SensorSettingsWithNames to config file
                config['EgoVehicleInfo']['SensorSettingsWithNames'] = new_settings
                with open(filename, 'w') as f:
                    config.write(f)
                
                new_match = re.search(pattern, new_settings)
                socket_ip = new_match.group(2)
                print(f"Changed Socket IP for sensor {sensor_index}: {socket_ip}")

            else:
                print(f"Sensor data not found for index {sensor_index}")
    
    elif len(sys.argv) == 4:
        filename = sys.argv[1]
        sensor_index = int(sys.argv[2])
        newIP = str(sys.argv[3])
        
        #Read the configutation file
        config.read(filename)
        
        if config['EgoVehicleInfo']['SensorSettingsWithNames']:
            input_str=config['EgoVehicleInfo']['SensorSettingsWithNames']
            input_str = re.sub(r'\s+', '', input_str)
        
            pattern = r"\[%d\]={([^}]*).*?SocketIp=([\d\.]+)" % sensor_index
            match = re.search(pattern, input_str)

            # If there is a match, extract the SocketIp value and replace it
            if match:
                socket_ip = match.group(2)
                print(f"Socket IP for sensor {sensor_index}: {socket_ip}")
                new_settings = input_str.replace(socket_ip, newIP)
                # Adding spaces in the string to look good
                input_str = re.sub(r'\s+', '', input_str)
                input_str = re.sub(r'([^\{\}\[\]\(\)=,]+)(=)', r'\1 = ', input_str)

                # print(input_str) # Debugging

                # Write new SensorSettingsWithNames to config file
                config['EgoVehicleInfo']['SensorSettingsWithNames'] = new_settings
                with open(filename, 'w') as f:
                    config.write(f)
                
                new_match = re.search(pattern, new_settings)
                socket_ip = new_match.group(2)
                print(f"Changed Socket IP for sensor {sensor_index}: {socket_ip}")

            else:
                print(f"Sensor data not found for index {sensor_index}")
