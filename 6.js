// The string "PAYPALISHIRING" is written in a zigzag pattern on a given number of rows like this: (you may want to display this pattern in a fixed font for better legibility)

// P   A   H   N
// A P L S I I G
// Y   I   R
// And then read line by line: "PAHNAPLSIIGYIR"
// Write the code that will take a string and make this conversion given a number of rows:

// string convert(string text, int nRows);
// convert("PAYPALISHIRING", 3) should return "PAHNAPLSIIGYIR".

/**
 * @param {string} s
 * @param {number} numRows
 * @return {string}
 */
var convert = function(s, numRows) {
    if(numRows == 1 || numRows == 0)
        return s;
    
    var res = [];
    for(var i = 0; i < numRows; i++)
        res[i] = '';

    for(var i = 0; i < s.length; i++) {
        var index = i % (numRows + numRows -2);
        if(index >= numRows) 
            index = (numRows + numRows -2) - index;
        res[index] += s.charAt(i);
    }
    return res.reduce(function(acc, val){ return acc+=val; }, '');
};