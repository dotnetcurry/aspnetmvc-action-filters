using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ActionFilterDemo.Filters
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class ActionSpeedProfilerAttribute : FilterAttribute, IActionFilter
    {
        private Stopwatch timer;
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            timer.Stop();
            if (filterContext.Exception == null)
            {
                string div = string.Format(@"
                    <div style='position:absolute;
                     left:0px; top:0px;
                     width:280px; height:20px;
                     text-align:center;
                     background-color:#000000; color:#FFFFFF'>
                        Action method took: {0} seconds
                    </div>",
                timer.Elapsed.TotalSeconds.ToString("F6"));
                filterContext.HttpContext.Response.Write(div);
            }
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            timer = Stopwatch.StartNew();
        }
    }
}