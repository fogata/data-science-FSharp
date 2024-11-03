let euclideanDistance (pointA: float list) (pointB: float list) =
    if List.length pointA <> List.length pointB then
        failwith "Both points must have the same dimensions."
    else
        let sumOfSquares = 
            List.zip pointA pointB
            |> List.map (fun (a, b) -> (a - b) ** 2.0)
            |> List.sum
        sqrt sumOfSquares

let pointA = [3.0; 4.0]
let pointB = [0.0; 0.0]
let distance = euclideanDistance pointA pointB
printfn "Euclidean Distance between points: %f" distance
