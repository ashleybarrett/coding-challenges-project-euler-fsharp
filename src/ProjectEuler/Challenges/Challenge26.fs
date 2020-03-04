module Challenge26

let solution = 
    
    //https://projecteuler.net/problem=26

    let isRecurring (number: decimal) =
        let parts = number.ToString().Split('.')
        let chars = 
            parts.[1].ToCharArray()
            |> Array.countBy id

        chars.Length = 1



    1.0m / 6.0m
    |> isRecurring


    0
    