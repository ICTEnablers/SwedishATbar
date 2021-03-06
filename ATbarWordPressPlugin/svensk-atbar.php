<?php
/*
Plugin Name: Svensk ATbar
Plugin URI: http://atbar.se
Description: ATbar is a cross browser accessibility toolbar which can be added to a user's browser or alternatively, for developers, the toolbar launcher can be embedded on a website.
Version: 3.3
Author: Magnus P White, Erik Zetterström
Author Email: erik@ictenablers.com
Author URI: http://www.atbar.se
*/

// register plugin with Wordpress
add_action('admin_menu', 'atbar_register_settings');
add_action('admin_menu', 'atbar_add_options');

// adds functions & widget class
include_once ('functions/functions.php');
include_once ('functions/atbarwidget.class.php');

// add options menu
include(dirname(__FILE__).'/options.php');

// adds css to header
add_action('wp_print_styles', 'atbar_css');

// adds the toolbar itself
add_action('the_post', 'add_toolbar');

// adds ATbar widget
add_action( 'widgets_init', create_function( '', 'register_widget( "atbar_widget" );' ) );

// add ATbar shortcode - type [atbar] (uses the same settings as the other launchers - edit in settings)
add_shortcode('atbar','shortcode_launcher');
?>