using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkFinder.Models
{
    public class AdPostManager
    {
        public AdPost GetPostById(IEnumerable<AdPost> adposts, int id)
        {
            AdPost post = null;
            foreach (AdPost p in adposts)
            {
                if (p.AdPostId == id)
                {
                    post = p;
                }
            }
            return post;
        }
        public Request GetRequestById(IEnumerable<Request> requests, int id)
        {
            Request request = null;
            foreach (Request r in requests)
            {
                if (r.RequestId == id)
                {
                    request = r;
                }
            }
            return request;
        }

    }
}
