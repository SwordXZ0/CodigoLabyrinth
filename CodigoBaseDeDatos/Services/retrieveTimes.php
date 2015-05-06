<?php
	    require_once('Setup.php');

	    $times =R::dispense( 'times' );
	    $times= R::findAll('times',"ORDER BY time LIMIT 6");
	    $data = array();

	    foreach ($times as $val) {
	    	$data[] =array('username' => $val->username, 'time' => $val->time );
		}
		echo json_encode($data);
		R::close();
?>