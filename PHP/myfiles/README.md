# Instructions to run the above programs
## Note: These all have been tested on a Windows OS.
## Note: The user name is ```root``` and theres no password.
To run the above programs I have used **XAMPP**.
Before running any of the files on localhost; make sure that Apache and MySQL is running on XAMPP

Information of the files:
1. *create_database.php* - for creating a database ```myDB```.
2. *create_tables.php* - for creating 3 tables viz.:
	* ```Trains``` - storing information about **Train number, name, starting station, destination station, departure time** and **arrival time**
	* ```Train_Alg_Schedule``` - storing information of the Train No as a Foreign Key of the table ```Trains```, and the **Arrival** and 
		**Departure** time at **Aligarh** station.
	* ```Train_Alg_Arrival``` - storing the data which includes the usual arrival of the train on different days of the week - (This will be used to 
		check the delay of the train).
3. *insert_train.php* - includes the sql command to take values from the for the details of the train - *This file is linked to **train_form.html** *.
4. *train_Alg.php* - storing directly into the database for the **scheduled** arrival and the departure times of the train in ```Aligarh```.
5. *train_arrival.php* - storing directly into the database for the **expected** arrival and the departure times of the train in ```Aligarh```.    

**Rest all the files are either incomplete or were used for testing purposes.**
