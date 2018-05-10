using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CSIapp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;


namespace CSIapp.Controllers
{
    public class HomeController : Controller
    {
        private csidataContext _context;

        public HomeController(csidataContext context){
            _context=context;
        }
        public async Task<IActionResult> Index()
        {
            var viewModel = from o in _context.RequestMetrics.Take(15) join o2 in _context.RequestMetricsDetails.Take(15) on o.RequestMetricId equals o2.RequestMetricId where o.RequestMetricId.Equals(o2.RequestMetricId) select new BigDataModel { RequestMetric = o, RequestMetricDetail = o2};
            return View(viewModel);
        }
        public IActionResult Search()
        {
            ViewData["Message"] = "Search page";

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SearchResults(SearchViewModel search,int page)
        {

            var data = from o in _context.RequestMetrics join o2 in _context.RequestMetricsDetails on o.RequestMetricId equals o2.RequestMetricId where o.RequestMetricId.Equals(o2.RequestMetricId) select new BigDataModel { RequestMetric = o, RequestMetricDetail = o2};

            if(search.SearchBankNumber == null && search.SearchUserId == null && search.SearchApimethod == null && search.SearchStartTime == null && search.SearchEndTime == null){
                
                var filtered = data.Where(s => s.RequestMetricDetail.IsError == search.SearchIsError);


                const int PageSize = 25;
                var count = filtered.Count();
                var data2 = filtered.Skip(page * PageSize).Take(PageSize).ToList();
                ViewBag.MaxPage = (count/PageSize) - (count % PageSize == 0?1:0);
                ViewBag.Page = page;
                return View(data2);
            }
            else if(search.SearchUserId == null && search.SearchApimethod == null && search.SearchStartTime == null && search.SearchEndTime == null){
                var filtered = data.Where(s => s.RequestMetric.BankNumber == search.SearchBankNumber && 
                s.RequestMetricDetail.IsError == search.SearchIsError);


                const int PageSize = 25;
                var count = filtered.Count();
                var data2 = filtered.Skip(page * PageSize).Take(PageSize).ToList();
                ViewBag.MaxPage = (count/PageSize) - (count % PageSize == 0?1:0);
                ViewBag.Page = page;
                return View(data2);
            }
            else if(search.SearchBankNumber == null && search.SearchApimethod == null && search.SearchStartTime == null && search.SearchEndTime == null){
                var filtered = data.Where(s => s.RequestMetric.UserId == search.SearchUserId && 
                s.RequestMetricDetail.IsError == search.SearchIsError);


                const int PageSize = 25;
                var count = filtered.Count();
                var data2 = filtered.Skip(page * PageSize).Take(PageSize).ToList();
                ViewBag.MaxPage = (count/PageSize) - (count % PageSize == 0?1:0);
                ViewBag.Page = page;
                return View(data2);
            }
            else if(search.SearchBankNumber == null && search.SearchUserId == null && search.SearchStartTime == null && search.SearchEndTime == null){
                
                var filtered = data.Where(s => s.RequestMetric.Apimethod == search.SearchApimethod && 
                s.RequestMetricDetail.IsError == search.SearchIsError);


                const int PageSize = 25;
                var count = filtered.Count();
                var data2 = filtered.Skip(page * PageSize).Take(PageSize).ToList();
                ViewBag.MaxPage = (count/PageSize) - (count % PageSize == 0?1:0);
                ViewBag.Page = page;
                return View(data2);
            }
            else if(search.SearchBankNumber == null && search.SearchUserId == null && search.SearchApimethod == null){
                
                var filtered = data.Where(s => s.RequestMetricDetail.IsError == search.SearchIsError && s.RequestMetric.Timestamp >= search.SearchStartTime && s.RequestMetric.Timestamp <= search.SearchEndTime);


                const int PageSize = 25;
                var count = filtered.Count();
                var data2 = filtered.Skip(page * PageSize).Take(PageSize).ToList();
                ViewBag.MaxPage = (count/PageSize) - (count % PageSize == 0?1:0);
                ViewBag.Page = page;
                return View(data2);
            }
            else if(search.SearchApimethod == null && search.SearchStartTime == null && search.SearchEndTime == null){
                
                var filtered = data.Where(s => s.RequestMetric.BankNumber == search.SearchBankNumber && s.RequestMetric.UserId == search.SearchUserId && 
                s.RequestMetricDetail.IsError == search.SearchIsError);


                const int PageSize = 25;
                var count = filtered.Count();
                var data2 = filtered.Skip(page * PageSize).Take(PageSize).ToList();
                ViewBag.MaxPage = (count/PageSize) - (count % PageSize == 0?1:0);
                ViewBag.Page = page;
                return View(data2);
            }
            else if(search.SearchUserId == null && search.SearchStartTime == null && search.SearchEndTime == null){
                
                var filtered = data.Where(s => s.RequestMetric.BankNumber == search.SearchBankNumber && s.RequestMetric.Apimethod == search.SearchApimethod && 
                s.RequestMetricDetail.IsError == search.SearchIsError);


                const int PageSize = 25;
                var count = filtered.Count();
                var data2 = filtered.Skip(page * PageSize).Take(PageSize).ToList();
                ViewBag.MaxPage = (count/PageSize) - (count % PageSize == 0?1:0);
                ViewBag.Page = page;
                return View(data2);
            }
            else if(search.SearchBankNumber == null && search.SearchStartTime == null && search.SearchEndTime == null){
                
                var filtered = data.Where(s => s.RequestMetric.UserId == search.SearchUserId && s.RequestMetric.Apimethod == search.SearchApimethod && 
                s.RequestMetricDetail.IsError == search.SearchIsError);


                const int PageSize = 25;
                var count = filtered.Count();
                var data2 = filtered.Skip(page * PageSize).Take(PageSize).ToList();
                ViewBag.MaxPage = (count/PageSize) - (count % PageSize == 0?1:0);
                ViewBag.Page = page;
                return View(data2);
            }
            else if(search.SearchStartTime == null && search.SearchEndTime == null){
                
                var filtered = data.Where(s => s.RequestMetric.BankNumber == search.SearchBankNumber && s.RequestMetric.UserId == search.SearchUserId && s.RequestMetric.Apimethod == search.SearchApimethod && 
                s.RequestMetricDetail.IsError == search.SearchIsError);


                const int PageSize = 25;
                var count = filtered.Count();
                var data2 = filtered.Skip(page * PageSize).Take(PageSize).ToList();
                ViewBag.MaxPage = (count/PageSize) - (count % PageSize == 0?1:0);
                ViewBag.Page = page;
                return View(data2);
            }
            else if(search.SearchUserId == null && search.SearchApimethod == null){
                
                var filtered = data.Where(s => s.RequestMetric.BankNumber == search.SearchBankNumber && 
                s.RequestMetricDetail.IsError == search.SearchIsError && s.RequestMetric.Timestamp >= search.SearchStartTime && s.RequestMetric.Timestamp <= search.SearchEndTime);


                const int PageSize = 25;
                var count = filtered.Count();
                var data2 = filtered.Skip(page * PageSize).Take(PageSize).ToList();
                ViewBag.MaxPage = (count/PageSize) - (count % PageSize == 0?1:0);
                ViewBag.Page = page;
                return View(data2);
            }
            else{
                var filtered = data.Where(s => s.RequestMetric.BankNumber == search.SearchBankNumber && s.RequestMetric.UserId == search.SearchUserId && s.RequestMetric.Apimethod == search.SearchApimethod && 
                s.RequestMetricDetail.IsError == search.SearchIsError && s.RequestMetric.Timestamp >= search.SearchStartTime && s.RequestMetric.Timestamp <= search.SearchEndTime);


                const int PageSize = 25;
                var count = filtered.Count();
                var data2 = filtered.Skip(page * PageSize).Take(PageSize).ToList();
                ViewBag.MaxPage = (count/PageSize) - (count % PageSize == 0?1:0);
                ViewBag.Page = page;
                return View(data2);
            }
                        
        }

        public async Task<IActionResult> RequestMetricDetails(long RequestMetricId)
        {
            var data = from o in _context.RequestMetrics join o2 in _context.RequestMetricsDetails on o.RequestMetricId equals o2.RequestMetricId where o.RequestMetricId.Equals(o2.RequestMetricId) select new BigDataModel { RequestMetric = o, RequestMetricDetail = o2};

            var filtered = data.Where(s => s.RequestMetricDetail.RequestMetricId == RequestMetricId);

            return View(filtered);

        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
