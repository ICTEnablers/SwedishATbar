(function(){

	var pluginName = "festivalTTS";
	var soundmanagerLoaded = false;
	var festivalTTSLoaded = false;
	
    var plugin = function(){

		$lib = AtKit.lib();

		// Internationalisation
		AtKit.addLocalisationMap("en", {
			"festivaltts_dialogTitle" : "Festival streaming text to speech",
			"festivaltts_select" : "Please select text to be read.",
			"festivaltts_prompt" : "errormark",
			"festivaltts_lang" : "en"
		});

		AtKit.addLocalisationMap("se", {
			"festivaltts_dialogTitle" : "Tal till text",
			"festivaltts_select" : "Markera den text du vill ha uppl&aumlst.",
			"festivaltts_prompt" : "errormarkera",
			"festivaltts_lang" : "sv"		
		});
	
		AtKit.addFn('festivalTTSRead', function(){
			//Check for selected text
			var sel = null;
			var selStr = "";
			var lang = AtKit.localisation("festivaltts_lang");
			var selArray = new Array();
			selStr = document.getSelection().toString();
			if(selStr==="") {
				selStr = AtKit.localisation("festivaltts_prompt");
			}
			

		    if(soundmanagerLoaded==true && festivalTTSLoaded==true) { 
		      console.log("soundmanager2.js");
		      soundManager.setup({
		        url: '/festival-tts',
		        preferFlash: false,
		        onready: function() {
		
		        	var festivalTTS = new window.festivalTTS();
			        festivalTTS.play(selStr, lang, function(err) {
				        if (err) {
				            alert(err.toString());
				        }
			        }); 			        
				}
			  });
			}
		});
			
		AtKit.addButton(
			'festivalTTS', 
			AtKit.localisation("festivaltts_dialogTitle"),
			AtKit.getPluginURL() + 'images/sound.png',
			function(dialogs, functions){
				AtKit.call('festivalTTSRead', -1);
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
		AtKit.addScript("https://plugins.atbar.se/festival-tts.js",function festivalttsCallback() { festivalTTSLoaded=true; });
	}

})();
