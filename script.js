
let imag_url_arr=["lake-6701636_1920.jpg","road-6597404.jpg","mountain-8117525.jpg"];
var count=1;
var i=0;
let image_count=document.querySelector("#no-image").innerHTML=imag_url_arr.length;
let which_are_present_in_img=document.querySelector("#which-are-exist");

let backgorund_image=document.querySelector(".back-img");

let left_img=document.querySelector(".left");
let right_img=document.querySelector(".right");
left_img.addEventListener("click",()=>{
    if(i==0){

    }
    else{
        if(imag_url_arr.length-1){
            count--;
            i--;
        }
        count--;
        i--;
        console.log("left",count," ",i)
        backgorund_image.src=imag_url_arr[i];
        which_are_present_in_img.innerHTML=count;
    }
})

right_img.addEventListener("click",()=>{
    if(count>imag_url_arr.length){
            
    }
    else{
        console.log("right",count," ",i)
        backgorund_image.src=imag_url_arr[i];
        which_are_present_in_img.innerHTML=count;
        count++;
        i++;
    }
})