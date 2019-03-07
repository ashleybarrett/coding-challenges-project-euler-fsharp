module Challenge09

let solution = 
    //https://projecteuler.net/problem=9

    let number = 1000
    
    let isTriplet a b c = (a * a) + (b * b) = (c * c)

    seq {
        for c in 3..number do
        for b in 2..(c - 1) do
        for a in 1..(b - 1) do

        match isTriplet a b c with
        | true -> yield (a, b, c)
        | false -> ()
    }
    |> Seq.find(fun (a, b, c) -> (a + b + c) = number)
    |> (fun (a, b , c) -> a * b * c)
    
        
