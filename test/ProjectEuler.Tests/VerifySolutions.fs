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

    [<Test>]
    [<Ignore("Slow test")>]
    member this.VerifySolution5() =
        let expected = 232792560
        let actual = Challenge05.solution
        expected.ShouldBe(actual);

    [<Test>]
    member this.VerifySolution6() =
        let expected = 25164150
        let actual = Challenge06.solution
        expected.ShouldBe(actual);
        
