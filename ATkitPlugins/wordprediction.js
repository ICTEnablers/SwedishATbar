(function(){

	var pluginName = "wordprediction";
	var plugin = function(){

		$lib = AtKit.lib();
		
		var wpTimeout;

		// Internationalisation
		AtKit.addLocalisationMap("en", {
			"wp_title" : "Word Prediction",
			"wp_ignore": "Ignore",
			"wp_instruct": "Keystrokes: esc to close, Ctrl + Alt + (1, 2, 3 etc)"
		});
		
		AtKit.addLocalisationMap("se", {
			"wp_title" : "Ordprediktering",
			"wp_ignore": "Ignorera",
			"wp_instruct": "esc f&oumlr att st&aumlnga, Ctrl + Alt + (1, 2, 3 etc)"
		});


		AtKit.addLocalisationMap("ar", {
			"wp_title" : "&#1578;&#1588;&#1594;&#1610;&#1604; &#1605;&#1602;&#1578;&#1585;&#1581; &#1575;&#1604;&#1603;&#1604;&#1605;&#1575;&#1578;",
			"wp_ignore": "&#1578;&#1580;&#1575;&#1607;&#1604;",
			"wp_instruct": "&#1605;&#1601;&#1575;&#1578;&#1610;&#1581;: Esc &#1604;&#1604;&#1582;&#1585;&#1608;&#1580;&#1548; Ctrl+Alt+(1,2,3...)"	
		});
		
		AtKit.set('WordPrediction_TextSelected', null);
		
		$lib('input[type="text"], textarea').bind('focus', function(){
			AtKit.set('WordPrediction_TextSelected', $lib(this));
		});

		AtKit.addFn('getCaretPos', function(input){
			input = input[0];
			
			var caret_pos;
			// Internet Explorer Caret Position (TextArea)
			if (document.selection && document.selection.createRange) {
				var range = document.selection.createRange();
				var bookmark = range.getBookmark();
				caret_pos = bookmark.charCodeAt(2) - 2;
			} else {
				// Firefox Caret Position (TextArea)
				if (input.setSelectionRange)
				caret_pos = input.selectionStart;
			}
			
			return caret_pos;
		});
		
		
		AtKit.addFn('setCaretPos', function(args){
			var elem = args.input[0];
		
			if(elem !== null) {
				if(elem.createTextRange) {
					var range = elem.createTextRange();
					range.move('character', args.position);
					range.select();
				} else {
					if(elem.selectionStart) {
						elem.focus();
						elem.setSelectionRange(args.position, args.position);
					} else {
						elem.focus();
					}
				}
			}
		});

		function unicodeConvert(str) {
			var aring = String.fromCharCode(229);
			var auml = String.fromCharCode(228);
			var ouml = String.fromCharCode(246); 
			var aaring = String.fromCharCode(197);
			var aauml = String.fromCharCode(196);
			var oouml = String.fromCharCode(214);
			var eacute = String.fromCharCode(233);
			str=str.replace("\\u00e5",aring);
			str=str.replace("\\u00e4",auml);
			str=str.replace("\\u00f6",ouml);
			str=str.replace("\\u00c5",aaring);
			str=str.replace("\\u00c4",aauml);
			str=str.replace("\\u00d6",oouml);
			str=str.replace("\\u00e9",eacute);
			//str=str.replace("\\u00a3","£");
			//str=str.replace("\\u20ac","€");
			return str;
		}
		
		function htmlConvert(str) {
			str=str.replace("&aring","å");
			str=str.replace("&auml","ä");
			str=str.replace("&ouml","ö");
			str=str.replace("&Aring","Å");
			str=str.replace("&Auml","Ä");
			str=str.replace("&Ouml","Ö");
			str=str.replace("&eacute","é");
			//str=str.replace("\\u00a3","£");
			//str=str.replace("\\u20ac","€");
			return str;
		}
		
		AtKit.addButton(
			'wordprediction',
			AtKit.localisation("wp_title"),
			AtKit.getPluginURL() + 'images/aitype.png',
			function(dialogs, functions){

				ctrlModifier = false;
				altModifier = false;

				$lib('input[type="text"], textarea').bind('keydown', function(e){
					if(e.which == 17 || e.which == 18 || ctrlModifier || altModifier) return; // ctrl & alt keys ignore.
					
					clearTimeout(wpTimeout);
					
					var textElement = $lib(this);
					
					if(e.keyCode == 27) return $lib('#AtKitWordPrediction').remove();
					if(e.keyCode == 32) {
					wpTimeout = setTimeout(function(){
						var el = AtKit.get('WordPrediction_TextSelected');
						if(el === null) return;
					
						var elData = el.val();
						var input = new Array();
						var pos = AtKit.call('getCaretPos', el);
						AtKit.set('WordPrediction_CaretPos', pos);
						
						var leadingText = elData.substring(0, pos).split(" ").slice(-6).join(" ");
						var trailingText = elData.substring(pos).split(" ").slice(0, 2).join(" ");
						input[0] = leadingText.length;
						input[1] = trailingText.length;
						//console.log("lead: "+leadingText+" trail: "+trailingText);
						var predictURL = "https://core.atbar.se/ordprediktering.php?ord="; 
						//"https://predict.services.atbar.org/wordprediction/";

						/*if(AtKit.getLanguage() == "ar") {
							predictURL += "?lang=AR";
						} else {
							predictURL += "?lang=EN";
						}*/
						var index = leadingText.length-2;
						var word = leadingText;
						while(index>0) {
							if(leadingText[index]==' ' || leadingText[index]=='.' || leadingText[index]==',' || leadingText[index]=='!' || leadingText[index]=='?' || leadingText[index]==':' || leadingText[index]==';') {
								word = leadingText.slice(index,leadingText.length-1);
								break;
							}
							index--;
						}
						word=word.trim();
						
						predictURL+=encodeURIComponent(word);
						//predictURL += encodeURIComponent(word);//"&l=" + encodeURIComponent(leadingText) + "&t=" + encodeURIComponent(trailingText) + "&callback=?";
				  		var suggestionsArray = new Array();
	      				$lib.getJSON(predictURL, function(response){
							//console.log(response);
						    var depIndex = 0;
						    var dep = "";
						    var miIndex = 0;
						    var mi = "";
						    var v = 0;
						    while(response.length>0 && response.indexOf("dep\":\"")!=-1){
							  depIndex = response.indexOf("dep\":\"");
							  response = response.slice(depIndex+6,response.length-1);
							  depIndex=0;
							  while(depIndex<response.length && response[depIndex]!='.' && response[depIndex]!='\"') {
							  	dep+=response[depIndex];
							  	depIndex++;
							  }
							  dep=unicodeConvert(dep);
							  miIndex = response.indexOf("mi");
							  response = response.slice(miIndex,response.length-1);
							  miIndex=4;
							  while(miIndex<response.length && response[miIndex]!='.') {
							  	mi+=response[miIndex];
							  	miIndex++;
							  }
							  response = response.slice(miIndex,response.length-1);
							  //console.log("mi: "+mi+" dep: "+dep);
							  
							  if(mi.length>0) {
								  v = parseInt(mi.trim());
								  suggestionsArray.push( { word:dep, val:v } );//suggestionIndex] = suggestion;
							  }
							  dep = "";
							  mi = "";
							}
							
							var sortedArray = suggestionsArray.sort(function(a,b) {
							    return a.val - b.val;
							});
							
							var data = new Array();
							var dataIndex = 0;
							var suggestionObject;
							var suggestionStr = "";
							var exists = false;
							while(sortedArray.length>0 && dataIndex<5) {
								suggestionObject = sortedArray.pop();
								//console.log("word: "+suggestionObject.word+" val: "+suggestionObject.val);
								suggestionStr = " "+suggestionObject.word;
								for(var j=0;j<dataIndex;j++) {
									if(suggestionStr === data[j]) {
										exists = true;
									}
								}
								if(exists==false) {
									data[dataIndex] = suggestionStr;
									//console.log("added: "+suggestionStr);
									dataIndex++;
								}
								exists = false;
							}
							
							//var data = response.payload.split(";");
							
							//var input = data.splice(0, 2);

							// Remove any digits signifying liklihood
							//$lib.each(input, function(i, v){
							//	if(!isNaN(input[i].charAt(0))) input[i] = input[i].substring(1);
							//});

							//console.log(input);

							var pos = el.position();
							var width = el.width();
							var height = el.outerHeight();


							var suggestions = "";

							if($lib('#AtKitWordPrediction').length === 0){
								suggestions = $lib('<div>', { "id": "AtKitWordPrediction" }).css({
									"position": "absolute",
									"left": pos.left + "px",
									"width": width,
									"top": (5 + pos.top + height) + "px",
									"background": "white",
									"font-size": "16pt",
									"font-weight": "bold",
									"color": "black",
									"border": "2px solid black",
									"z-index": "9999999999",
									"padding": "10px"
								});
							} else {
								suggestions = $lib('#AtKitWordPrediction').empty();
							}
							
							
							suggestions.append(
								$lib("<a>", { "href": "#", "html": AtKit.localisation("wp_ignore"), "style": "color:red;padding-right:10px;float:left;" }).bind('click', function(){
									$lib('#AtKitWordPrediction').remove();
									el.focus();
								})
							);

							for(i = 0; i < data.length; i++){
								var suggestion = data[i];
									
								if(suggestion == "") continue;
								
								// Get number 0-9 representing likelihood of word being correct.
								var likelihood = suggestion.charAt(0);

								// Remove the liklihood from the string.
								suggestion = suggestion.substring(1);

								var link = $lib('<a>', { "html": suggestion, "href": "#", "style": "padding-right:10px;float:left;" }).data('suggestion', suggestion).bind('click', function(e){
									var pos = AtKit.get('WordPrediction_CaretPos');
									var toInsert = $lib(this).data('suggestion') + " ";
									//console.log("1ins: "+toInsert);
									//toInsert = htmlConvert(toInsert);
									console.log("ins: "+toInsert);
									var el = AtKit.get('WordPrediction_TextSelected');
	
									var start = pos;// - input[0].length;
									var end = pos + toInsert.length;//input[1].length;
									
									//console.log('Caret position: ' + pos + ", inserting text '" + toInsert + "'");
									//console.log("at pos start " + start + ", end " + end + " identified substring is '" + el.val().substring(start, end) + "'");
									
									el.val( el.val().substring(0, start) + toInsert + el.val().substring(end) );
									
									suggestions.remove();
									
									el.focus();

									AtKit.call('setCaretPos', {
										input: el,
										position: start + toInsert.length
									});
									
									e.preventDefault();
									return false;
								});
								
								suggestions.append(link);
							}
							
							
							// Add the information div.
							var info = $lib('<p>', { "html": AtKit.localisation("wp_instruct"), "style": "font-size:12pt; padding-top:10px;clear:left" });
							
							suggestions.append(info);
							
							// Insert the suggestions into the DOM
							el.after(suggestions);
							
							// Bind shortcutkeys
							
							textElement.keyup(function (e) {
								if(e.keyCode == 17) ctrlModifier = false;
								if(e.keyCode == 18) altModifier = false;
							}).keydown(function (e) {
								if(e.keyCode == 17) ctrlModifier = true;
								if(e.keyCode == 18) altModifier = true;
								
								offset = 48;
								// Are the modifier keys held down?
								if(ctrlModifier && altModifier && (e.keyCode >= 49 && e.keyCode <= 57)) {
									numKey = e.keyCode - offset;
									
									ctrlModifier = false;
									altModifier = false;
									
									$lib('#AtKitWordPrediction').children('a:eq(' + numKey + ')').click();
									
									if(e.preventDefault){ e.preventDefault()
									}else{e.stop()};
									
									e.returnValue = false;
									e.stopPropagation();  
									
									textElement.trigger('keydown');
								}	
							});

						});
					
					}, 500);
					}
				});
			}
		);

	};

	if(typeof window['AtKit'] == "undefined"){

		window.AtKitLoaded = function(){
			var eventAction = null;
		
			this.subscribe = function(fn) {
				eventAction = fn;
			};
		
			this.fire = function(sender, eventArgs) {
				if (eventAction !== null) {
					eventAction(sender, eventArgs);
				}
			};
		};

		window['AtKitLoaded'] = new AtKitLoaded();
		window['AtKitLoaded'].subscribe(function(){ AtKit.registerPlugin(pluginName, plugin); });
	} else {
		AtKit.registerPlugin(pluginName, plugin);
	}

})();