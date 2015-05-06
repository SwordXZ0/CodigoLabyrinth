<?php
    if(isset($_POST['user']) && isset($_POST['password']) && isset($_POST['email'])){
	    require_once('Setup.php');


	    $user =R::dispense( 'users' );
	    $res= R::findOne('users',"name='".$_POST['user']."'");
	    $data="succeed";
	    if($res!=NULL){
			$data="repeated";
		}else{
			$user->name=$_POST['user'];
			$user->pass=$_POST['password'];
			$user->email=$_POST['email'];
	     	R::store($user);
		}
		echo $data;
		R::close();
	}else{
		echo "error: No parameters";
	}
?>