using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XmTest.Data.Entity;
using XmTest.IRepository;
using XmTest.Repository;
using XmTest.IRepository.sysBasic;
using XmTest.Repository.sysBasic;
using XmTest.Data.Factory;
using XmTest.Basic.Util;
using XmTest.Basic.Web;
using XmTest.Service.Event;

namespace XmTest.Service.Basic
{
    public class NotesService
    {
        public static NotesService Instance
        {
            get
            {
                return DALFactory<NotesService>.Instance;
            }
        }
        private INotesRepository noteService = new NotesRepository();
        private IX_ClassifyRepository classifyService = new X_ClassifyRepository();
        private ClassifyEventService classifyEvent = new ClassifyEventService();
        public NotesService()
        {
            classifyEvent.SubcribeEvent();
        }

        public void TestInvokeEvent()
        {
           bool isfailed =  classifyEvent.InvokeClassifyCountEvent(1);
        }
     
        public List<Notes> GetNotes(Page page)
        {
            page.sortcol = "Id";
            List<Notes> Notes = noteService.FindList(page);
          
            Notes.ForEach(x => x.Content.ToEllipsisString(100));
            return Notes;
        }

        public List<Notes> GetMyNotes(int userId)
        {
            if (userId < 1 ) return new List<Notes>();
            List<Notes> notes = noteService.GetList(x => x.UserID == userId);
            return notes;
        }


        /// <summary>
        /// 获取单个详情
        /// </summary>
        /// <param name="category"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public List<Notes> GetclassifyDetail(string category, int userId)
        {
            X_Classify classify = classifyService.GetModel(x => x.Name == category.Trim() && x.UserID == userId);
            if (classify == null) return null;

            List<Notes> xcList = noteService.GetList(x => x.ClassifyID == classify.Id && x.UserID == userId && x.Content != null);
            return xcList;
        }


        public Dictionary<string, string> GetClassifyfield(int userId)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();

            List<X_Classify> xcList = classifyService.GetList(x => x.UserID == userId);

            xcList.ForEach(x =>
                            {
                                dic.Add(x.Id.ToString(), x.Name);
                            });
            return dic;
        }

    }
}
