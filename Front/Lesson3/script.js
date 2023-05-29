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
        navSlider.style = ` top: 150px;position: absolute;display: flex;`
        navSlider.querySelector('.nav-slider-inner').style = `display: flex;flex-direction: row;flex-wrap: wrap;`
        menuToggler = true;
    } else {
        burgerMenu.style.rotate = '0deg';
        navSlider.style = ` top: 0px;position: absolute;display: none;`
        navSlider.querySelector('.nav-slider-inner').style = `display: none;`
        menuToggler = false;
    }
    burgerMenu.style.opacity = '1';
});

searchBtn.addEventListener('click', () => {
    let res = slide();
});








