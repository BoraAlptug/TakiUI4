const sliders = {};

function startImageRotation(id) {
    const images = document.querySelectorAll(`img[data-parent="${id}"]`);
    if (images.length <= 1) return;

    let current = 0;
    sliders[id] = setInterval(() => {
        images.forEach((img, index) => {
            img.classList.toggle("opacity-100", index === current);
            img.classList.toggle("opacity-0", index !== current);
        });

        current = (current + 1) % images.length;
    }, 1000); // 1 saniyede bir resim değiştir
}

function stopImageRotation(id) {
    clearInterval(sliders[id]);
    const images = document.querySelectorAll(`img[data-parent="${id}"]`);
    if (images.length) {
        images.forEach((img, index) => {
            img.classList.toggle("opacity-100", index === 0);
            img.classList.toggle("opacity-0", index !== 0);
        });
    }
}