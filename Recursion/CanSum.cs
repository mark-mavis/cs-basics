using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    
    class CanSum
    {
        private Dictionary<int, bool> _map = new Dictionary<int, bool>() { };
        private List<int> _list;
        
        public CanSum(List<int> list)
        {
            this._list = list;
        }
            
        public bool RunCanSum(int targetSum)
        {
            if (_map.ContainsKey(targetSum))
            {
                return _map[targetSum];
            }
            
            if(targetSum == 0) return true;
            if(targetSum < 0) return false;

            for(int i = 0; i < _list.Count; i++)
            {
                int remainder = targetSum - _list[i];
                if(RunCanSum(remainder) == true)
                {
                    _map[targetSum] = true;
                    return true;
                }
            }
            _map[targetSum] = false;
            return false;
        }
    }
}
