var burger = document.querySelector('.burger-menu');
var menu = document.querySelector('.nav-menu');
var container = document.querySelector('.container');

var checked = false;

burger.addEventListener('click', function() {
    console.log('click');
    if (!checked) {
        burger.style.transform = 'rotateZ(90deg)';
        checked = true;
        var newMenu = menu;
        newMenu.className = 'nav-menu-active';
        menu.remove();
        container.insertBefore(newMenu, document.querySelector('.blocks'));

    } else {
        document.querySelector('.nav-menu-active').remove();
        burger.style.transform = 'rotateZ(0deg)';
        checked = false;
    }
});


