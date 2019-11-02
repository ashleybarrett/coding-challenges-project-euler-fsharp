namespace ProjectEuler.Helpers

module File = 

    let readFileAndSplit (fileName: string) (splitter: string) = 
        let allText = System.IO.File.ReadAllText fileName 
        allText.Split(splitter)