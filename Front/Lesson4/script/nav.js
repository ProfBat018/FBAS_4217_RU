const searchInput = document.querySelector('#search-input');
const searchBtn = document.querySelector('#search-btn');
const burgerMenu = document.querySelector('.burger-menu i');
const navSlider = document.querySelector('.nav-slider');

let searchToggler = false;
let menuToggler = false;

function slide() {
    if (!searchToggler) {
        searchInput.style.left = '-100%';
        searchToggler = true;
        searchInput.style.zIndex = '1';
    } else {
        searchInput.style.left = '0';
        searchToggler = false;
    }
    return searchToggler;
}

burgerMenu.addEventListener('click', () => {
    if (!menuToggler) {
        burgerMenu.style.rotate = '90deg';
        navSlider.style = `visibility: visible;opacity: 1;transition: all 0.5s ease-in-out;`;
        menuToggler = true;
    } else {
        burgerMenu.style.rotate = '0deg';
        navSlider.style = `visibility: hidden;opacity: 0;transition: all 0.5s ease-in-out;`
        menuToggler = false;
    }
    burgerMenu.style.opacity = '1';
});

searchBtn.addEventListener('click', () => {
    let res = slide();
});








