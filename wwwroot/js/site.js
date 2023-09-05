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