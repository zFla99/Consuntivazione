const sfondo = document.getElementById("sfondoBody");
const bottone = document.getElementById('button');

bottone.addEventListener('click', cambiaSfondo);

function cambiaSfondo(){
    if (sfondo == "sfondoBianco"){
        sfondo.className = "sfondoNero";
        // document.getElementById('button').innerHTML = "Sfondo Bianco";
    } else {
        sfondo.className = "sfondoBianco";
    }
};