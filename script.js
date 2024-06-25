

// Array of image URLs
let imag_url_arr = ["lake-6701636_1920.jpg", "road-6597404.jpg", "mountain-8117525.jpg"];

// Getting the total number of images and setting it to #no-image element
let image_count = document.querySelector("#no-image").innerHTML = imag_url_arr.length;

// Selecting the element where the currently displayed image name will be shown
let which_are_present_in_img = document.querySelector("#which-are-exist");

// Selecting the element that will display the background image
let background_image = document.querySelector(".back-img");

// Selecting the elements for left and right navigation
let left_img = document.querySelector(".left");
let right_img = document.querySelector(".right");

// Initialize count to keep track of the current image index
let count = 0;

// Function to update the currently displayed image
function updateImage() {
    // Ensure count stays within bounds of imag_url_arr.length


    if (count < 0) {
        count = imag_url_arr.length - 1; // Wrap around to the last image
    } else if (count >= imag_url_arr.length) {
        count = 0; // Wrap around to the first image
    }

 

    // Update the background image source
    background_image.src = `${imag_url_arr[count]}`;

    // Update the text to show which image is currently displayed
    which_are_present_in_img.innerHTML=count+1;
   
}

// Initial update when the page loads
updateImage();

// Event listener for left navigation button
left_img.addEventListener("click", () => {
    count--;
    updateImage();
});

// Event listener for right navigation button
right_img.addEventListener("click", () => {
    count++;
    updateImage();
});



