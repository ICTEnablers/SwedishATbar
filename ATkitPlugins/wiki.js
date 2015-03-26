(function(){

	var pluginName = "wiki";
	var plugin = function(){
		
		$lib = AtKit.lib();
		
		// Internationalisation
		AtKit.addLocalisationMap("en", {
			"wiki_title" : "Search Wikipedia",
			"wiki_prompt" : "Enter a word to look up on Wikipedia",
			"wiki_url" : "http://en.wikipedia.org/w/wiki.phtml?search="
		});

		AtKit.addLocalisationMap("se", {
			"wiki_title" : "Sök på Wikipedia",
			"wiki_prompt" : "Skriv in det ord du vill sök efter på Wikipedia",
			"wiki_url" : "http://sv.wikipedia.org/w/wiki.phtml?search="
		});
		
		// Wiki
		AtKit.addButton(
			'wiki', 
			AtKit.localisation("wiki_title"),
			AtKit.getPluginURL() + 'images/wikipedia.png',
			function(dialogs, functions){

				try{
					var b=window.getSelection(),a=b?b.toString().replace(/(^\W+|\W+$)/g,''):'';

					if(!a){
						a=prompt(AtKit.localisation("wiki_prompt"));
						if(!a)return
					}
					var c=AtKit.localisation("wiki_url")+encodeURIComponent(a);
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