using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_List_Library
{
    /// <summary>
    /// Node 
    /// </summary>
    public class MYLLNode
    {
        internal object data;
        MYLLNode next;

        public MYLLNode(object data)
        {
            this.data = data;
            next = null;

        }
        public MYLLNode Next { get { return next; } }
        
    }


}
