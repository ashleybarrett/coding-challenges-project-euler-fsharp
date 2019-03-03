module Challenge04

open System.Linq

let solution = 
    //https://projecteuler.net/problem=4

    let minNumber = 100
    let maxNumber = 999

    let isPalindrome number =
        let chars = number.ToString().ToCharArray()
        let charsRev = chars |> Array.rev

        chars.SequenceEqual(charsRev)

    seq {
        for leftNumber in minNumber..maxNumber do
        for rightNumber in minNumber..maxNumber do
            let number =  leftNumber * rightNumber

            match isPalindrome number with
            | true -> yield number
            | _ -> ()
    }
    |> Seq.max
        
