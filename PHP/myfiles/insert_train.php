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
$name = $_POST['name'];
$Startingat = $_POST['Startingat'];
$Destination = $_POST['Destination'];
$Arrival = $_POST['Arrival'];
$Dept = $_POST['Dept'];

// $sql = "INSERT INTO Trains (No, Name, Startingat, Destination, Arrival, Dept)
// VALUES ($_POST['no'],
// $_POST['name'],
// $_POST['Startingat'],
// $_POST['Destination'],
// $_POST['Arrival'],
// $_POST['Dept'])";

$sql = "INSERT INTO Trains (No, Name, Startingat, Destination, Arrival, Dept)
VALUES ($No,
'$name',
'$Startingat',
'$Destination',
'$Arrival',
'$Dept')";


if ($conn->query($sql) === TRUE) {
    echo "New train added successfully";
} else {
    echo "Error: " . $sql . "<br>" . $conn->error;
}

$conn->close();
?>

</body>
</html>