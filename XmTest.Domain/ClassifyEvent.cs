using System;
using System.Data;
using XmTest.IRepository.sysBasic;
using XmTest.Repository.sysBasic;

namespace XmTest.Domain
{
    public class ClassifyEvent
    {
        //public  delegate void ClassifyCountDelegate(int id);
        public event Func<int,bool>   ClassifyCountSevent;
        private IX_ClassifyRepository service = new X_ClassifyRepository();
        /// <summary>
        /// 订阅事件
        /// </summary>
        public void SubcribeEvent()
        {
            ClassifyCountSevent += (id) => {
                return service.UpdateSingleClassifyCount(id);
            };
        }


        /// <summary>
        /// 调用事件
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool InvokeClassifyCountEvent(int id)
        {
            return this.ClassifyCountSevent.Invoke(id);
        }
    }
}
