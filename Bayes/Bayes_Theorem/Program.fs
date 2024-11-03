open System

/// Define a type to represent probabilities between 0 and 1
type Probability = 
    | Probability of float
    member this.Value =
        let (Probability p) = this
        if p < 0.0 || p > 1.0 then 
            failwith "A probability must be between 0 and 1."
        else p

/// Function to calculate Bayes' Theorem
/// P(A|B) = (P(B|A) * P(A)) / P(B)
let bayesTheorem (pBa: Probability) (pA: Probability) (pB: Probability) =
    let (Probability pBaVal) = pBa
    let (Probability pAVal) = pA
    let (Probability pBVal) = pB

    if pBVal = 0.0 then
        failwith "P(B) must be greater than 0 to perform Bayes calculation."
    else
        let result = (pBaVal * pAVal) / pBVal
        Probability result

/// Helper function to format the probability output
let displayProbability (Probability p) =
    printfn "Probability: %.2f%%" (p * 100.0)

/// Example usage of Bayes' Theorem:
/// Suppose we have a medical test for a disease:
/// - P(B|A): Probability of a positive test given the person has the disease = 0.99
/// - P(A): Probability of a person having the disease = 0.01
/// - P(B): Probability of a positive test in the population = 0.02
let pBa = Probability 0.99
let pA = Probability 0.01
let pB = Probability 0.02

// Calculate the probability that a person has the disease given a positive test result (P(A|B))
let posteriorProbability = bayesTheorem pBa pA pB

// Display the formatted result
displayProbability posteriorProbability
