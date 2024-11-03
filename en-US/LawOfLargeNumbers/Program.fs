let random = System.Random()

let sampleMean trials =
    let outcomes = [ for _ in 1 .. trials -> float (random.Next(1, 7)) ]
    let mean = List.average outcomes
    printfn "Sample Mean after %d trials: %f" trials mean
    mean

let trials = [10; 100; 1000; 10000]
trials |> List.iter sampleMean
