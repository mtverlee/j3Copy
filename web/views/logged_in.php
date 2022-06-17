<?php
   $page_id = 'j3copy';
   require_once('../base_code/data_collect.php');
   $data_collect = new dataCollection;
   $data_collect->collect($page_id);
   session_start();
   if ($_SESSION['user_login_ok_j3copy'] != 1) {
   	session_destroy();
   	header("Location: index.php");
   }
   ?>
<!DOCTYPE html>
<html lang="en">
   <head>
      <meta charset="utf-8">
      <meta name="viewport" content="width=device-width, initial-scale=1.0">
      <title>J3Copy</title>
      <link rel="shortcut icon" href="images/favicon.ico" type="image/x-icon">
      <link rel="icon" href="images/favicon.ico" type="image/x-icon">
      <link href="css/bootstrap.css" rel="stylesheet" media="screen">
      <link href="css/main.css" rel="stylesheet" media="screen">
      <style>
         .table td.fit, .table th.fit {
         white-space: nowrap;
         width: 1%;
         }
         .table {
         border-radius: 5px;
         width: 50%;
         float: none;
         }
         a.list-group-item-custom {
         background-color: #3ca3e1;
         color: black;
         }
         input.btn-custom {
         background-color: #3ca3e1;
         color: black;
         }
         .table-responsive
         {
         overflow-x: auto;
         }
         table {
         background-color: white;
         }
      </style>
   </head>
   <body>
      <div class="container-fluid">
         <div class="form-signin">
            <!--<div class="alert alert-success">You are <strong>logged in</strong>.</div>-->
            <div class="row">
               <h3>J3Copy</h3>
               <?php require_once("login_buttons_j3copy.php"); ?>
            </div>
         </div>
         <div class="table-responsive">
            <h3>J3Copy Log Information</h3>
            <small>Most Recent 35 Entries - (Scroll left/right if on mobile.)</small><br>
            <?php
               $con=mysqli_connect("127.0.0.1","j3copy","P@ssw0rd!","j3copy");
               // Check connection
               if (mysqli_connect_errno())
               {
                 echo "Failed to connect to MySQL: " . mysqli_connect_error();
               }
               $result = mysqli_query($con,"SELECT * FROM logging ORDER BY datetime DESC LIMIT 35");
               
               echo "<br>";
               echo "<table class='table table-bordered centeredText' style='width:100%;' align='center'>
               <tr>
               <th><center>Date/Time</center></th>
               <th><center>Action Details</center></th>
               <th><center>J3Copy Version</center></th>
               </tr>";
               
               while($row = mysqli_fetch_array($result))
               {
                 echo "<tr>";
                 echo "<td>" . $row['datetime'] . "</td>";
                 echo "<td>" . $row['info'] . "</td>";
                 echo "<td>" . $row['version'] . "</td>";
                 echo "</tr>";
               }
               echo "</table>";
               mysqli_close($con);
               ?>
         </div>
      </div>
      </div>
   </body>
   <?php require_once("/var/www/html/base_code/subfooter.php"); ?>
   </br>
   <p> All information and content on this site is © <b>Matt VerLee, 2017</b>.</p>
   <br>
   <br>
</html>

