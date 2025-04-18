
<?php
$dsn="mysql:host=localhost;dbname=CRM_DB";
$dbusername="root";
$dbpassword="";

try {
    $pdo = new PDO($dsn,$dbusername,$dbpassword);
    $pdo ->setAttribute(PDO::ATTR_ERRMODE,PDO::ERRMODE_EXCEPTION);
} catch (PDO) {
    echo "Connection Failed: ". $e ->getMessage(); 
    die();
    
}
$connec->beginTransaction();
$result = $connec->exec("INSERT INTO user_details (userid, password, fname, lname, gender, dtob, country, user_rating, emailid) VALUES
('abcd123', '123@John', 'John', 'ray', 'M', '1992-06-11', 'USA', '130', 'John123@example-site.com')");
$connec->commit();
echo $result;	
?>
	
 
