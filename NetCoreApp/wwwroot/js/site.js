// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


Date.prototype.dateFormat = function () {
	var months = ["01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"];
	var dd = this.getDay().XX();
	var MM = months[this.getMonth()];
	var yyyy = this.getFullYear();
	console.log(`${yyyy}-${MM}-${dd}`);
	return `${yyyy}-${MM}-${dd}`;
}

Date.prototype.timeFormat = function () {
	var d = this;
	var hh = (d.getHours()).XX();
	var mm = (d.getMinutes() + 0).XX();
	console.log(`${hh}:${mm}`);
	return `${hh}:${mm}`;
}

Number.prototype.XX = function () {
	return (this >= 0 && this < 10) ? '0' + this : ''+this;
}