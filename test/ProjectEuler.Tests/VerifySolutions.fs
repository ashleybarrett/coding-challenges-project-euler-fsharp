namespace ProjectEuler.Tests

open NUnit.Framework
open Shouldly

[<TestFixture>]
type TestClass () =

    [<Test>]
    member this.VerifySolution1() =
        let expected = 233168
        let actual = Challenge01.solution
        expected.ShouldBe(actual);

    [<Test>]
    member this.VerifySolution2() =
        let expected = 4613732
        let actual = Challenge02.solution
        expected.ShouldBe(actual);

    [<Test>]
    member this.VerifySolution3() =
        let expected = 6857L
        let actual = Challenge03.solution
        expected.ShouldBe(actual);

    [<Test>]
    member this.VerifySolution4() =
        let expected = 906609
        let actual = Challenge04.solution
        expected.ShouldBe(actual);
        
