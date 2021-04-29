using BL_Interface;
using DAO;
using DAO_Interface;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BL
{
    public class BL_Fund : BL_Fund_Interface
    {
        private IFund_DAO_Interface _fundDAO = new Fund_DAO();
        public BL_Fund()
        {
            this._fundDAO = new Fund_DAO();
        }
        public void AddFund(Fund fund)
        {
            _fundDAO.AddFund(fund);
        }
        public void DeleteFund(string FundName)
        {
            _fundDAO.DeleteFund(FundName);
        }
        public IEnumerable <Fund> GetAllFunds()
        {
            return _fundDAO.GetAllFunds();
        }
    }
}
