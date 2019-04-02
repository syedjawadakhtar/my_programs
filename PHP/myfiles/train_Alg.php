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


$sql = "INSERT INTO Train_Alg_Scheduled
(Train_No, arriv, dept)
VALUES 
(14084, '09:05:00', '09:10:00')";

if ($conn->query($sql) === TRUE) {
    echo "Timimng added successfully for train";
} else {
    echo "Error: " . $sql . "<br>" . $conn->error;
}

$sql = "INSERT INTO Train_Alg_Scheduled
(Train_No, arriv, dept)
VALUES 
(04072, '00:15:00', '00:17:00')";

if ($conn->query($sql) === TRUE) {
    echo "Timimng added successfully for train";
} else {
    echo "Error: " . $sql . "<br>" . $conn->error;
}

$sql = "INSERT INTO Train_Alg_Scheduled
(Train_No, arriv, dept)
VALUES 
(12401, '09:00:00', '09:05:00')";

if ($conn->query($sql) === TRUE) {
    echo "Timimng added successfully for train";
} else {
    echo "Error: " . $sql . "<br>" . $conn->error;
}

$sql = "INSERT INTO Train_Alg_Scheduled
(Train_No, arriv, dept)
VALUES 
(12417, '04:25:00', '04:28:00')";

if ($conn->query($sql) === TRUE) {
    echo "Timimng added successfully for train";
} else {
    echo "Error: " . $sql . "<br>" . $conn->error;
}

$sql = "INSERT INTO Train_Alg_Scheduled
(Train_No, arriv , dept )
VALUES 
(12553, '04:11:00', '04:16:00')";

if ($conn->query($sql) === TRUE) {
    echo "Timimng added successfully for train";
} else {
    echo "Error: " . $sql . "<br>" . $conn->error;
}

$sql = "INSERT INTO Train_Alg_Scheduled
(Train_No, arriv , dept )
VALUES 
(12397, '01:43:00', '01:45:00')";

if ($conn->query($sql) === TRUE) {
    echo "Timimng added successfully for train";
} else {
    echo "Error: " . $sql . "<br>" . $conn->error;
}

$conn->close();
?>

</body>
</html>