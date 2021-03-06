﻿using System;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace crypto_math_problem
{
	class Program
	{
		static void Main(string[] args)
		{

		  //  LinqVersionFastest();
//		    LinqVersionFaster();
//            LinqVersion();
	

            TimeCall(()=>stephenVersion());


            var stopWatch = new Stopwatch();
            stopWatch.Start();

			var term1="send".ToUpper();
			var term2="more".ToUpper();
			var res="money".ToUpper();

            "\nSolutions for :".Dump();
            " {0}".Dump(term1);
            "+{0}".Dump(term2);
            "=====".Dump();
            "{0}".Dump(res);

         //   var phrase = new string((term1 + term2 + res).Distinct().Reverse().ToArray()).ToLower();
		    var phrase = "yromdnes";
//		    var phrase = "sromdney";
		    var count = 1;
		    var permutations = 0;
		    var exclusions = new Mappings<int[]>
		    {
		        s = new[] {0},
		        m = new[] {0}
		    };

		    foreach (var map in phrase.GetMappings(Enumerable.Range(0,10).ToArray(),exclusions))
			{
                permutations++;

                var t1 = ToNum(map.s, map.e, map.n, map.d);
                var t2 = ToNum(map.m, map.o, map.r, map.e);
                var r0 = ToNum(map.m, map.o, map.n, map.e, map.y);


                if ((ToNum(map.d) + ToNum(map.e) == ToNum(map.y)||(ToNum(map.d) + ToNum(map.e) == ToNum(map.y)+10)))
                
			    {
                    if ((ToNum(map.n, map.d) + ToNum(map.r, map.e) == ToNum(map.e, map.y) || (ToNum(map.n, map.d) + ToNum(map.r, map.e) == ToNum(map.e, map.y+10))))
			        {
			            exclusions.d = new[] {map.d};
			            exclusions.e = new[] {map.e};
            
			        }
                }
			
	
				if (t1 + t2 == r0)
				{
					"{0})\t\t\t{1}".Dump(count++,map.ToString());
					"\t {0}".Dump(t1);
					"\t+{0}".Dump(t2);
				    "\t=====".Dump();
					"\t{0}".Dump(r0);
				    break;
				}

			}
		
            stopWatch.Stop();
            var ts = stopWatch.Elapsed;

            var elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:0000}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            elapsedTime.Dump();

            "{0} Mappings were tested. Total matches {1}".Dump(permutations,count-1);
            "Press any key to continue".Dump();
		    Console.ReadKey();

		}
//				var t1=term1.Replace(map);
//				var t2=term2.Replace(map);
//				var r=res.Replace(map);
	    public static void LinqVersion()
	    {

            var stopWatch = new Stopwatch();
            stopWatch.Start();
            var q = (
	            from s in Enumerable.Range(0, 10)
	            from e in Enumerable.Range(0, 10)
	            from n in Enumerable.Range(0, 10)
	            from d in Enumerable.Range(0, 10)
	            from m in Enumerable.Range(0, 10)
	            from o in Enumerable.Range(0, 10)
	            from r in Enumerable.Range(0, 10)
	            from y in Enumerable.Range(0, 10)

                let t1=int.Parse(string.Format("{0}{1}{2}{3}",s,e,n,d))
                let t2=int.Parse(string.Format("{0}{1}{2}{3}",m,o,r,e))
                let r0=int.Parse(string.Format("{0}{1}{2}{3}{4}",m,o,n,e,y))

	            where t1+t2==r0 && 
                        s != e && s != n && s != d && s != m && s != o && s != r && s != y &&
		                e != n && e != d && e != m && e != o && e != r && e != y &&
		                n != d && n != m && n != o && n != r && n != y &&
		                d != m && d != o && d != r && d != y &&
		                m != o && m != r && m != y &&
		                o != r && o != y &&
		                r != y

	            select new {t1,t2,r0,s, e, n, d, m, o, r, y});

            var result = q.ToList();
            stopWatch.Stop();
            var ts = stopWatch.Elapsed;

            var elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            elapsedTime.Dump();    

		                

	    }

	    public static int ToNum(int v4, int v3, int v2, int v1, int v0)
	    {
	        return v4*10000 + v3*1000 + v2*100 + v1*10 + v0;
	    }
        
        public static int ToNum(int v3, int v2, int v1, int v0)
	    {
	        return  v3*1000 + v2*100 + v1*10 + v0;
	    }   
        public static int ToNum(  int v2, int v1, int v0)
	    {
	        return  v2*100 + v1*10 + v0;
	    }

	    public static int ToNum(int v1, int v0)
	    {
	        return v1*10 + v0;
	    }

	    public static int ToNum(  int v0)
	    {
	        return  v0;
	    }
       
        

	    public static void LinqVersionFastest()
        {

            var stopWatch = new Stopwatch();
            stopWatch.Start();
            
            var range = Enumerable.Range(0, 10).ToArray();

	       

	        var sub1 = (
	            from d in range
	            from e in range
	            from y in range

	            where (d + e == y || d + e == (10 + y)) && d != e && d != e && d != y
	            select new {d, e, y}).ToArray();
            
//            var sub2 = (
//	            from n in range
//	            from r in range
//	            from e in range
//
//                where (n + r == e || n + r == (10 + e) || n + r+1 == e || n+r+e==e+10  ) && n != r && n != e && r != e
//	            select new {n, r, e}).ToArray();


            //.Except(new[]{0})

            var q = (
	
                from i1 in sub1.ToArray()
                from s in range
                    
	            from n in range
	            from m in range
	            from o in range
	            from r in range


                let t1 = ToNum(s, i1.e, n, i1.d)
                let t2 = ToNum(m, o, r, i1.e)
                let r0 = ToNum(m, o, n, i1.e, i1.y)

	            where t1+t2==r0 &&

                        s!=0 && m!=0 &&
                        s != i1.e && s != n && s != i1.d && s != m && s != o && s != r && s != i1.y &&
                        i1.e != n && i1.e != i1.d && i1.e != m && i1.e != o && i1.e != r && i1.e != i1.y &&
                        n != i1.d && n != m && n != o && n != r && n != i1.y &&
                        i1.d != m && i1.d != o && i1.d != r && i1.d != i1.y &&
                        m != o && m != r && m != i1.y &&
                        o != r && o != i1.y &&
                        r != i1.y

                select new { t1, t2, r0, s, i1.e, n, i1.d, m, o, r, i1.y });

            var result = q.ToList();
            stopWatch.Stop();
            var ts = stopWatch.Elapsed;

            var elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",ts.Hours, ts.Minutes, ts.Seconds,ts.Milliseconds / 10);
            elapsedTime.Dump();

            "Done-LinqVersionFastest".Dump(); 

		                

	    }

        public static void LinqVersionFaster()
        {


            var stopWatch = new Stopwatch();
            stopWatch.Start();
            var range = Enumerable.Range(0, 10).ToArray();
            //
            //
            //	        var sub1 = (
            //	            from d in range
            //	            from e in range
            //	            from y in range
            //
            //	            where (d + e == y || d + e == (10 + y)) && d != e && d != e && d != y
            //	            select new {d, e, y});
            //
            //


            var q = (
                from s in range
                from e in range
                from n in range
                from d in range
                from m in range
                from o in range
                from r in range
                from y in range

                //let t1=int.Parse(string.Format("{0}{1}{2}{3}",s,e,n,d))
                //let t2=int.Parse(string.Format("{0}{1}{2}{3}",m,o,r,e))
                //let r0=int.Parse(string.Format("{0}{1}{2}{3}{4}",m,o,n,e,y))
                let t1 = ToNum(s, e, n, d)
                let t2 = ToNum(m, o, r, e)
                let r0 = ToNum(m, o, n, e, y)

                where t1 + t2 == r0 && (d + e == y || d + e == (10 + y)) &&
                        s != e && s != n && s != d && s != m && s != o && s != r && s != y &&
                        e != n && e != d && e != m && e != o && e != r && e != y &&
                        n != d && n != m && n != o && n != r && n != y &&
                        d != m && d != o && d != r && d != y &&
                        m != o && m != r && m != y &&
                        o != r && o != y &&
                        r != y

                select new { t1, t2, r0, s, e, n, d, m, o, r, y });

            var result = q.ToList();
            stopWatch.Stop();
            var ts = stopWatch.Elapsed;

            var elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            elapsedTime.Dump();
            "Done-LinqVersionFaster".Dump();



        }

	    public static void TimeCall(Action t)
	    {
	        
            var stopWatch = new Stopwatch();
            stopWatch.Start();

	        t();

            stopWatch.Stop();
            var ts = stopWatch.Elapsed;

            var elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            elapsedTime.Dump();
            "Done".Dump();

	    }

	    public static void stephenVersion()
	    {
	        
        
			var vals = Enumerable.Range(0, 10);
			
			var solve =
				from m in vals
				from o in vals.Except(new[] { m })
				from n in vals.Except(new[] { m, o })
				from e in vals.Except(new[] { m, o, n })
				from y in vals.Except(new[] { m, o, n, e })
				from s in vals.Except(new[] { m, o, n, e, y })
				from d in vals.Except(new[] { m, o, n, e, y, s })
				from r in vals.Except(new[] { m, o, n, e, y, s, d })
			
				// Don't include solutions that have numbers that start with Zero
				where s != 0
				where m != 0
			
				let send = s * 1000 + e * 100 + n * 10 + d
				let more = m * 1000 + o * 100 + r * 10 + e
				let money = m * 10000 + o * 1000 + n * 100 + e * 10 + y
			
				where send + more == money
				select new { send, more, money };
			
			  var res= solve.FirstOrDefault().ToString();



	    }
    }
}
