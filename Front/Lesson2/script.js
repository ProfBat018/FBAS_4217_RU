// let btn = document.querySelector(`.btn`);
//
// window.addEventListener(`load`, () => {
//     setTimeout(() => {
//         btn.style.backgroundColor = `red`;
//     }, 2000);
// });
//
// let div = document.createElement(`div`)
//
// div.innerHTML= `<h1>hello</h1>`
//
// document.body.appendChild(div)
//
//


const parent = document.querySelector('.parent');
const child = document.querySelector('.child');
const grandchild = document.querySelector('.grandchild');

parent.addEventListener('click', () => {
    console.log('parent');
}, true);

child.addEventListener('click', () => {
    console.log('child');
}, true);

grandchild.addEventListener('click', () => {
    console.log('grandchild');
}, true);
