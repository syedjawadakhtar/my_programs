<?php
$servername = "localhost";
$username = "root";
$password = "";
$dbname = "myDB";

// Create connection
$conn = new mysqli($servername, $username, $password, $dbname);
// Check connection
if ($conn->connect_error) {
    die("Connection failed: " . $conn->connect_error);
} 

// sql to create table
$sql = "CREATE TABLE TRAINS 
(
No INT NOT NULL,
Name VARCHAR(20),
Startingat VARCHAR(20),
Destination VARCHAR(20),
Arrival TIME,
Dept TIME,
PRIMARY KEY (No))
";

if ($conn->query($sql) === TRUE) {
    echo "Table Trains created successfully";
} else {
    echo "Error creating table: " . $conn->error;
}

// sql to create scheduled timing table
$sql = "CREATE TABLE Train_Alg_Scheduled
(
Train_No INT NOT NULL,
arriv TIME,
dept TIME,
PRIMARY KEY (Train_No),
FOREIGN KEY (Train_No) REFERENCES TRAINS(No) 
)";

if ($conn->query($sql) === TRUE) {
    echo "Table Train_Alg_Scheduled created successfully";
} else {
    echo "Error creating table: " . $conn->error;
}

// sql to create arrival timing table
$sql = "CREATE TABLE Train_Alg_Arrival
(
Train_No INT NOT NULL,
sun_arriv TIME,
mon_arriv TIME,
tue_arriv TIME,
wed_arriv TIME,
thu_arriv TIME,
fri_arriv TIME,
sat_arriv TIME,
PRIMARY KEY (Train_No),
FOREIGN KEY (Train_No) REFERENCES TRAINS(No) 
)";

if ($conn->query($sql) === TRUE) {
    echo "Table Train_Alg_Arrival created successfully";
} else {
    echo "Error creating table: " . $conn->error;
}

$conn->close();
?>