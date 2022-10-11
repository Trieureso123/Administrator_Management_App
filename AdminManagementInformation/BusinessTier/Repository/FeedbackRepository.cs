using Library.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Repository
{
    public interface IFeedbackRepository
    {
        IEnumerable<Feedback> GetFeedback();
        void UpdateFeedback();
    }

    public class FeedbackRepository : IFeedbackRepository
    {
        public IEnumerable<Feedback> GetFeedback()
        {
            var feedbacks = new List<Feedback>();
            try
            {
                using var context = new GameDBContext();
                feedbacks = context.Feedbacks.ToList();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return feedbacks;
        }

        public void UpdateFeedback()
        {

        }
    }
}
