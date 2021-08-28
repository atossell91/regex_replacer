using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace replacer
{
    public class Rule
    {
        public string Expression;
        public string Replacement;
        public Color RuleColor = Color.Blue;
        public bool Enabled = true;
    }
}
