// Text Field - Material
const form_material = [].map.call(document.querySelectorAll('.mdc-text-field'), function (el) {
    return new mdc.textField.MDCTextField.attachTo(el);
});

// Ripple Effect - Button
const buttons = document.querySelectorAll(".ripple-button");

var waveBtn = (function () {
    'use strict';
    var btn = document.querySelectorAll('.ripple-effects'), i;

    for (i = 0; i < btn.length; i++) {
        btn[i].onmousedown = function (e) {
            var newRound = document.createElement('div'), x, y;

            newRound.className = 'cercle';
            this.appendChild(newRound);

            x = e.pageX - this.offsetLeft;
            y = e.pageY - this.offsetTop;

            newRound.style.left = x + "px";
            newRound.style.top = y + "px";
            newRound.className += " anim";

            setTimeout(function () {
                newRound.remove();
            }, 1000);
        };
    }
}());

// Barra lateral
function openSideNav() {
    const btnOpenSideNav = document.getElementById("BtnOpenSideNav");

    if (btnOpenSideNav.getAttribute("data-value") === "false") {
        sidemenu.style.marginLeft = "250px";
        btnOpenSideNav.setAttribute("data-value", "true");

        // Establecer la posición fija y la altura máxima para el desplazamiento
        sidemenu.style.position = "fixed";
        
    } else {
        sidemenu.style.marginLeft = "0px";
        btnOpenSideNav.setAttribute("data-value", "false");

        // Restaurar el estilo del sidemenu y permitir el desplazamiento del body
        sidemenu.style.position = "";
        sidemenu.style.maxHeight = "";
    }
}

// Cerrar barra lateral si se toca fuera del area
document.onclick = function (e) {

    // Si el usuario hace click fuera del algunos de esos marcos
    if (e.target.id !== 'sidemenu' &&
        e.target.id !== 'topBar' && 
        e.target.id !== 'BtnOpenSideNav'
    ) {
        document.getElementById("sidemenu").style.marginLeft = "0px";;
        document.getElementById("BtnOpenSideNav").setAttribute("data-value", "false");
    }
}