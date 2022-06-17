<?php
//DATABASE CONNECTION VARIABLES
$host = "localhost"; // Host name
$username = "j3copy"; // Mysql username
$password = "P@ssw0rd!"; // Mysql password
$db_name = "j3copy"; // Database name

//DO NOT CHANGE BELOW THIS LINE UNLESS YOU CHANGE THE NAMES OF THE MEMBERS AND LOGINATTEMPTS TABLES

$tbl_prefix = ""; //***PLANNED FEATURE, LEAVE VALUE BLANK FOR NOW*** Prefix for all database tables
$tbl_members = $tbl_prefix."members";
$tbl_attempts = $tbl_prefix."loginAttempts";
