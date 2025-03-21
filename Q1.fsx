
open System

let applyExponent exponent value = 
    Math.Pow(value, exponent)

// Partially apply exponent 2 and 3
let square = applyExponent 2.0
let cube = applyExponent 3.0

// Invoke and print results
let resultSquare = square 4.0  // 4^2 = 16
let resultCube = cube 3.0  // 3^3 = 27

printfn "Square of 4 is: %f" resultSquare
printfn "Cube of 3 is: %f" resultCube
