<?php
    if(isset($_POST['user']) && isset($_POST['password'])){
	    require_once('Setup.php');

		$res =R::dispense( 'users' );
		$res =R::findOne('users',"name='".$_POST['user']."' and pass='".$_POST['password']."'");

        $data = "false";
		if($res!=NULL){
			$data=$res['name'];
		}
		echo $data;
		R::close();
	}else{
		echo "error: No parameters";
	}
?>