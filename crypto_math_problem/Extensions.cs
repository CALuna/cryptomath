using System;
using System.Collections.Generic;
using System.Linq;

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



        public static CharMappings ToCharMappings(this Dictionary<char, int> d)
        {
            return new CharMappings( d.Select(kvp => new CharMapping {Key = kvp.Key, Value = kvp.Value}).ToList());
        }




        public static IEnumerable<CharMappings> GetMappingsOrg(this string chars, int[] values)
        {

            if (chars.Length == 0)
                yield break;
			 
            var curChar =  chars.Take(1).First();
            var subphrase = new string( chars.Skip(1).ToArray());

            foreach (var val in values)
            {
                var v = values.Except(new[]{val}).ToArray();
                if (subphrase.Length > 0)
                {
                    foreach (var mapping in subphrase.GetMappingsOrg(v))
                    {
                        mapping.Add(new CharMapping { Key = curChar, Value = val });
                        yield return mapping;
                    }
                }
                else
                {
                    yield return  new CharMappings {new CharMapping {Key = curChar, Value = val}};
                }
            }
		


        }
        public static IEnumerable<Mappings> GetMappings(this string chars, int[] values)
        {

            if (chars.Length == 0)
                yield break;
			 
            var curChar =  chars.Take(1).First();
            var subphrase = new string( chars.Skip(1).ToArray());

            foreach (var val in values)
            {
                var v = values.Except(new[]{val}).ToArray();
                if (subphrase.Length > 0)
                {
                    foreach (var mapping in subphrase.GetMappings(v))
                    {
                        mapping[curChar] = val ;
                        yield return mapping;
                    }
                }
                else
                {
                    var mapping=new Mappings();
                    mapping[curChar] = val;
                    yield return mapping;
                  
                }
            }
		


        }

        public static string Replace(this string s, CharMappings map)
        {
		
            foreach (var c in map)
            {	
                s=s.Replace(c.Key,c.Value.ToString()[0]);
			
            }
            return s;
		
	
        }

    }
}