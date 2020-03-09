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

    [<Test>]
    member this.VerifySolution11() =
        let expected = 70600674
        let actual = Challenge11.solution
        actual.ShouldBe(expected);

    [<Test>]
    member this.VerifySolution12() =
        let expected = 76576500L
        let actual = Challenge12.solution
        actual.ShouldBe(expected);

    [<Test>]
    member this.VerifySolution13() =
        let expected = 5537376230L
        let actual = Challenge13.solution
        actual.ShouldBe(expected);

    [<Test>]
    [<Ignore("Slow test")>]
    member this.VerifySolution14() =
        let expected = 837799
        let actual = Challenge14.solution
        actual.ShouldBe(expected);

    [<Test>]
    member this.VerifySolution15() =
        let expected = 137846528820I
        let actual = Challenge15.solution
        actual.ShouldBe(expected);

    [<Test>]
    member this.VerifySolution16() =
        let expected = 1366
        let actual = Challenge16.solution
        actual.ShouldBe(expected);

    [<Test>]
    member this.VerifySolution17() =
        let expected = 21124
        let actual = Challenge17.solution
        actual.ShouldBe(expected);

    [<Test>]
    member this.VerifySolution18() =
        let expected = 1074
        let actual = Challenge18.solution
        actual.ShouldBe(expected);

    [<Test>]
    member this.VerifySolution19() =
        let expected = 171
        let actual = Challenge19.solution
        actual.ShouldBe(expected);

    [<Test>]
    member this.VerifySolution20() =
        let expected = 648
        let actual = Challenge20.solution
        actual.ShouldBe(expected);

    [<Test>]
    member this.VerifySolution21() =
        let expected = 31626
        let actual = Challenge21.solution
        actual.ShouldBe(expected);
    
    [<Test>]
    member this.VerifySolution22() =
        let expected = 871198282
        let actual = Challenge22.solution
        actual.ShouldBe(expected);

    [<Test>]
    [<Ignore("Slow test")>]
    member this.VerifySolution23() =
        let expected = 4179871
        let actual = Challenge23.solution
        actual.ShouldBe(expected);

    [<Test>]
    member this.VerifySolution25() =
        let expected = 4782
        let actual = Challenge25.solution
        actual.ShouldBe(expected);
        
