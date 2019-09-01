namespace ProjectEuler.Helpers

open System

module Int64Math =

    let getSqrt (number:int64) = number |> double |> Math.Sqrt |> int64

    let isFactor (number:int64) (candiate:int64) = number % candiate = 0L

    let isPrime (number: int64) = { 2L .. (getSqrt number) } |> Seq.forall(fun x -> number % x <> 0L)

module Math =

    let getSqrt (number:int) = number |> int64 |> Int64Math.getSqrt |> int

    let isPrime (number: int) = number |> int64  |> Int64Math.isPrime