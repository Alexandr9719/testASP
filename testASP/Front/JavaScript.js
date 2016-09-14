var el_top = document.getElementById("top");
var el_mid = document.getElementById("mid");
var el_bot = document.getElementById("bot");
function top_traffic() {
    el_top.style.backgroundColor = "red";
}
function mid_traffic() {
    el_mid.style.backgroundColor = "yellow";
}
function bot_traffic() {
    el_bot.style.backgroundColor = "green"
}
var a = 0;
function show() {
    if (a == 0) { el_bot.style.backgroundColor = "grey"; top_traffic(); }
    if (a == 1) { mid_traffic(); el_top.style.backgroundColor = "grey"; }
    if (a == 2) { bot_traffic(); el_mid.style.backgroundColor = "grey"; a = -1; }
    a++
}
setInterval(show, 1000)