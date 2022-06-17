<div>
  <a class="btn btn-lg btn-primary btn-block" href="logout.php">Log Out</a>
</div>
<div>
  <a class="btn btn-lg btn-primary btn-block" href="https://www.dropbox.com/s/8zqffntriabbwq2/J3Copy_Release.zip?dl=1">Download J3Copy</a>
  <a class="btn btn-lg btn-primary btn-block" href="https://www.microsoft.com/en-us/download/details.aspx?id=23217">Download Sync SDK</a>
</div>
<?php
session_start();
if ($_SESSION['user_name'] == 'mtverlee') {
    echo "<br>";
    echo "<h3>Admin Functions</h3>";
    echo "<div><a class='btn btn-lg btn-primary btn-block' href='signup.php' target='_blank'>Register Users</a></div>";
    echo "<div><a class='btn btn-lg btn-primary btn-block' href='https://www.dropbox.com/sh/kg4nlm8gc68radq/AABWkxwGhP_ADpgTJGaZ_BD1a?dl=0' target='_blank'>J3Copy Dropbox</a></div>";
    echo "<div><a class='btn btn-lg btn-primary btn-block' href='https://freedcamp.com/login' target='_blank'>Bugs/Feature Requests</a></div>";
    echo "<div><a class='btn btn-lg btn-primary btn-block' href='https://matt-server.info/phpmyadmin/' target='_blank'>PHPMyAdmin</a></div>";
    echo "<br>";
    echo "<h3>Developer Functions</h3>";
    echo "<div><a class='btn btn-lg btn-primary btn-block' href='https://matt-server.info/j3copy/send_notification.php'>Send Update Notification</a></div>";
    $db = new PDO('mysql:host=localhost;dbname=j3copy', 'j3copy', 'P@ssw0rd!');
    $stmt = $db->query("SELECT license_status FROM licensing WHERE application='j3copy' LIMIT 1");
    $id = $stmt->fetchColumn(0);
    if ($id == 'activated') {
        echo "<div><a class='btn btn-lg btn-danger btn-block' href='deactivate.php'>Deactivate J3Copy</a></div>";
    }
    if ($id == 'deactivated') {
        echo "<div><a class='btn btn-lg btn-success btn-block' href='activate.php'>Activate J3Copy</a></div>";
    }
    echo "<br><h4>Testing:</h4>";
    $link = @mysqli_connect('localhost', 'mtverlee', 'lagfFt%78');
    if(!$link) {
        echo "<div><a class='btn btn-lg btn-danger btn-block disabled' href=''>Can not connect to MySQL server.</a></div>";
    } else {
        echo "<div><a class='btn btn-lg btn-success btn-block disabled' href=''>Can connect to MySQL server.</a></div>";
    }
    if(!@mysqli_select_db($link, 'j3copy')) {
        echo "<div><a class='btn btn-lg btn-danger btn-block disabled' href=''>Can not connect to J3Copy database.</a></div>";
    } else {
        echo "<div><a class='btn btn-lg btn-success btn-block disabled' href=''>Can connect to J3Copy database.</a></div>";
    }  
} else if ($_SESSION['user_name'] == 'sverlee') {
    echo "<br>";
    echo "<h3>Admin Functions</h3>";
    echo "<div><a class='btn btn-lg btn-primary btn-block' href='signup.php' target='_blank'>Register Users</a></div>";
    echo "<div><a class='btn btn-lg btn-primary btn-block' href='https://www.dropbox.com/sh/kg4nlm8gc68radq/AABWkxwGhP_ADpgTJGaZ_BD1a?dl=0' target='_blank'>J3Copy Dropbox</a></div>";
    echo "<div><a class='btn btn-lg btn-primary btn-block' href='https://freedcamp.com/login' target='_blank'>Bugs/Feature Requests</a></div>";
    echo "<br><h3>Testing:</h3>";
    $link = @mysqli_connect('localhost', 'mtverlee', 'lagfFt%78');
    if(!$link) {
        echo "<div><a class='btn btn-lg btn-danger btn-block disabled' href=''>Can not connect to MySQL server.</a></div>";
    } else {
        echo "<div><a class='btn btn-lg btn-success btn-block disabled' href=''>Can connect to MySQL server.</a></div>";
    }
    if(!@mysqli_select_db($link, 'j3copy')) {
        echo "<div><a class='btn btn-lg btn-danger btn-block disabled' href=''>Can not connect to J3Copy database.</a></div>";
    } else {
        echo "<div><a class='btn btn-lg btn-success btn-block disabled' href=''>Can connect to J3Copy database.</a></div>";
    } 
} else {
    echo "<br>";
    echo "<h3>Other Functions</h3>";
    echo "<div><a class='btn btn-lg btn-primary btn-block' href='https://freedcamp.com/login' target='_blank'>Bugs/Feature Requests</a></div>";
}
?>
