<?php  

	header("Access-Control-Allow-Origin: *");
	
	class error {
		public $r;
		public $suggestions = array();
		public $offset;
	}
	
	function add_suggestion($suggestions, $test) {
		//return [ "erik", "ivar" ];
		if(in_array($test, $suggestions)) {
			$arrlength = count($suggestions);
			for($a = 0; $a < $arrlength; $a++) {
    			if($suggestions[$a] === $test) {
    				array_splice($suggestions,$a,1);
					break;
    			}
			}
		}
		array_unshift($suggestions, $test);
		return $suggestions;
	}
	
	function beginsWith($str, $start) {
		if(strlen($start)>strlen($str)) {
			return false;
		}
		$str=strtolower($str);
		$start=strtolower($start);
		for($i = 0; $i < strlen($start); $i++) {
			if($str[$i]!=$start[$i]) {
				return false;
			}
		}
		return true;
	}
	
	$lang = $_GET['l'];
	$text = $_GET['r'];
	
    $pspell = pspell_new($lang, "", "", "utf-8", PSPELL_BAD_SPELLERS);
    //$sentence = "Den snaba bruna reven hopade över den latta hunden med vit chorta";
    $words = explode(" ", $text);
	$final = array();
	 

    foreach($words as $word) {
        if (pspell_check($pspell, $word)) {
            // this word is fine; print as-is
            //och
			if($word === "ock" || $word === "Ock") {
				$test = "och";
				$suggestions=add_suggestion($suggestions, $test);				
			}
        } else {
            // this word is bad; look for suggestions
            $suggestions = pspell_suggest($pspell, $word);
		
			$test = $word;
			
			//j instead of g
			if($word[0]=='j' || $word[0]=='J') {
				if($word[0]=='j') {
					$test[0]='g';
				}
				else {
					$test[0]='G';
				}
				if(pspell_check($pspell, $test)) {
					$suggestions=add_suggestion($suggestions, $test);
				}	
			
			}
			//g instead of j
			else if($word[0]=='g' || $word[0]=='G') {
				if($word[0]=='g') {
					$test[0]='j';
				}
				else {
					$test[0]='J';
				}
				if(pspell_check($pspell, $test)) {
					$suggestions=add_suggestion($suggestions, $test);
				}	
			}
			
			//ch instead of sk
			$test=$word;
			$x = strpos($word,"ch");
			if($x!=FALSE || beginsWith($word, "ch")) {
				if($test[$x]=='c') {
					$test[$x] = 's';
				}
				else {
					$test[$x] = 'S';
				}
				$test[$x+1] = 'k';
				if(pspell_check($pspell, $test)) {
					$suggestions=add_suggestion($suggestions, $test);
				}
				else {
					$l = strrpos($word,"ch");
					if($x!=$l) {
						$test=$word;
						$test[$l]='s';
						$test[$l+1]='k';
						if(pspell_check($pspell, $test)) {
							$suggestions=add_suggestion($suggestions, $test);
						}	
					}	
					
				}				
			}
			//sk instead of ch
			$test=$word;
			$x = strpos($word,"sk");
			if($x!=FALSE || beginsWith($word, "sk")) {
				if($test[$x]=='s') {
					$test[$x] = 'c';
				}
				else {
					$test[$x] = 'C';
				}
				$test[$x+1] = 'h';
				if(pspell_check($pspell, $test)) {
					$suggestions=add_suggestion($suggestions, $test);
				}
				else {
					$l = strrpos($word,"sk");
					if($x!=$l) {
						$test=$word;
						$test[$l]='c';
						$test[$l+1]='h';
						if(pspell_check($pspell, $test)) {
							$suggestions=add_suggestion($suggestions, $test);
						}	
					}	
					
				}		
			}
			
			//sk instead of sj
			$test=$word;
			$x = strpos($word,"sk");
			if($x!=FALSE || beginsWith($word, "sk")) {
				$test[$x+1] = 'j';
				if(pspell_check($pspell, $test)) {
					$suggestions=add_suggestion($suggestions, $test);
				}
				else {
					$l = strrpos($word,"sk");
					if($x!=$l) {
						$test=$word;
						$test[$l+1]='j';
						if(pspell_check($pspell, $test)) {
							$suggestions=add_suggestion($suggestions, $test);
						}	
					}	
					
				}		
			}
			//sj instead of sk
			$test=$word;
			$x = strpos($word,"sj");
			if($x!=FALSE || beginsWith($word, "sj")) {
				$test[$x+1] = 'k';
				if(pspell_check($pspell, $test)) {
					$suggestions=add_suggestion($suggestions, $test);
				}
				else {
					$l = strrpos($word,"sj");
					if($x!=$l) {
						$test=$word;
						$test[$l+1]='k';
						if(pspell_check($pspell, $test)) {
							$suggestions=add_suggestion($suggestions, $test);
						}	
					}	
					
				}		
			}
			
			//ije instead of ie
			$test=$word;
			$x = strpos($word,"ije");
			if($x!=FALSE || beginsWith($word, "ije")) {
				$c=0;
				$test=str_replace("ije","ie",$test,$c);		
				if($c==1 && pspell_check($pspell, $test)) {
					$suggestions=add_suggestion($suggestions, $test);
				}
			}
			
			//ks instead of x
			$test=$word;
			$x = strpos($word,"ks");
			if($x!=FALSE || beginsWith($word, "ks")) {
				$c=0;
				$test=str_replace("ks","x",$test,$c);
				if($c==1 && pspell_check($pspell, $test)) {
					$suggestions=add_suggestion($suggestions, $test);
				}
			}
			
			//sj instead of sch
			$test=$word;
			$x = strpos($word,"sj");
			if($x!=FALSE || beginsWith($word, "sj")) {
				$c=0;
				$c1=0;
				$c2=0;
				$test=str_replace("sj","sch",$test,$c1);
				$test=str_replace("Sj","Sch",$test,$c2);
				$c=$c1+$c2;		
				if($c==1 && pspell_check($pspell, $test)) {
					$suggestions=add_suggestion($suggestions, $test);
				}
			}
			//ch instead of sch
			$test=$word;
			$x = strpos($word,"ch");
			if($x!=FALSE) {
				$c=0;
				$c1=0;
				$c2=0;
				$test=str_replace("ch","sch",$test,$c1);
				$test=str_replace("Ch","Sch",$test,$c2);
				$c=$c1+$c2;		
				if($c==1 && pspell_check($pspell, $test)) {
					$suggestions=add_suggestion($suggestions, $test);
				}
			}
			//sk instead of sch
			$test=$word;
			$x = strpos($word,"sk");
			if($x!=FALSE || beginsWith($word, "sk")) {
				$c=0;
				$c1=0;
				$c2=0;
				$test=str_replace("sk","sch",$test,$c1);
				$test=str_replace("Sk","Sch",$test,$c2);
				$c=$c1+$c2;		
				if($c==1 && pspell_check($pspell, $test)) {
					$suggestions=add_suggestion($suggestions, $test);
				}
			}
			
			//sj instead of skj
			$test=$word;
			$x = strpos($word,"sj");
			if($x!=FALSE || beginsWith($word, "sj")) {
				$c=0;
				$c1=0;
				$c2=0;
				$test=str_replace("sj","skj",$test,$c1);
				$test=str_replace("Sj","Skj",$test,$c2);
				$c=$c1+$c2;		
				if($c==1 && pspell_check($pspell, $test)) {
					$suggestions=add_suggestion($suggestions, $test);
				}
			}
			//ch instead of skj
			$test=$word;
			$x = strpos($word, "ch");
			if($x!=FALSE || beginsWith($word,"ch")) { 
				$c=0;
				$c1=0;
				$c2=0;
				$test=str_replace("ch","skj",$test,$c1);		
				$test=str_replace("Ch","Skj",$test,$c2);
				$c=$c1+$c2;
				//$suggestions = ["skjorte", $test];	
				if($c==1 && pspell_check($pspell, $test)) {
					$suggestions=add_suggestion($suggestions, $test);
				}
			}
			//sk instead of sch
			$test=$word;
			$x = strpos($word,"sk");
			if($x!=FALSE || beginsWith($word, "sk")) {
				$c=0;
				$c1=0;
				$c2=0;
				$test=str_replace("sk","skj",$test,$c1);
				$test=str_replace("Sk","Skj",$test,$c2);
				$c=$c1+$c2;		
				if($c==1 && pspell_check($pspell, $test)) {
					$suggestions=add_suggestion($suggestions, $test);
				}
			}
			
			//e instead of ä
			$test=$word;
			$len = strlen($word);
			for($i = 0; $i < $len; $i++) {
    			if($word[$i] == 'e') {
    				$test[$i] = 'ä';	
    				if(pspell_check($pspell, $test)) {
						$suggestions=add_suggestion($suggestions, $test);
						break;
					}
					$test[$i] = 'e';
    			}
			}
			//ä instead of e
			$test=$word;
			$len = strlen($word);
			for($i = 0; $i < $len; $i++) {
    			if($word[$i] == 'ä') {
    				$test[$i] = 'e';	
    				if(pspell_check($pspell, $test)) {
						$suggestions=add_suggestion($suggestions, $test);
						break;
					}
					$test[$i] = 'ä';
    			}
			}
			
			//k instead of ck
			$test=$word;
			$len = strlen($word);
			for($i = 0; $i < $len; $i++) {
    			if($i>0 && $word[$i] == 'k') {
    				$test = substr_replace($test, "c", $i-1, 0);	
    				if(pspell_check($pspell, $test)) {
						$suggestions=add_suggestion($suggestions, $test);
						break;
					}
					$test = $word;
    			}
			}
		
            if (count($suggestions)) {
                // we have suggestions for this word
                if(count($suggestions)>5) {
                	$suggestions=array_slice($suggestions, 0, 5);
                }
                $final[$word] = $suggestions; 
            }
        }
    }
	//header('Content-type: application/json');
	//print json_encode($final);
	//exit(0);
	echo $_GET['callback'] . json_encode($final);
	exit(0);
?>