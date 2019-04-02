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

$No = $_POST['no'];
$Day = $_POST['day'];

if ($Day == 'Sunday')
    $day = 'sun_arriv';

//DECLARE @ans TIME 
$sql = "
SELECT
(train_alg_arrival.sun_arriv -  train_alg_scheduled.arriv)
FROM train_alg_arrival, train_alg_scheduled
WHERE
Train_Alg_Arrival.Train_no = Train_Alg_Schedule.Train_No";


if ($conn->query($sql) === TRUE) {
    echo "$sql Delay";
} else {
    echo "Error: " . $sql . "<br>" . $conn->error;
}

$conn->close();
?>

</body>
</html>