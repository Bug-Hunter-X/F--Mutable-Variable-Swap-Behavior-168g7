let mutable x = 10
let mutable y = 20

let swap x y =
    let temp = x
    x <- y
    y <- temp

swap x y
printf "%d %d" x y //This will print 20 20 as expected

//However, consider this:

let swap2 (x, y) = (y,x)

let a = 10
let b = 20
let (a,b) = swap2 (a,b) //This will correctly swap a and b, but the effect is only local
printf "%d %d" a b //this prints 10 20, not 20 10
