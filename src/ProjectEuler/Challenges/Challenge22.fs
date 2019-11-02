module Challenge22

open ProjectEuler.Helpers.File
open System

let solution = 
    
    //https://projecteuler.net/problem=22

    let application = System.IO.Path.GetDirectoryName(Reflection.Assembly.GetExecutingAssembly().Location)
    let location = sprintf "%s/%s" application "Challenges/challenge22-names.txt"

    let parseLine (line: string) = line.Replace("\"", "").Trim()

    let getScoreForName (index: int) (name: string) =
        Array.fold(fun score c -> 
            let intVal = int32(c) - 64
            score + intVal
        ) 0 (name.ToCharArray())
        |> (*)(index + 1)

    readFileAndSplit location ","
    |> Array.map parseLine
    |> Array.sort
    |> Array.mapi getScoreForName
    |> Array.sum

    

    