
#region WithoutPLINQ

using System.Diagnostics;

// List<int> nums = new();
//
// Stopwatch stopwatch = Stopwatch.StartNew();
//
// for (int i = 0; i < 1000000; i++)
// {
//     nums.Add(i);    
// }
//
// var res = nums.Where(x => x % 2 == 0);
//
// stopwatch.Stop();
//
// Console.WriteLine($"Elapsed time with PLINQ: {stopwatch.ElapsedMilliseconds} ms");
//

#endregion

#region WithPLINQ
/*
// Stopwatch stopwatch = Stopwatch.StartNew();
//
// var res = Enumerable.Range(0, 1000000).AsParallel().Where(x => x % 2 == 0);
//
// // parallel foreach
// Parallel.ForEach(res, (x) => ++x);
//
// stopwatch.Stop();
//
// Console.WriteLine($"Elapsed time with PLINQ: {stopwatch.ElapsedMilliseconds} ms");
*/
#endregion

