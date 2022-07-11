function modalFunction(DivModal) {
    if (DivModal.style.opacity == 0) {
        DivModal.style.transition = "all ease 1s";
        DivModal.style.opacity = 1;
        DivModal.style.pointerEvents = "all";
    } else {
        DivModal.style.transition = "all ease 1s";
        DivModal.style.opacity = 0;
        DivModal.style.pointerEvents = "none";

    }

}