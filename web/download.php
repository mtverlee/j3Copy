<?php
    header('Content-Type: application/download');
    header('Content-Disposition: attachment; filename="J3Copy.exe"');
    header("Content-Length: " . filesize("J3Copy.exe"));

    $fp = fopen("J3Copy.exe", "r");
    fpassthru($fp);
    fclose($fp);
?>

