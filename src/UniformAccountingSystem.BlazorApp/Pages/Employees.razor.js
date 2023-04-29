function HideBtns(event) {
    const btns = event.target.getElementsByTagName("button");

    for (let btn in btns) {
        btn.style.visibility = "hidden";
    }
}

function ShowBtns(event) {
    const btns = event.target.getElementsByTagName("button");

    for (let btn in btns) {
        btn.style.visibility = "visible";
    }
}