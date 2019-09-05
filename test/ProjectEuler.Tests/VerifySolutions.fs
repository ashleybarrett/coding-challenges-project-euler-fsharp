namespace ProjectEuler.Tests

open NUnit.Framework
open Shouldly

[<TestFixture>]
type TestClass () =

    [<Test>]
    member this.VerifySolution1() =
        let expected = 233168
        let actual = Challenge01.solution
        actual.ShouldBe(expected);

    [<Test>]
    member this.VerifySolution2() =
        let expected = 4613732
        let actual = Challenge02.solution
        actual.ShouldBe(expected);

    [<Test>]
    member this.VerifySolution3() =
        let expected = 6857L
        let actual = Challenge03.solution
        actual.ShouldBe(expected);

    [<Test>]
    member this.VerifySolution4() =
        let expected = 906609
        let actual = Challenge04.solution
        actual.ShouldBe(expected);

    [<Test>]
    [<Ignore("Slow test")>]
    member this.VerifySolution5() =
        let expected = 232792560
        let actual = Challenge05.solution
        actual.ShouldBe(expected);

    [<Test>]
    member this.VerifySolution6() =
        let expected = 25164150
        let actual = Challenge06.solution
        actual.ShouldBe(expected);

    [<Test>]
    member this.VerifySolution7() =
        let expected = 104743
        let actual = Challenge07.solution
        actual.ShouldBe(expected);


    [<Test>]
    member this.VerifySolution8() =
        let expected = 23514624000L
        let actual = Challenge08.solution
        actual.ShouldBe(expected);

    [<Test>]
    member this.VerifySolution9() =
        let expected = 31875000
        let actual = Challenge09.solution
        actual.ShouldBe(expected);


    [<Test>]
    member this.VerifySolution10() =
        let expected = 142913828922L
        let actual = Challenge10.solution
        actual.ShouldBe(expected);
        
