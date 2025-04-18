<?php


$Department = $_POST["Department"];
$Issue = $_POST["uIssue"];

echo $Issue;
?>
<br>
<?php
echo "You have selected ";
switch ($Department) {
    case '0':
        echo "Customer Care";
        break;

    case '1':
        echo "Sales";
        break;
    case '2': 
        echo "Pricing";       
        
        break;
    case '3':
        echo "IT";
        break;
    default:
        echo "Kindly add a relevant department";
        break;
}


