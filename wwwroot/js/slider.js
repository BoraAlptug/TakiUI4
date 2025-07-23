let currentIndex = 0;

function moveSlide(step) {
    const slides = document.querySelectorAll('.slide');
    currentIndex = (currentIndex + step + slides.length) % slides.length;
    const slider = document.getElementById('slider');
    slider.style.transform = `translateX(-${currentIndex * 100}%)`;
}