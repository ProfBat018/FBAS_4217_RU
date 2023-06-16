// Toggle button with jQuery
// $('#btn').click(function () {
//     $('#btn').toggleClass('active');
// });


// Toggle button with JavaScript

// var btn = document.getElementById('btn');
// btn.addEventListener('click', function () {
//     btn.classList.toggle('active');
// });


// var heading = $('#heading1');
// heading.css({'background-color': 'red', 'color': 'white', 'padding': '20px'});

$("#clickme" ).on( "click", function() {
    $( "#book" ).animate({
        height: "toggle"
    }, 1000, function() {
        console.log('Animation complete')
    });
});

