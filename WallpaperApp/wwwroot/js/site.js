// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
// Hamburger Menu
const hamburger = document.querySelector(".hamburger");
const headerNav = document.querySelector(".header__nav ul");
const body = document.querySelector("body");

hamburger.addEventListener('click', () => {
    hamburger.classList.toggle('active');
    headerNav.classList.toggle('active');
    body.classList.toggle('fixed-position');
});

document.querySelectorAll(".nav ul li a").forEach(n =>
    n.addEventListener('click', () => {
        hamburger.classList.remove('active');
        headerNav.classList.remove('active');
        body.classList.remove('fixed-position');
    }));

// Photos Loading Button
const post = document.querySelectorAll(".post");
const btnLoad = document.querySelector(".btn--load");
var currentPage = 15;

btnLoad.addEventListener('click', () => {
    for (let i = currentPage; i < currentPage + 15; i++) {
        if (post[i]) {
            post[i].style.display = "block";
        }
    }

    currentPage += 15;

    if (currentPage >= post.length) {
        btnLoad.style.display = "none";
    }
});