# LinqForTuples

Code generator is located in LinqForTuples/LinqForTuples.Generation/CodeGeneration/

Other folders are generation output or they are containing testing code

# How to use?
Install nugetpackage in ur project:
LinqForTuples 


# Some examples:
    (a,b).Swipe( a > b) // one line swiping
   
    (1, 2, 3, 4).Min() // return 0
    (1, 2, 3, 4).Where(x > 2) // return 3,4
    (a, b, b, d).ToList() // one line list creation 

    var array = (1, 2, 3, 4).ToArray();
    var collection = (array, 5, 6, 7).ToArray() // one line collections and single items concatenations
    (btm, btm2, btm3).ForEach(x => x.Dispose()) // grouping repetitive calls. Composite pattern

