open System

type Probability = 
    | Probability of float
    member this.Value =
        let (Probability p) = this
        if p < 0.0 || p > 1.0 then 
            failwith "Probability must be between 0 and 1."
        else p

let bayesTheorem (pBa: Probability) (pA: Probability) (pB: Probability) =
    let (Probability pBaVal) = pBa
    let (Probability pAVal) = pA
    let (Probability pBVal) = pB

    if pBVal = 0.0 then
        failwith "P(B) must be greater than 0 to perform Bayes calculation."
    else
        let result = (pBaVal * pAVal) / pBVal
        Probability result

let pBa = Probability 0.99
let pA = Probability 0.01
let pB = Probability 0.02
let posteriorProbability = bayesTheorem pBa pA pB
printfn "Bayes' Theorem - Probability: %.2f%%" (posteriorProbability.Value * 100.0)
