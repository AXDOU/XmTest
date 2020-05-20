using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using XmTest.Basic.DTO;

namespace XmTest.Areas.CssDemo.Controllers
{
    public class JsDemoController : Controller
    {
        //
        // GET: /CssDemo/Js/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult TestJson()
        {
            var jsons = "[{\"pid\":\"49\",\"pgid\":\"4\",\"pname\":\"全能虚拟主机400\",\"pstock\":\"-1\",\"pdes\":\"<p>功能说明：支持php5.2-PHP7.1 自由切换,独立管理面板，30天自动云端备份.数据库需单独购买，禁止大文件下载！</p>\",\"phidden\":\"0\",\"pprice\":{\"cprice\":\"420\",\"onetime\":\"150\",\"cycle\":\"12\",\"pmothod\":\"1\"},\"pconfig\":{\"Connections\":\"0\",\"WebSize\":\"400\",\"MsSqlSize\":\"-1\",\"MySqlSize\":\"-1\",\"DomainSum\":\"0\",\"productid\":\"19\"},\"pupgrade\":\"{}\",\"psconfig\":{\"time_cycle\":\"0\",\"nastock\":\"0\",\"pricedes\":\"\",\"trial_hours\":\"0\",\"referralrate\":\"0\",\"servicestatus\":\"-1\",\"buylimit\":\"0\"}},{\"pid\":\"48\",\"pgid\":\"4\",\"pname\":\"全能虚拟主机300\",\"pstock\":\"-1\",\"pdes\":\"<p>功能说明：支持asp、.net2.0-net4.7 自由切换,独立控制面板,30天自动云端备份，数据库需单独购买，禁止大文件下载！</p>\",\"phidden\":\"0\",\"pprice\":{\"cprice\":\"320\",\"onetime\":\"100\",\"cycle\":\"12\",\"pmothod\":\"1\"},\"pconfig\":{\"Connections\":\"0\",\"WebSize\":\"300\",\"MsSqlSize\":\"-1\",\"MySqlSize\":\"-1\",\"DomainSum\":\"0\",\"productid\":\"19\"},\"pupgrade\":\"{}\",\"psconfig\":{\"time_cycle\":\"0\",\"nastock\":\"0\",\"pricedes\":\"\",\"trial_hours\":\"0\",\"referralrate\":\"0\",\"servicestatus\":\"-1\",\"buylimit\":\"0\"}},{\"pid\":\"45\",\"pgid\":\"4\",\"pname\":\"全能虚拟主机200\",\"pstock\":\"-1\",\"pdes\":\"<p>功能说明：支持asp、.net2.0-net4.7 自由切换,独立控制面板,30天自动云端备份，数据库需单独购买，禁止大文件下载！</p>\",\"phidden\":\"0\",\"pprice\":{\"cprice\":\"220\",\"onetime\":\"50\",\"cycle\":\"12\",\"pmothod\":\"1\"},\"pconfig\":{\"Connections\":\"0\",\"WebSize\":\"200\",\"MsSqlSize\":\"-1\",\"MySqlSize\":\"-1\",\"DomainSum\":\"0\",\"productid\":\"19\"},\"pupgrade\":\"{}\",\"psconfig\":{\"time_cycle\":\"0\",\"nastock\":\"0\",\"pricedes\":\"\",\"trial_hours\":\"0\",\"referralrate\":\"0\",\"servicestatus\":\"-1\",\"buylimit\":\"0\"}},{\"pid\":\"42\",\"pgid\":\"4\",\"pname\":\"全能虚拟主机100\",\"pstock\":\"-1\",\"pdes\":\"<p>功能说明：支持php5.2-PHP7.1 自由切换,独立管理面板，30天自动云端备份.数据库需单独购买，禁止大文件下载！</p>\",\"phidden\":\"0\",\"pprice\":{\"cprice\":\"120\",\"onetime\":\"10\",\"cycle\":\"12\",\"pmothod\":\"1\"},\"pconfig\":{\"Connections\":\"0\",\"WebSize\":\"100\",\"MsSqlSize\":\"0\",\"MySqlSize\":\"0\",\"DomainSum\":\"0\",\"productid\":\"19\"},\"pupgrade\":\"{}\",\"psconfig\":{\"time_cycle\":\"0\",\"nastock\":\"0\",\"pricedes\":\"\",\"trial_hours\":\"24\",\"nodiscount\":\"1\",\"referralrate\":\"0\",\"servicestatus\":\"-1\",\"buylimit\":\"0\"}}]";
            var root = JsonConvert.DeserializeObject<JArray>(jsons);
            var pid = root[0]["pid"].ToString();
            var pconfig = root[0]["pconfig"].ToString();
            var dto = JsonConvert.DeserializeObject<List<Dto>>(jsons);
            return View();
        }
    }
}
