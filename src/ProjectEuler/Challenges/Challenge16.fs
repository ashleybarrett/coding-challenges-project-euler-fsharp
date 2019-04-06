module Challenge16

let solution = 
    //https://projecteuler.net/problem=16
    
    let number = 2I
    let powerNumber = number**1000

    let getSumOfDigits (number:bigint) =
        number.ToString().ToCharArray()
        |> Seq.sumBy System.Char.GetNumericValue 
        |> int

    getSumOfDigits powerNumber
