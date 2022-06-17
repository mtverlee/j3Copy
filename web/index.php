<?php
if (version_compare(PHP_VERSION, '5.3.7', '<')) {
    exit("Sorry, you need a PHP version newer than 5.3.7!");
} else if (version_compare(PHP_VERSION, '5.5.0', '<')) {
    require_once("libraries/password_compatibility_library.php");
}
require_once("config/db.php");
require_once("classes/Login.php");
$login = new Login();
if ($login->isUserLoggedIn() == true) {
    include("views/logged_in.php");

} else {
    include("views/not_logged_in.php");
}
