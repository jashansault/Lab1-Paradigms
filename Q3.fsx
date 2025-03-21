// Tail recursive function to calculate the product of odd numbers
let rec productOfOddNumbers n acc =
    if n <= 0 then acc
    elif n % 2 = 1 then productOfOddNumbers (n - 2) (n * acc)
    else productOfOddNumbers (n - 1) acc

// Example usage: Input 11
let resultOddProduct = productOfOddNumbers 11 1
printfn "Product of odd numbers from 11 to 1: %d" resultOddProduct
