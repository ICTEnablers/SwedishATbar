<?php
 
 	$lang = $_GET['l'];
	$text = $_GET['r'];
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
	 
	     $url = 'http://translate.google.com/translate_tts?ie=UTF-8&tl=' . $lang . '&q=' . urlencode($text) .  '&key=';
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