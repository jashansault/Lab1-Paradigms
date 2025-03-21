// Tail recursive function to find the product of elements in a list
let rec productTailRec list acc =
    match list with
    | [] -> acc
    | head :: tail -> productTailRec tail (head * acc)

// Example usage
let numbers = [1; 2; 3; 4; 5]
let resultProduct = productTailRec numbers 1  // Start with acc = 1
printfn "Product of all elements in list: %d" resultProduct
