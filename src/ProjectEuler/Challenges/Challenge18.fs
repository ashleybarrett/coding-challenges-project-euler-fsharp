module Challenge18

let solution = 
    //https://projecteuler.net/problem=18

    let triange = @"
                                75
                               95 64
                             17 47 82
                            18 35 87 10
                          20 04 82 47 65
                        19 01 23 75 03 34
                       88 02 77 73 07 63 67
                     99 65 04 28 06 16 70 92
                   41 41 26 56 83 40 80 70 33
                 41 48 72 33 47 32 37 16 94 29
               53 71 44 65 25 43 91 52 97 51 14
             70 11 33 28 77 73 17 78 39 68 17 57
            91 71 52 38 17 14 91 43 58 50 27 29 48
          63 66 04 68 89 53 67 30 73 16 69 87 40 31
        04 62 98 27 23 09 70 98 73 93 38 53 60 04 23
    "

    let trimSplit (input:string) (seperator:char) = input.Trim().Split(seperator)

    let triangleToArray triange = 
        trimSplit triange '\n'
        |> Array.map(fun line -> 
            let numbers = line.Trim().Split(" ")
            numbers |> Array.map int
        )
    
    let getItemValue (triange: int array array) (rowIndex: int) (itemIndex: int) = triange.[rowIndex].[itemIndex]

    let rec getMaximumPathSum (triange: int array array) (rowIndex: int) (itemIndex: int) = 
        let tip = getItemValue triange rowIndex itemIndex
        let left = getItemValue triange (rowIndex + 1) itemIndex
        let right = getItemValue triange (rowIndex + 1) (itemIndex + 1)

        let tipPlusLeft = tip + left
        let tipPlusRight = tip + right

        let newTip = if tipPlusRight > tipPlusLeft then tipPlusRight else tipPlusLeft

        let atSummit = rowIndex = 0 && (triange.[rowIndex].Length - 1) = itemIndex

        match atSummit with
        | true -> newTip
        | _ ->
                let nextItemIndex = if (triange.[rowIndex].Length - 1) = itemIndex then 0 else itemIndex + 1 
                let nextRowIndex = if nextItemIndex > 0 then rowIndex else rowIndex - 1

                triange.[rowIndex].[itemIndex] <- newTip

                getMaximumPathSum triange nextRowIndex nextItemIndex

    let mutable triange = triangleToArray triange
    let startingPosition = triange.Length - 2

    getMaximumPathSum triange startingPosition 0