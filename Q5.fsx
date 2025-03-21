// Using Filter and Reduce with a Collection
let numbers = [1..700]
let filteredNumbers = List.filter (fun n -> n % 7 = 0 && n % 5 = 0) numbers
let sumFiltered = List.fold (+) 0 filteredNumbers

printfn "Sum of filtered numbers: %d"sumFiltered