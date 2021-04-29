using Entity;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAO_Interface
{
    public interface IFund_DAO_Interface
    {
        void AddFund(Fund fund);
        void DeleteFund(string FundName);
        IEnumerable<Fund> GetAllFunds();
        
        

    }
}
