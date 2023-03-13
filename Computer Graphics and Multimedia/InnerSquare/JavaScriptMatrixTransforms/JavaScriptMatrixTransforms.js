"use strict";

var canvas;
var gl;

var theta = vec3(45, 45, 45);
var thetaLoc;

// Axes: 0 = x; 1 = y; 2 = z
var xAxis = 0;
var yAxis = 1;
var zAxis = 2;
var axis = 0;
var dtheta = 2;

var vBuffer;

var vertices = [
    vec4(-0.25, -0.25, 0.25, 1),
    vec4(-0.25, 0.25, 0.25, 1),
    vec4(0.25, 0.25, 0.25, 1),
    vec4(0.25, -0.25, 0.25, 1),
    vec4(-0.25, -0.25, -0.25, 1),
    vec4(-0.25, 0.25, -0.25, 1),
    vec4(0.25, 0.25, -0.25, 1),
    vec4(0.25, -0.25, -0.25, 1)
];

var vertexColors = [
    vec4(1.0, 0.0, 0.0, 1.0),  // red
    vec4(0.0, 0.0, 0.0, 1.0),  // black
    vec4(1.0, 1.0, 0.0, 1.0),  // yellow
    vec4(0.0, 1.0, 0.0, 1.0),  // green
    vec4(0.0, 0.0, 1.0, 1.0),  // blue
    vec4(1.0, 1.0, 1.0, 1.0),  // white
    vec4(1.0, 0.0, 1.0, 1.0),  // magenta
    vec4(0.0, 1.0, 1.0, 1.0)   // cyan
];

var points = [];
var points2 = [];
var colors = [];

var maxTime = 3;
var timeStamp;
var xOffSet = 0;
var inc = 0.006;
var scale = 1;

window.onload = function init() {
    canvas = document.getElementById("gl-canvas");

    gl = WebGLUtils.setupWebGL(canvas);
    if (!gl) { alert("WebGL isn't available"); }

    gl.viewport(0, 0, canvas.width, canvas.height);
    gl.clearColor(1.0, 1.0, 1.0, 1.0);

    gl.enable(gl.DEPTH_TEST);

    //
    //  Load shaders and initialize attribute buffers
    //
    var program = initShaders(gl, "vertex-shader", "fragment-shader");
    gl.useProgram(program);

    colorCube();
    points2 = new Array(points.length);    // initialize the size of points2 array

    // vertex array attribute buffer code goes here
    vBuffer = gl.createBuffer();
    gl.bindBuffer(gl.ARRAY_BUFFER, vBuffer);
    gl.bufferData(gl.ARRAY_BUFFER, flatten(points), gl.STATIC_DRAW);

    var vPosition = gl.getAttribLocation(program, "vPosition");
    gl.vertexAttribPointer(vPosition, 4, gl.FLOAT, false, 0, 0);
    gl.enableVertexAttribArray(vPosition);

    // color array attribute buffer code goes here
    var cBuffer = gl.createBuffer();
    gl.bindBuffer(gl.ARRAY_BUFFER, cBuffer);
    gl.bufferData(gl.ARRAY_BUFFER, flatten(colors), gl.STATIC_DRAW);

    var vColor = gl.getAttribLocation(program, "vColor");
    gl.vertexAttribPointer(vColor, 4, gl.FLOAT, false, 0, 0);
    gl.enableVertexAttribArray(vColor);


    document.getElementById("xButton").onclick = function () {
        axis = xAxis;
        document.getElementById('xButton').style.background = '#bebfba';
        document.getElementById('yButton').style.background = '#FFF';
        document.getElementById('zButton').style.background = '#FFF';
    };
    document.getElementById("yButton").onclick = function () {
        axis = yAxis;
        document.getElementById('xButton').style.background = '#FFF';
        document.getElementById('yButton').style.background = '#bebfba';
        document.getElementById('zButton').style.background = '#FFF';
    };
    document.getElementById("zButton").onclick = function () {
        axis = zAxis;
        document.getElementById('xButton').style.background = '#FFF';
        document.getElementById('yButton').style.background = '#FFF';
        document.getElementById('zButton').style.background = '#bebfba';
    };

    timeStamp = getTimeInSeconds() - maxTime / 2;  // initialize the timeStamp to 1/2 of maxTime
    render();
}

function getTimeInSeconds() {
    return Date.now() / 1000;  // gets current time in seconds (since Jan 1, 1970)
}

function colorCube() {
    square(1, 0, 3, 2);
    square(2, 3, 7, 6);
    square(3, 0, 4, 7);
    square(5, 1, 2, 6);
    square(4, 5, 6, 7);
    square(5, 4, 0, 1);
}

function square(a, b, c, d) {
    // Partion the square into two triangles in order for
    // WebGL to be able to render it.      
    // Vertex color assigned by the index of the vertex

    var indices = [a, b, c, a, c, d];

    for (var i = 0; i < indices.length; ++i) {
        points.push(vertices[indices[i]]);
        //colors.push( vertexColors[indices[i]] );

        //for solid colored faces use 
        colors.push(vertexColors[c]);
    }
}


function render() {
    gl.clear(gl.COLOR_BUFFER_BIT | gl.DEPTH_BUFFER_BIT);

    theta[axis] += dtheta;   // update the angle
    if (getTimeInSeconds() > timeStamp + maxTime) {  // loop from 0 to maxtime 
        inc *= -1;                                   // change inc direction after maxtime
        timeStamp = getTimeInSeconds();              // reset timeStamp after maxtime
    }
    scale += inc;      // update the new scaling value
    xOffSet += inc;    // update the new x-offset translation value

    var mvMat = scalem(scale, scale, scale);        // Creates a scaling matrix
    mvMat = mult(rotateX(theta[xAxis]), mvMat);     // Multiply matrix by rotation matrix around X-axis
    mvMat = mult(rotateY(theta[yAxis]), mvMat);     // Multiply matrix by rotation matrix around Y-axis
    mvMat = mult(rotateZ(theta[zAxis]), mvMat);     // Multiply matrix by rotation matrix around Z-axis
    mvMat = mult(translate(xOffSet, 0, 0), mvMat);  // Multiply matrix by translation matrix

    // Note: the 5 above lines could have also been combined to the combined command:
    //   var mvMat = mult(mult(mult(mult(translate(xOffSet,0,0), rotateZ(theta[zAxis])),
    //                                                           rotateY(theta[yAxis])),
    //                                                           rotateX(theta[xAxis])),
    //                                                           scalem(scale, scale, scale));

    // var mvMat = mat4();   <= Note: this command creates a 4x4 Identity matrix
    // Note: the following command also creates a 4x4 Identity matrix:
    // var mvMat = mat4(1,0,0,0,
    //                  0,1,0,0,
    //                  0,0,1,0,
    //                  0,0,0,1);
    // So you can use the mat4() method to create any transformation matrix you want

    // Here is where you use you matrix to transform the object's vertices
    for (var j = 0; j < points.length; ++j) {
        points2[j] = mult(mvMat, points[j]);     // Multiply each point by matrix to get new point
    }

    gl.bindBuffer(gl.ARRAY_BUFFER, vBuffer);
    gl.bufferData(gl.ARRAY_BUFFER, flatten(points2), gl.STATIC_DRAW);  // Send updated set of points

    gl.drawArrays(gl.TRIANGLES, 0, points2.length);

    requestAnimFrame(render);
}