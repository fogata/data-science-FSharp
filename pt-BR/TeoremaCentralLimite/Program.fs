let random = System.Random()

let centralLimitTheorem trials sampleSize =
    let sampleMeans = 
        [ for _ in 1 .. trials -> 
            [ for _ in 1 .. sampleSize -> float (random.Next(1, 7)) ]
            |> List.average ]
    let mean = List.average sampleMeans
    let variance = List.average (sampleMeans |> List.map (fun x -> (x - mean) ** 2.0))
    let stdDev = sqrt variance
    printfn "Central Limit Theorem - Mean: %f, StdDev: %f" mean stdDev

centralLimitTheorem 1000 30
