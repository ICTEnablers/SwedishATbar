<?php

function atbar_options()
{
	
	$version_option = get_option('atbar_version');
	$marketplace_toolbar_option = get_option('atbar_marketplace_toolbar');
	$persistent_option = get_option('atbar_persistent');
	$exclude_option = get_option('atbar_exclude');
	$exclude_pages_option = get_option('atbar_exclude_pages');
	$exclude_option = get_option('atbar_launcher_exclude');
	$exclude_launcher_pages_option = get_option('atbar_launcher_exclude_pages');
	$atbar_launcher_image_option = get_option('atbar_launcher_image');
	$atbar_shortcode_align_option = get_option('atbar_shortcode_align_option');
	
?>
	
	<div class="wrap">
	<div id="icon-options-general" class="icon32"><br /></div>
	<h2>Atbar inställningar</h2>
	
	<form method="post" action="options.php">
	<? settings_fields("atbar_options"); ?>
	
	<p><b>För instruktioner om detta plugin se <a href="http://www.atbar.se/wordpress-plugin-guide">ATbar Wordpress plugin-guide</a>.</b></p>
	
	<p>ATbar-widgeten kan läggas till under Appearance, välj sedan Widgets där lägger du till svensk ATbar till dina aktiva Widgets.</p>
	
	
	<table class="form-table">
	
		<!-- select version to use -->
		<tr style="border-top: 1px solid #DFDFDF;">
			<td><h3>Version</h3></td>
			<td>Välj vilket språk du vill ha på din ATbar.</td>
		</tr>
		<tr>
			<th scope="row">Select version:</th>
			<td>
				<select name="atbar_version">
					<option value="se"	<? echo is_version("se"); ?>>Svenska</option>
					<option value="en"	<? echo is_version("en"); ?>>Engelska</option>
					<option value="ar"  <? echo is_version("ar"); ?>>Arabiska</option>
				</select>
			</td>
		</tr>
		
		<!-- load atbar launcher -->
		<tr style="border-top: 1px solid #DFDFDF;">
			<td><h3>ATbar-startknapp</h3></td>
			<td>ATbar-startknapp är en bild/knapp som visas högst upp på sidan för att starta ATbar. Om du valt att aktivera ATbar-widgeten eller använda Shortcode behöver du troligen inte aktivera denna knapp.</td>
		</tr>
		<tr>
			<th scope="row">Ladda ATbar-startknapp högst upp på sidan?</th>
			<td>
				<select name="atbar_launcher_image">
						<option value="No" <? echo is_banner_show("No"); ?>>Nej</option>
						<option value="Yes" <? echo is_banner_show("Yes"); ?>>Ja</option>
				</select>
			</td>
		</tr>
		
		<!-- exclude pages for laucher -->
		<tr>
			<th scope="row">Exkludera ATbar-startknapp från sidor?</th>
			<td><input type="checkbox" name="atbar_launcher_exclude" lable="exclude pages for launcher" <? is_exclude('atbar_launcher_exclude'); ?>>  Ekludera ATbar-startknappp från sidor</td>
		</tr>
		<tr>
			<td></td>
			<td>
				<input type="text" name="atbar_launcher_exclude_pages" value="<? echo $exclude_launcher_pages_option; ?>" style="width:346px;">
				<p>Ange en komma-separerad lista med sid-id eller namn, till exempel 1,2,3 etc.</p>
			</td>
		</tr>
		
		<!-- auto load atbar -->		
		<tr style="border-top: 1px solid #DFDFDF;">
			<td><h3>Ladda ATbar automatiskt?</h3></td>
			<td>Den här inställningen laddar ATbar automatiskt på alla sidor. Valfria sidor kan exkluderas.</td>
		</tr>
		<tr>
			<th scope="row">Ladda ATbar automatiskt på alla sidor? (användaren behöver inte välja att ladda ATbar på varje sida)</th>
			<td>
				<select name="atbar_persistent">
					<option value="No" <? echo is_persistent("No"); ?>>Nej</option>
					<option value="Yes" <? echo is_persistent("Yes"); ?>>Ja</option>
				</select>
			</td>
		</tr>
		
		<!-- exclude pages for auto loader -->
		<tr>
			<th scope="row">Exkludera sidor från att ladda ATbar automatiskt?</th>
			<td><input type="checkbox" name="atbar_exclude" lable="exclude pages for auto loader" <? is_exclude('atbar_exclude'); ?>>  Exkludera sidor från att ladda ATbar automaatiskt</td>
		</tr>
				
		<tr>
			<td></td>
			<td>
				<input type="text" name="atbar_exclude_pages" value="<? echo $exclude_pages_option; ?>" style="width:346px;">
				<p>Ange en komma-separerad lista med sid-id eller namn som ska exluderas, till exempel 1,2,3 etc.</p>
			</td>
		</tr>
		
		<!-- shortcode options -->			
		<tr style="border-top: 1px solid #DFDFDF;">
			<td><h3>Shortcode</h3></td>
			<td>Shortcodes är en kort text som placeras på en sida eller ett inlägg för att köra ett kommando. För ATbar kommer ATbars startknapp att visas där du skriver in <i>[atbar]</i></td>
		</tr>
		<tr>
			<th scope="row">Positionering</th>
			
			<td>
				<select name="atbar_shortcode_align_option">
					<option value="left"	<? echo is_sc_align("left"); ?>>Vänster</option>
					<option value="center" <? echo is_sc_align("center"); ?>>Center</option>
					<option value="right" <? echo is_sc_align("right"); ?>>Höger</option>
				</select>
			</td>
		</tr>
		
		<!-- save form -->		
		<tr valign="top">
			<th scope="row">
				<p class="submit">
					<input type="submit" class="button-primary" style="float:left" value="Spara ändringar" />
				</p>
			</th>
		</tr>
		</form>
		
		<form method="post" action="options.php">
			<? settings_fields('atbar_options'); ?>
			<input type="hidden" name="atbar_persistent" value="<? get_option('atbar_persistent') ?>" />
		</form>	

	</table>
<?
	
}

?>