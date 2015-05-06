<?php
	if(isset($_POST['user']) && isset($_POST['time'])){
	    require_once('Setup.php');

	    $time =R::dispense( 'times' );
	    $time->username=$_POST['user'];
	    $time->time=$_POST['time'];
	    R::store($time);
	    echo "succeed";
	    R::close();
	}else{
		echo "error: No parameters";
	}
?>