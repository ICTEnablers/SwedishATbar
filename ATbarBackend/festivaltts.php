<?php

	$text = $_GET['t'];
	if($text==="errormarkera"){
		$name = "tts" . '/' . "markera.mp3";
		$fp = fopen($name, 'rb');
		
		// send the right headers
		header("Content-Type: audio/mpeg");
		header("Content-Length: " . filesize($name));
		
		// dump the picture and stop the script
		fpassthru($fp);
		
	}
	else {
	   	$mp3  = md5($text) . ".mp3";
	  
	   	$dir = 'tts';
	 
	     $url = 'http://213.188.154.136/festival.php?t=' . urlencode($text);
	     file_put_contents($dir . '/' . $mp3, file_get_contents($url));
	   	
	   	// open the file in a binary mode
		$name = $dir . '/' . $mp3;
		$fp = fopen($name, 'rb');
		
		// send the right headers
		header("Content-Type: audio/mpeg");
		header("Content-Length: " . filesize($name));
		
		// dump the picture and stop the script
		fpassthru($fp);
		unlink($name);
	}
	exit(0);
?>