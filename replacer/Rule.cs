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
        public string Expression { get; set; }
        public string Replacement { get; set; }
        public Color RuleColor { get; set; } = Color.Blue;
        public bool Enabled { get; set; } = true;
    }   
}
