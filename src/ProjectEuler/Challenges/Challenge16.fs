module Challenge16

let solution = 
    //https://projecteuler.net/problem=16
    
    let powerNumber = 1000I
    let number = 2I

    let getPower (number:bigint) (powerNumber:bigint) = 
        (number, 1I)
        |> Seq.unfold(fun (n, p) -> Some((n, p), (n * 2I, p + 1I))) 
        |> Seq.takeWhile(fun (_, p) -> p <= powerNumber)
        |> Seq.last
        |> fst

    let getSumOfDigits (number:bigint) =
        number.ToString().ToCharArray()
        |> Seq.sumBy System.Char.GetNumericValue 
        |> int

    getPower number powerNumber |> getSumOfDigits
