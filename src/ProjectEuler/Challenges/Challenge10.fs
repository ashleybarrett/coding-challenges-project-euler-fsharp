module Challenge10

open ProjectEuler.Helpers.Int64Math

let solution = 
    //https://projecteuler.net/problem=10

    let number = 1999999L

    {3L..2L..number}
    |> Seq.filter isPrime
    |> Seq.sum
    |> (fun x -> x + 2L)

    
        
