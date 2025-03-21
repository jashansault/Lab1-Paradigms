let nameList: string list = ["James"; "Robert"; "John"; "William"; "Michael"; "David"; "Richard"]
let filteredNames = List.filter (fun (name: string) -> name.ToLower().Contains("i")) nameList
let concatenatedNames = List.fold (fun acc name -> acc + name) "" filteredNames

printfn "Concatenated names: %s" concatenatedNames