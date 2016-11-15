using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace vue_test.Areas.Test.Controllers
{
    public class BaseController : Controller
    {
        //
        // GET: /Test/Base/
        
        /// <summary>
        /// 起步
        /// </summary>
        /// <returns></returns>
        public ActionResult Index1()
        {
            return View();
        }

        /// <summary>
        /// 计算属性、Class与style的绑定
        /// </summary>
        /// <returns></returns>
        public ActionResult Index2()
        {
            return View();
        }

        /// <summary>
        /// 条件渲染
        /// </summary>
        /// <returns></returns>
        public ActionResult Index3()
        {
            return View();
        }

        /// <summary>
        /// 列表渲染
        /// </summary>
        /// <returns></returns>
        public ActionResult Index4()
        {
            return View();
        }

        /// <summary>
        /// 事件
        /// </summary>
        /// <returns></returns>
        public ActionResult Index5()
        {
            return View();
        }

        /// <summary>
        /// 组件
        /// </summary>
        /// <returns></returns>
        public ActionResult Index6()
        {
            return View();
        }
    }
}
