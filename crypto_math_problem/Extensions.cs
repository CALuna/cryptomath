using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace crypto_math_problem
{
    public static class Extensions
    {

        public static void Dump(this string s )
        {
            Console.WriteLine(s);
        }

        public static void Dump(this string s,  params object[] args )
        {
            Console.WriteLine(s,args);
        }

        
        public static IEnumerable<Mappings<int>> GetMappings(this string chars, int[] values, Mappings<int[]> exclusions=null )
        {
            if (chars.Length == 0)
                yield break;
            exclusions = exclusions ?? new Mappings<int[]>(); 
            var curChar =  chars.Take(1).First();
            var subphrase = new string( chars.Skip(1).ToArray());
            
            var charExclusion= exclusions[curChar] ?? new int[0]; 
        
            foreach (var val in values.Except(charExclusion))
            {
                var v = values.Except(new[] {val}).ToArray();
                if (subphrase.Length > 0)
                {
                    foreach (var mapping in subphrase.GetMappings(v,exclusions))
                    {
                        mapping[curChar] = val ;
                        yield return mapping;
                    }
                }
                else
                {
                    var mapping=new Mappings<int>();
                    mapping[curChar] = val;
                    yield return mapping;
                }
            }
		


        }

    }

    
}