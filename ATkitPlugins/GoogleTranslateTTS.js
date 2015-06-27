(function(){

	var pluginName = "GoogleTranslateTTS";
	var soundmanagerLoaded = false;
	var googleTTSLoaded = false;
	
    var plugin = function(){

		$lib = AtKit.lib();

		// Internationalisation
		AtKit.addLocalisationMap("en", {
			"translatetts_dialogTitle" : "Google streaming text to speech",
			"translatetts_select" : "Please select text to be read.",
			"translatetts_prompt" : "errormark",
			"translatetts_lang" : "en"
		});

		AtKit.addLocalisationMap("se", {
			"translatetts_dialogTitle" : "Google str&oumlmmad tal till text",
			"translatetts_select" : "Markera den text du vill ha uppl&aumlst.",
			"translatetts_prompt" : "errormarkera",
			"translatetts_lang" : "sv"		
		});
	
		AtKit.addFn('translateTTSRead', function(){
			//Check for selected text
			var sel = null;
			var selStr = "";
			var lang = AtKit.localisation("translatetts_lang");
			var selArray = new Array();
			selStr = document.getSelection().toString();
			if(selStr==="") {
				selStr = AtKit.localisation("translatetts_prompt");
			}
			

		    if(soundmanagerLoaded==true && googleTTSLoaded==true) { 
		      console.log("soundmanager2.js");
		      soundManager.setup({
		        url: '/google-tts',
		        preferFlash: false,
		        onready: function() {
		
		        	var googleTTS = new window.GoogleTTS();
			        googleTTS.play(selStr, lang, function(err) {
				        if (err) {
				            alert(err.toString());
				        }
			        }); 			        
				}
			  });
			}
		});
			
		AtKit.addButton(
			'GoogleTranslateTTS', 
			AtKit.localisation("translatetts_dialogTitle"),
			AtKit.getPluginURL() + 'images/sound.png',
			function(dialogs, functions){
				AtKit.call('translateTTSRead', -1);
			},
			null, null
		);

	}

	if(typeof window['AtKit'] == "undefined"){

		window.AtKitLoaded = function(){
			var eventAction = null;
		
			this.subscribe = function(fn) {
				eventAction = fn;
			};
		
			this.fire = function(sender, eventArgs) {
				if (eventAction != null) {
					eventAction(sender, eventArgs);
				}
			}
		}

		window['AtKitLoaded'] = new AtKitLoaded();
		window['AtKitLoaded'].subscribe(function(){ AtKit.registerPlugin(pluginName, plugin); });
	} else {
		console.log("Registering: "+pluginName);
		AtKit.registerPlugin(pluginName, plugin);
		AtKit.addScript("https://plugins.atbar.se/soundmanager2.js",function soundmanagerCallback() { soundmanagerLoaded=true; });
		AtKit.addScript("https://plugins.atbar.se/google-tts.js",function googlettsCallback() { googleTTSLoaded=true; });
	}

})();
