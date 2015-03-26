(function(){

	var pluginName = "wiktionary";
	var plugin = function(){
		
		$lib = AtKit.lib();
		
		// Internationalisation
		AtKit.addLocalisationMap("en", {
			"wiktionary_title" : "Look up in Wiktionary",
			"wiktionary_prompt" : "Enter a word to look up on Wiktionary",
			"wiktionary_url" : "http://en.wiktionary.org/w/wiki.phtml?search="
		});

		AtKit.addLocalisationMap("se", {
			"wiktionary_title" : "Slå upp i ordlista",
			"wiktionary_prompt" : "Skriv in det ord du vill slå upp i ordlistan",
			"wiktionary_url" : "http://sv.wiktionary.org/w/wiki.phtml?search="
		});
		
		// Wiki
		AtKit.addButton(
			'wiktionary', 
			AtKit.localisation("wiktionary_title"),
			AtKit.getPluginURL() + 'images/book_open.png',
			function(dialogs, functions){

				try{
					var b=window.getSelection(),a=b?b.toString().replace(/(^\W+|\W+$)/g,''):'';

					if(!a){
						a=prompt(AtKit.localisation("wiktionary_prompt"));
						if(!a)return
					}
					var c=AtKit.localisation("wiktionary_url")+encodeURIComponent(a);
					window.open(c)
				}	
				catch(d){
					alert('Error:\n'+d.message)
				}
			
			},
			null, null
		);

	};

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
			};
		}

		window['AtKitLoaded'] = new AtKitLoaded();
		window['AtKitLoaded'].subscribe(function(){ AtKit.registerPlugin(pluginName, plugin); });
	} else {
		AtKit.registerPlugin(pluginName, plugin);
	}

})();