<?php
    function OpenCon()
    {
        $dbhost = "localhost";
        $dbuser = "root";
        $dbpass = "";
        $db = "performance_schema";
        $conn = new mysqli($dbhost, $dbpass, $dbuser, $dbpass) or die("Connection Failed %s\n". $conn->error);
        return $conn;
    }

    function CloseCon($conn){
        $conn -> close();
    }
?>