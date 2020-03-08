namespace ProjectEuler.Helpers

module File = 

    let readFileAndSplitAsync (fileName: string) (splitter: string) = 
        async {
            let! allText = System.IO.File.ReadAllTextAsync fileName |> Async.AwaitTask
            return allText.Split(splitter)
        }
        |> Async.RunSynchronously