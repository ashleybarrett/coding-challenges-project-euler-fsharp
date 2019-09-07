module Challenge20

open System

let solution = 
    //https://projecteuler.net/problem=20

    {1I..99I}
    |> Seq.rev
    |> Seq.fold((*)) 100I
    |> string
    |> (fun str -> str.ToCharArray() |> Seq.map(string >> int))
    |> Seq.sum


    

    