using System.Collections.Generic;
using System.Text;

namespace crypto_math_problem
{
    public class CharMappings:List<CharMapping>
    {
        public CharMappings()
        {
        }
        public CharMappings(IEnumerable<CharMapping> values )
        {
            base.AddRange(values);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            var first = true;
            foreach (var m in this)
            {
                if (!first)
                    sb.Append(",");
	           
                sb.AppendFormat("{0}:{1}", m.Key, m.Value); 
                first = false;
            }
            return sb.ToString();
        }
    }
}