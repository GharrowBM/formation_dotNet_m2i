
let startTime = 0
let start = 0
let end = 0
let diff = 0
let timerID = 0

//window.onload = chronoStart;
window.onload = document.getElementById("chronotime").textContent = "0:00:00:000";

function chrono() {
	end = new Date()
	diff = end - start
	diff = new Date(diff)
	let msec = diff.getMilliseconds()
	let sec = diff.getSeconds()
	let min = diff.getMinutes()
	let hr = diff.getHours() - 1
	if (min < 10) {
		min = "0" + min
	}
	if (sec < 10) {
		sec = "0" + sec
	}
	if (msec < 10) {
		msec = "00" + msec
	}
	else if (msec < 100) {
		msec = "0" + msec
	}
	document.getElementById("chronotime").textContent = `${hr}:${min}:${sec}:${msec}`;
	timerID = setTimeout("chrono()", 10)
}

function chronoStart() {
	document.chronoForm.startstop.value = "Stop!"
	document.chronoForm.startstop.onclick = chronoStop
	document.chronoForm.reset.onclick = chronoReset
	start = new Date()
	chrono()
}

function chronoContinue() {
	document.chronoForm.startstop.value = "Stop!"
	document.chronoForm.startstop.onclick = chronoStop
	document.chronoForm.reset.onclick = chronoReset
	start = new Date() - diff
	start = new Date(start)
	chrono()
}

function chronoReset() {
	document.getElementById("chronotime").value = "0:00:00:000"
	start = new Date()
}

function chronoStopReset() {
	document.getElementById("chronotime").textContent = "0:00:00:000"
	document.chronoForm.startstop.onclick = chronoStart
}

function chronoStop() {
	document.chronoForm.startstop.value = "Start!"
	document.chronoForm.startstop.onclick = chronoContinue
	document.chronoForm.reset.onclick = chronoStopReset
	clearTimeout(timerID)
}