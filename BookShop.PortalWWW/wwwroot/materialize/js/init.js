//(function ($) {
//  $(function(){

//      $('.sidenav').sidenav();
//      $('.parallax').parallax();
//      $('.scrollspy').scrollSpy();
//      $('.materialbox').materialbox();
//      $('.tap-target').tapTarget();
//      $('.tabs').tabs();
//      $('.collapsible').collapsible();


//  }); // end of document ready
//})(jQuery); // end of jQuery name space

$(document).ready(function () {
    $('.sidenav').sidenav();
    $('.parallax').parallax();
    $('.scrollspy').scrollSpy();
    $('.materialbox').materialbox();
    $('.tap-target').tapTarget();
    $('.tabs').tabs();
    //$('.collapsible').collapsible();
});

document.addEventListener('DOMContentLoaded', function () {
    var collapse = document.querySelectorAll('.collapsible');
    var instances = M.Collapsible.init(collapse);
});