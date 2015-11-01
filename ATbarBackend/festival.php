<?php
// define the temporary directory
// and where audio files will be written to after conversion
$tmpdir = "/tmp";
$audiodir = "/tmp";

$speech = $_GET['t'];

  $save_mp3 = true;

    // current date (year, month, day, hours, mins, secs)
    $currentdate = date("ymdhis",time());
    // get micro seconds (discard seconds)
    list($usecs,$secs) = microtime();
    // unique file name
    $filename = "{$currentdate}{$usecs}";
    // other file names
    $speech_file = "{$tmpdir}/{$filename}";
    $wave_file = "{$audiodir}/{$filename}.wav";
    $mp3_file  = "{$audiodir}/{$filename}.mp3";
    $volume_scale = 5;

    // open the temp file for writing
    $fh = fopen($speech_file, "w+");
    if ($fh) {
      fwrite($fh, $speech);
      fclose($fh);
    }

    // if the speech file exists, use text2wave
    if (file_exists($speech_file)) {
      // create the text2wave command and execute it
      $text2wave_cmd = sprintf("/usr/bin/festival/festival/bin/text2wave -o %s -scale %d %s",$wave_file,$volume_scale,$speech_file);
      exec($text2wave_cmd);

      // create an MP3 version?
      if ($save_mp3) {
        // create the lame command and execute it
        $lame_cmd = sprintf("lame %s %s",$wave_file,$mp3_file);
        exec($lame_cmd);
        // delete the WAV file to conserve space
        unlink($wave_file);
      }

      // delete the temp speech file
      unlink($speech_file);


      // open the file in a binary mode
      $fp = fopen($mp3_file, 'rb');

      // send the right headers
      header("Content-Type: audio/mpeg");
      header("Content-Length: " . filesize($mp3_file));

      // dump the picture and stop the script
      fpassthru($fp);
      unlink($mp3_file);
  }
?>
