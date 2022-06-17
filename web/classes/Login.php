<?php

class Login
{
    private $db_connection = null;
    public $errors = array();
    public $messages = array();

    public function __construct()
    {
        session_start();

        if (isset($_GET["logout"])) {
            $this->doLogout();
        }
        elseif (isset($_POST["login"])) {
            $this->dologinWithPostData();
        }
    }

    private function dologinWithPostData()
    {
        if (empty($_POST['user_name'])) {
            $this->errors[] = "Username field was empty.";
        } elseif (empty($_POST['user_password'])) {
            $this->errors[] = "Password field was empty.";
        } elseif (!empty($_POST['user_name']) && !empty($_POST['user_password'])) {

            $this->db_connection = new mysqli(DB_HOST, DB_USER, DB_PASS, DB_NAME);

            if (!$this->db_connection->set_charset("utf8")) {
                $this->errors[] = $this->db_connection->error;
            }

            if (!$this->db_connection->connect_errno) {

                $user_name = $this->db_connection->real_escape_string($_POST['user_name']);

                $sql = "SELECT user_name, user_email, user_password_hash
                        FROM users
                        WHERE user_name = '" . $user_name . "' OR user_email = '" . $user_name . "';";
                $result_of_login_check = $this->db_connection->query($sql);

                if ($result_of_login_check->num_rows == 1) {

                    $result_row = $result_of_login_check->fetch_object();

                    if (password_verify($_POST['user_password'], $result_row->user_password_hash)) {

                        $_SESSION['user_name'] = $result_row->user_name;
                        $_SESSION['user_email'] = $result_row->user_email;
                        //require '/var/www/html/2fa/GoogleAuthenticator/PHPGangsta/GoogleAuthenticator.php';
                        //$authenticator = new PHPGangsta_GoogleAuthenticator();
                        //$secret = 'K3FYK6YTNZLBWFXT';
                        //$otp = $_POST['2fa'];
                        //$tolerance = 2;
                        //$checkResult = $authenticator->verifyCode($secret, $otp, $tolerance);    
                        //if ($checkResult) 
                        //{
                        //    $_SESSION['user_login_status'] = 1;    
                        //} else {
                        //    $this->errors[] = "The 2FA code was incorrect.";
                        //}
                        // Change the line below to your timezone!
                        date_default_timezone_set('America/Denver');
                        $notify_date = date('m/d/Y h:i:s a', time());
                        $notify_ip_address = $_SERVER['REMOTE_ADDR'];
                        $notify_message = "Someone logged into J3Copy web interface from " . $notify_ip_address . " at " . $notify_date . ".";
                        curl_setopt_array($ch = curl_init(), array(
                        CURLOPT_URL => "https://api.pushover.net/1/messages.json",
                        CURLOPT_POSTFIELDS => array(
                            "token" => "an8jtv5ioertadqbb97uzcup5o4c6t",
                            "user" => "ue2k5xfgv2xrq7gc3gucpvg1qjbees",
                            "message" => $notify_message,
                            "title" => "Login",
                        ),
                        CURLOPT_SAFE_UPLOAD => true,
                        ));
                        curl_setopt($ch, CURLOPT_RETURNTRANSFER, 1);
                        curl_exec($ch);
                        curl_close($ch);
                        unset($notify_date, $notify_ip_address, $notify_message, $response);                  
                        $_SESSION['user_login_status'] = 1; 
                    } else {
                        $this->errors[] = "Wrong password. Try again.";
                    }
                } else {
                    $this->errors[] = "This user does not exist.";
                }
            } else {
                $this->errors[] = "Database connection problem.";
            }
        }
    }

    public function doLogout()
    {
        $_SESSION = array();
        session_destroy();
        $this->messages[] = "You have been logged out.";

    }

    public function isUserLoggedIn()
    {
        if (isset($_SESSION['user_login_status']) AND $_SESSION['user_login_status'] == 1) {
            $_SESSION['user_login_ok_status'] = 1;
            $_SESSION['user_login_ok_j3copy'] = true;
            return true;
        }
        return false;
    }
}
