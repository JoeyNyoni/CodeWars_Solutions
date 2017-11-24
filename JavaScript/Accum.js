//This time no story, no theory. The examples below show you how to write function accum:

function accum(s) {
	// your code
  var gap = "";
  for (var i = 0; i < s.length; i++) {
    for (var j = 0; j <= i; j++)
      j === 0 ? gap += s[i].toUpperCase() : gap += s[i].toLowerCase();
      if (i !== s.length - 1)
        gap += '-';
    }
    return gap;
}