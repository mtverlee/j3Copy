<?php
require_once '/var/www/html/base_code/PHPMailer-master/PHPMailerAutoload.php';
$email = 'j3copynotify@gmail.com';
$password = 'lagfFt%78';
$to_id = 'sverlee@j3engineering.net';
$to_id2 = '7205059472@tmomail.net';
$to_id3 = '7206353431@tmomail.net';
$message = $_POST['message'];
$message_formatted = 'Hello!' . "</br></br>" . 'A new version of J3Copy is available for download! You can download it here: https://matt-server.info/j3copy/.' . "<br>" . 'Please do not reply to this message, as it is sent from an automated account that does not accept replies.' . "</b></br></br>" . 'Thanks!'. "</br></br>". 'Matt-VPS';
$message_formatted2 = 'Hello! A new version of J3Copy is available for download! You can download it in the J3Copy web interface.';

$subject = 'J3Copy Update Notification';
$mail = new PHPMailer(true);
$mail->isSMTP();
$mail->Host = 'smtp.gmail.com';
$mail->Port = 587;
$mail->SMTPSecure = 'tls';
$mail->SMTPAuth = true;
$mail->Username = $email;
$mail->Password = $password;
$mail->AddAddress($to_id);
//$mail->AddAddress($to_id2);
//$mail->AddAddress($to_id3);
$mail->Subject = $subject;
$mail->FromName = 'J3Copy';
$mail->msgHTML($message_formatted);
curl_setopt_array($ch = curl_init(), array(
CURLOPT_URL => "https://api.pushover.net/1/messages.json",
CURLOPT_POSTFIELDS => array(
    "token" => "an8jtv5ioertadqbb97uzcup5o4c6t",
    "user" => "ue2k5xfgv2xrq7gc3gucpvg1qjbees",
    "message" => $message_formatted2,
    "title" => "Update Available",
),
CURLOPT_SAFE_UPLOAD => true,
));
curl_setopt($ch, CURLOPT_RETURNTRANSFER, 1);
curl_exec($ch);
curl_close($ch);
header('Location: https://matt-server.info/j3copy/index.php');

