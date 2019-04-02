<!DOCTYPE html>
<html>
<head>
<title>PHP insertion</title>
<link href="css/insert.css" rel="stylesheet">
</head>
<body>
<div class="maindiv">
<!--HTML Form -->
<div class="form_div">
<div class="title">
<h2>Insert Data In Database Using PHP.</h2>
</div>
<form action="insert.php" method="post">
<!-- Method can be set as POST for hiding values in URL-->
<h2>Form</h2>
<label>Name:</label>
<input class="input" name="name" type="text" value=""><br>
<label>Email:</label>
<input class="input" name="email" type="text" value=""><br>
<label>Contact:</label>
<input class="input" name="contact" type="text" value=""><br>
<label>Address:</label>
<textarea cols="25" name="address" rows="5"></textarea><br><br>
<input class="submit" name="submit" type="submit" value="Insert">
</form>
</div>
</div>
</body>
</html>

<?php
$connection = new mysqli("localhost", "root", "", "mysql"); // Establishing Connection with Server
if(isset($_POST['submit'])){ // Fetching variables of the form which travels in URL
$name = $_POST['name'];
$email = $_POST['email'];
$contact = $_POST['contact'];
$address = $_POST['address'];
if($name !=''||$email !=''){
//Insert Query of SQL
$query = mysql_query("insert into students(student_name, student_email, student_contact, student_address) values ('$name', '$email', '$contact', '$address')");
echo "<br/><br/><span>Data Inserted successfully...!!</span>";
}
else{
echo "<p>Insertion Failed <br/> Some Fields are Blank....!!</p>";
}
}
$connection -> close(); // Closing Connection with Server
?>