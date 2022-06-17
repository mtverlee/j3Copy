<?php

session_start();
   if ($_SESSION['user_login_ok_j3copy'] != 1) {
   	session_destroy();
   	header("Location: index.php");
   }

?>
<html>
<head>
    <title>Register Users</title>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link href="css/bootstrap.css" rel="stylesheet" media="screen">
    <link href="css/main.css" rel="stylesheet" media="screen">
</head>
<body>
<div class="container-fluid">
      <form class="form-signin" method="post" action="signup.php" name="registerform">
        <center><h2 class="centeredText">Register</h2>
        <p class="centeredText">Please complete the following fields.</p>
        <input name="user_username" id="user_username" type="text" class="form-control" placeholder="Username" autocapitalize="none" autofocus required>
        <input name="user_email" id="user_email" type="text" class="form-control" placeholder="Email Address" autocapitalize="none" autofocus required>
        <input name="user_password" id="user_password" class="form-control" placeholder="Password" autocapitalize="none" required >
        <br>
        <input type="submit"  name="registerform" value="Register User" class="btn btn-primary btn-block"/></center>
        <a class="btn btn-block btn-primary" href="index.php">Return to J3Copy</a>
      </form>
</body>
</html>

<?php
if (isset($_POST['registerform'])) {
    $servername = "localhost";
    $username = "j3copy";
    $password = "P@ssw0rd!";
    $dbname = "j3copy";

    // Create connection
    $conn = new mysqli($servername, $username, $password, $dbname);
    // Check connection
    if ($conn->connect_error) {
        die("Connection failed: " . $conn->connect_error);
    } 

    $user_password = $_POST['user_password'];
    $user_password_hash = password_hash($user_password, PASSWORD_DEFAULT);

    $sql = "INSERT INTO users (user_name, user_password_hash, user_email)
    VALUES ('" . $_POST['user_username'] . "', '" . $user_password_hash . "', '" . $_POST['user_email'] . "')";

    if ($conn->query($sql) === TRUE) {
        echo "<div class='alert alert-success'><center>New user (" . $_POST['user_username'] . ") was created successfully!</div>";
    } else {
        echo "<div class='alert alert-danger'><center>Error: " . $conn->error . "</div>";
    }

    $conn->close();
}


?>