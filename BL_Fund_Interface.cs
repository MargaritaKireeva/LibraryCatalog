using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BL_Interface
{
    public interface BL_Fund_Interface
    {
        void AddFund(Fund fund);
        void DeleteFund(string FundName);
        IEnumerable<Fund> GetAllFunds();
    }
}
