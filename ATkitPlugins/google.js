(function(){

	var pluginName = "google";
	var plugin = function(){
			
		// Internationalisation
		AtKit.addLocalisationMap("en", {
			"google_title" : "Google search",
			"google_prompt" : "You did not select any text.  Enter a search phrase:",
			"google_domain" : "com"
		});

		AtKit.addLocalisationMap("se", {
			"google_title" : "Googlesökning",
			"google_prompt" : "Du har inte markerat någon text. Skriv in dina sökord:",
			"google_domain" : "se"
		});
		
		// Google
		AtKit.addButton(
			'google', 
			AtKit.localisation("google_title"),
			AtKit.getPluginURL() + 'images/google.png',
			function(dialogs, functions){


				q = "" + (window.getSelection ? window.getSelection() : document.getSelection ? document.getSelection() : document.selection.createRange().text); 
				
				if (!q) {
					q = prompt(AtKit.localisation("google_prompt"), ""); 
				}
				if (q!=null) {
					var c="http://www.google."+AtKit.localisation("google_domain")+"/search?q=" + escape(q).replace(/ /g, "+");
					window.open(c); 
				}
				void 0
			
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