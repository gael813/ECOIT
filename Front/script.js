// Search bar 
function searchFormation() {
    let input = document.getElementById('search').value;
    input=input.toLowerCase();
    let cardTitle = document.getElementsByClassName('card-title');
    let divCard = document.getElementsByClassName('divCard');

    console.log(divCard);
    for (i = 0; i < cardTitle.length; i++) { 
        if (!cardTitle[i].innerHTML.toLowerCase().includes(input)) {
            divCard[i].style.display="none";
        }
        else {
            divCard[i].style.display="flex";                 
        }
    }
}

// Filter end formation
function endFormation() {
    let checkBox = document.getElementById("checkEnd").checked;
    let divStart = document.querySelectorAll("#divStart");
    let divProgress = document.querySelectorAll("#divProgress");
    let divEnd = document.querySelectorAll("#divEnd");
    
    if (checkBox === true)
    {
        divStart.forEach(element => {
            element.style.display="none";
        });
        divProgress.forEach(element => {
            element.style.display="none";
        });
        divEnd.forEach(element => {
            element.style.display="flex";
        });
    }
    else
    {        
        divStart.forEach(element => {
            element.style.display="flex";
        });
        divProgress.forEach(element => {
            element.style.display="flex";
        });
        divEnd.forEach(element => {
            element.style.display="flex";
        });
    }
}

// Filter Progress formation
function progressFormation() {
    let checkBox = document.getElementById("checkProgress").checked;
    let divStart = document.querySelectorAll("#divStart");
    let divProgress = document.querySelectorAll("#divProgress");
    let divEnd = document.querySelectorAll("#divEnd");
    
    if (checkBox === true)
    {
        divStart.forEach(element => {
            element.style.display="none";
        });
        divProgress.forEach(element => {
            element.style.display="flex";
        });
        divEnd.forEach(element => {
            element.style.display="none";
        });
    }
    else
    {        
        divStart.forEach(element => {
            element.style.display="flex";
        });
        divProgress.forEach(element => {
            element.style.display="flex";
        });
        divEnd.forEach(element => {
            element.style.display="flex";
        });
    }
}
