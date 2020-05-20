using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using XmTest.Data.Entity;
using XmTest.Service.Basic;
using XmTest.Basic.Web;
using XmTest.Basic.Helpers;
using System.Threading.Tasks;
using System.Diagnostics;

namespace XmTest.Controllers
{
    public class HomeController : BaseWebController
    {
        //
        // GET: /Home/


        public ActionResult Index(Page page)
        {
            return base.Visit(() =>
            {
                NotesService notesService = new NotesService();
                notesService.TestInvokeEvent();
                NotesService.Instance.TestInvokeEvent();
                var notes = NotesService.Instance.GetNotes(page);
                return View(notes);
            });
        }
        /// <summary>
        /// 导航栏测试页
        /// </summary>
        /// <returns></returns>
        public ActionResult Test()
        {
            return View();
        }

        public ActionResult Tud()
        {
            return View();
        }


        /// <summary>
        /// 404错误页
        /// </summary>
        /// <returns></returns>
        public ActionResult ErrorNoFund()
        {
            return View();
        }

        /// <summary>
        /// 通用错误页
        /// </summary>
        /// <returns></returns>
        public ActionResult Error()
        {
            return View();
        }
    }
}
