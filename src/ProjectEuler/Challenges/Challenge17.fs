module Challenge17

let solution = 
    //https://projecteuler.net/problem=17

    let maxNumber = 1000

    let zeroToNineMap = 
        [
            0, ""
            1, "One";
            2, "Two";
            3, "Three";
            4, "Four";
            5, "Five";
            6, "Six";
            7, "Seven";
            8, "Eight";
            9, "Nine";
        ] |> Map.ofSeq

    let elevenToNineteenMap = 
        [
            11, "Eleven";
            12, "Twelve";
            13, "Thirteen";
            14, "Fourteen";
            15, "Fifteen";
            16, "Sixteen";
            17, "Seventeen";
            18, "Eighteen";
            19, "Nineteen";
        ] |> Map.ofSeq

    let tensMap = 
        [
            0, "";
            1, "Ten";
            2, "Twenty";
            3, "Thirty";
            4, "Forty";
            5, "Fifty";
            6, "Sixty";
            7, "Seventy";
            8, "Eighty";
            9, "Nintey";
        ] |> Map.ofSeq
    
    let thousand = "Thousand"
    let hundred = "Hundred"

    let isElevenToNineteen (number:int) = number >= 11 && number <= 19

    let numberToWord (number:int) (suffix:string) (map:Map<int, string>) =
        match number > 0 with
        | true -> map.Item number + suffix
        | false -> ""

    let getLength (numberAsWord:string) = numberAsWord.Length

    let breakdownNumber number = 

        let numberOfThousands = number / 1000
        let numberMinusThousands = number - (numberOfThousands * 1000)
        let thousandsWord = numberToWord numberOfThousands thousand zeroToNineMap

        let numberOfHundreds = numberMinusThousands / 100
        let numberMinusHundreds = numberMinusThousands - (numberOfHundreds * 100)
        let hundredsWord = numberToWord numberOfHundreds hundred zeroToNineMap

        let andWord = if (numberOfThousands > 0 || numberOfHundreds > 0) && numberMinusHundreds > 0 then "And" else ""

        let remainderWord = 
            match isElevenToNineteen numberMinusHundreds with
            | true -> numberToWord numberMinusHundreds "" elevenToNineteenMap
            | false ->
                let numberOfTens = numberMinusHundreds / 10
                let numberMinusTens = numberMinusHundreds - (numberOfTens * 10)

                let tensWord = numberToWord numberOfTens "" tensMap
                let unitsWord = numberToWord numberMinusTens "" zeroToNineMap

                tensWord + unitsWord              
        
        thousandsWord + hundredsWord + andWord + remainderWord

    {1..maxNumber}
    |> Seq.sumBy(fun x -> breakdownNumber x |> String.length)