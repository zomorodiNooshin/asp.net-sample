/*! input data blocking by Nooshin Zomorodi
 *  Ver 1.0 - 2017/10/10 [1396/07/18]
 *  http://AryaVandidad.com | https://t.me/WebDesignFa
 */

/* How to use:
 * <input type="text" class="fcss-en" ...>
 * <input type="text" class="fcss-fa" ...>
 * <input type="text" class="fcss-no" ...>
 * <input id="..." type="text" onkeydown="numericalInput(event);" />
 */

$(document).ready(function () {
	$(".fcss-fa").on("keypress", persianInput);
	$(".fcss-en").on("keypress", englishInput);
	$(".fcss-no").on("keydown", numericalInput);
});

function englishInput(event) {
    var chf = event.which || event.keyCode;
	if ((chf >= 1536 && chf <= 1791) && chf!=32) {
		event.preventDefault();
	}
}

function persianInput(event) {
    var chf = event.which || event.keyCode;
	if ((chf < 1536 || chf > 1791) && chf != 32) {
		event.preventDefault();
	}
}

function numericalInput(event) {
	var ch = event.which || event.keyCode;
	if (((ch < 48) || (ch > 57 && ch < 96) || (ch > 105)) && (ch != 8 && ch != 46 && ch != 37 && ch != 39)) {
		event.preventDefault();
	}
}
