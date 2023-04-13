# LinqForTuples

Code generator is located in LinqForTuples/LinqForTuples.Generation/CodeGeneration/

Other folders are generation output or they are containing testing code

# How to use?
Install nugetpackage in ur project:
LinqForTuples 

#How to build?

Open generation project in visual studio 2022. Use UI to generate selected version. Open generated project in top most directory eg NetFramwork. Rebuild solution.

# Some examples:
    //all standard linq extenstions are supported
    //plus some tuple specific extras
    (a,b).Swipe( a > b) // one line swiping
   
    (1, 2, 3, 4).Min() // return 0
    (1, 2, 3, 4).Where(x > 2) // return 3,4
    (a, b, b, d).ToList() // one line list creation 
    
    (btm, btm2, btm3).ToList().ForEach(x => x.Dispose()) // grouping repetitive calls. Composite pattern

    var items = (4,5,6).ToArray();
    var items2 = (7,8,9).ToArray();
    var c = (1, 2, 3, items, items2).Many(); //joining collections and sinle items in one line -> 1,2,3,4,5,6,7,8,9
     
