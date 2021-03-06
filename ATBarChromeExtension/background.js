var ATBar = "javascript:(function(){d=document;jf=d.createElement('script');jf.src='https://core.atbar.se/atbar.min.js';jf.type='text/javascript';jf.id='ToolBar';d.getElementsByTagName('head')[0].appendChild(jf);})();javascript:(function(){d=document;jf=d.createElement('script');jf.src='https://core.atbar.se/atbar.min.js';jf.type='text/javascript';jf.id='ToolBar';d.getElementsByTagName('head')[0].appendChild(jf);})();";
var ATBarRemove = "window.location.reload(true);";
var enabledTabs = new Array();
var enabledTabIds = new Array();

var dbString = localStorage.getItem("enabledSites");
if(dbString != ""){
	var tmpStoredTabs = JSON.parse(localStorage.getItem("enabledSites"));
	if(tmpStoredTabs != null && tmpStoredTabs.length > 0) enabledTabs = tmpStoredTabs;
}

// Called when the user clicks on the browser action.
chrome.browserAction.onClicked.addListener(function(tab) {

if(enabledTabs.length == 0) {
	startATBar(tab.url, tab.id);
	return;
}

if((tab.url in oc(enabledTabs)) == false){
	startATBar(tab.url, tab.id);
} else {
	removeATBar(tab.url, tab.id);
}

});


// Add a listener for on change.
chrome.tabs.onUpdated.addListener(function(tabId, changeInfo, tab) {
	if(changeInfo.status == "complete"){
		// Should we load ATBar?
		if(tab.url in oc(enabledTabs)){
			startATBar(tab.url, tabId);
		}
	}
});

// Add listener to change tab
chrome.tabs.onSelectionChanged.addListener(function(tabId, selectInfo) {
	changeIcon(tabId);
});

function changeIcon(tabId){
	if(tabId in oc(enabledTabIds)) {
		chrome.browserAction.setIcon({path:"icon48_selected.png"});
	} else {
		chrome.browserAction.setIcon({path:"icon48.png"});
	}
}

function startATBar(url, tabId){
	chrome.tabs.executeScript(null, {code:ATBar});
	
	if((url in oc(enabledTabs)) == false) {
		enabledTabs.push(url);
		enabledTabIds.push(tabId);
		
		localStorage.setItem("enabledSites", JSON.stringify(enabledTabs));
	}
	
	// Set the icon.
	changeIcon(tabId);
}

function removeATBar(url, tabId){
	chrome.tabs.executeScript(null, {code: ATBarRemove});
	
	if(url in oc(enabledTabs)) enabledTabs.splice(enabledTabs.indexOf(url), 1);	
	if(tabId in oc(enabledTabIds)) enabledTabIds.splice(enabledTabIds.indexOf(tabId), 1);	
	
	localStorage.setItem("enabledSites", JSON.stringify(enabledTabs));
	
	// Set the icon.
	changeIcon(tabId);
}

function oc(a){
	var o = {};
	for(var i=0; i < a.length;i++){
		o[a[i]]="";
	}
	return o;
}
