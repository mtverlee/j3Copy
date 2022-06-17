<html>
  <head>
    <title>J3Copy Login</title>
    <meta charset="UTF-8">
    <link href="https://matt-server.info/style.css" rel="stylesheet" type="text/css">
    <meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no">
    <link rel='shortcut icon' type='image/x-icon' href='/var/www/html/base_code/favicon.ico'>
    <link href="css/bootstrap.css" rel="stylesheet" media="screen">
    <link href="css/main.css" rel="stylesheet" media="screen">
    <script language="javascript">
    function toggle() {
      var ele = document.getElementById("toggleText");
      var text = document.getElementById("displayText");
      if(ele.style.display == "block") {
          ele.style.display = "none";
      text.innerHTML = "(More)";
        }
      else {
        ele.style.display = "block";
        text.innerHTML = "(Hide)";
      }
    }
    </script>
    <style>
    a.list-group-item-custom {
      background-color: #3ca3e1;
      color: black;
    }
    </style>
    <?php require_once('/var/www/html/base_code/privatedaddy.php'); ?>
  </head>
  <body>
    </br>
    <div class="centeredText">
    <div class="container-fluid">
    <div class="row">
    <a href="http://www.j3engineering.net/"><img src = "images/j3_logo.png" class="col-lg-4 col-md-4 col-sm-8 col-xs-12 col-lg-offset-4 col-md-offset-4 col-sm-offset-2 img-fluid"></a>
    </div>
    <?php
if (isset($login)) {
    if ($login->errors) {
        foreach ($login->errors as $error) {

            echo "<center><div class='alert alert-danger'>" . $error . "</div><center>";
        }
    }
    if ($login->messages) {
        foreach ($login->messages as $message) {
            echo "<center><div class='alert alert-success'>" . $message . "</div></center>";
        }
    }
}
?>
      </br>
      <div class="container">
      <form class="form-signin" method="post" action="index.php" name="loginform">
        <h2 class="centeredText">J3Copy</h2>
        <p class="centeredText">Please log in.</p>
        <input name="user_name" id="login_input_username" type="text" class="form-control" placeholder="Username" autocapitalize="none" autofocus required>
        <input name="user_password" id="login_input_password" type="password" class="form-control" placeholder="Password" autocapitalize="none" required >
        <input type="submit"  name="login" value="Log In" class="btn btn-primary btn-block"/>
      <form>
      </div>
    </div>
    <?php require_once("/var/www/html/base_code/subfooter.php"); ?>
    </br>
    <p> All information and content on this site is © <b>Matt VerLee, 2017</b>.</p>
  </body>
</html>
