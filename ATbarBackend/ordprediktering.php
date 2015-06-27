<?php
 	header('content-type: application/json; charset=utf-8');
 	header("Access-Control-Allow-Origin: *");
	
 	$word = $_GET['ord'];
    
	$final = array();
	
    $url = 'http://spraakbanken.gu.se/ws/korp?command=relations&type=word&corpus=ROMI&word=' . $word;
	
	$output = file_get_contents($url);
	
	echo $_GET['callback'] . json_encode($output);
	exit(0);
?>