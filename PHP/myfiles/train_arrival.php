<html>
<body>

<?php
$servername = "localhost";
$username = "root";
$password ="";
$dbname = "myDB";

// Create connection
$conn = new mysqli($servername, $username, $password, $dbname);
// Check connection
if ($conn->connect_error) {
    die("Connection failed: " . $conn->connect_error);
} 


$sql = "INSERT INTO Train_Alg_Arrival
(Train_No, sun_arriv, mon_arriv, tue_arriv, wed_arriv, thu_arriv, fri_arriv, sat_arriv)
VALUES
(14084, '09:15:00', '09:07:00', '09:30:00', '09:12:00', '09:06:00','10:00:00', '10:30:00')";

if ($conn->query($sql) === TRUE) {
    echo "Arrival Timing added successfully for train\n";
} else {
    echo "Error: " . $sql . "<br>" . $conn->error;
}

$sql = "INSERT INTO Train_Alg_Arrival
(Train_No, sun_arriv, mon_arriv, tue_arriv, wed_arriv, thu_arriv, fri_arriv, sat_arriv)
VALUES
(04072, NULL , NULL , NULL, NULL, NULL,NULL, '00:30:00')";

if ($conn->query($sql) === TRUE) {
    echo "Arrival Timing added successfully for train\n";
} else {
    echo "Error: " . $sql . "<br>" . $conn->error;
}

$sql = "INSERT INTO Train_Alg_Arrival
(Train_No, sun_arriv, mon_arriv, tue_arriv, wed_arriv, thu_arriv, fri_arriv, sat_arriv)
VALUES
(12401, '09:15:00','09:20:00','09:00:00','09:05:00','09:30:00','09:15:00', '90:35:00')";

if ($conn->query($sql) === TRUE) {
    echo "Arrival Timing added successfully for train\n";
} else {
    echo "Error: " . $sql . "<br>" . $conn->error;
}

$sql = "INSERT INTO Train_Alg_Arrival
(Train_No, sun_arriv, mon_arriv, tue_arriv, wed_arriv, thu_arriv, fri_arriv, sat_arriv)
VALUES
(12417, '04:35:00','04:28:00','04:29:00','04:50:00','05:00:00','04:25:00','09:25:00')";

if ($conn->query($sql) === TRUE) {
    echo "Arrival Timing added successfully for train\n";
} else {
    echo "Error: " . $sql . "<br>" . $conn->error;
}

$sql = "INSERT INTO Train_Alg_Arrival
(Train_No, sun_arriv, mon_arriv, tue_arriv, wed_arriv, thu_arriv, fri_arriv, sat_arriv)
VALUES
(12553, '04:15:00','04:21:00','04:31:00','04:11:00','04:11:00','04:12:00','04:13:00')";

if ($conn->query($sql) === TRUE) {
    echo "Arrival Timing added successfully for train\n";
} else {
    echo "Error: " . $sql . "<br>" . $conn->error;
}

$sql = "INSERT INTO Train_Alg_Arrival
(Train_No, sun_arriv, mon_arriv, tue_arriv, wed_arriv, thu_arriv, fri_arriv, sat_arriv)
VALUES
(12397, '01:45:00','01:50:00','01:43:00','01:43:00','01:43:00','01:43:00','02:00:00')";

if ($conn->query($sql) === TRUE) {
    echo "Arrival Timing added successfully for train\n";
} else {
    echo "Error: " . $sql . "<br>" . $conn->error;
}

$conn->close();
?>

</body>
</html>