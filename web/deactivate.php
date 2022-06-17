<?php 

    session_start();
    if ($_SESSION['user_name'] == 'mtverlee') {
        $servername = "localhost";
        $username = "j3copy";
        $password = "P@ssw0rd!";
        $dbname = "j3copy";
        $conn = new mysqli($servername, $username, $password, $dbname);
        if ($conn->connect_error) {
            die("Connection failed: " . $conn->connect_error);
        } 
        $sql = "UPDATE licensing SET license_status='deactivated'";
        $conn->query($sql);
        $conn->close();
        header('Location: https://matt-server.info/j3copy/');
    } else {
        header('Location: https://matt-server.info/j3copy/');
    }

?>
