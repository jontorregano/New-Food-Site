<?php

	$server="localhost";
	$user="tutorial"
	$pass="password"
	$db="tutorials"
		
	// connect to mysql
	
	mysql_connect($server, $user, $pass) or die("sorry, can't connect to the mysql");
												
	// select the db
												
	mysql_select_db($db) or die("sorry, can't select the database.");

?>